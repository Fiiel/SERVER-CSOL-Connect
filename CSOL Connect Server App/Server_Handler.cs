using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Data.SqlClient;

namespace CSOL_Connect_Server_App
{
    internal class Server_Handler
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        private SuperAdmin_Mapping superAdmin_MappingForm; // Reference to the mapping form
        private Admin_Mapping admin_MappingForm; // Reference to the mapping form
        private LoadingScreenForm loadingScreenForm;

        public Server_Handler(SuperAdmin_Mapping superAdmin_MappingForm)
        {
            this.superAdmin_MappingForm = superAdmin_MappingForm;
        }

        public Server_Handler(Admin_Mapping admin_MappingForm)
        {
            this.admin_MappingForm = admin_MappingForm;
        }

        public Server_Handler(LoadingScreenForm loadingScreenForm)
        {
            this.loadingScreenForm = loadingScreenForm;
        }

        public async Task NetworkMain()
        {
            int port = 23000; // Change this to your desired port number
            TcpListener server = null;

            try
            {
                // Initialize a TCP listener on the specified port
                server = new TcpListener(IPAddress.Any, port);
                server.Start();

                while (true)
                {
                    // Accept a client connection asynchronously
                    TcpClient client = await server.AcceptTcpClientAsync();

                    // Handle the client in a separate thread
                    _ = HandleClientAsync(client);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                server?.Stop();
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Debug.WriteLine(message);

                    // Split the message to separate PC name and message
                    string[] parts = message.Split(':');
                    if (parts.Length == 2)
                    {
                        string pcName = parts[0];
                        string clientMessage = parts[1];

                        // Now you have the PC name and the client's message
                        // Use the PC name to identify the target PC in your mapping panel and update it with the message.
                        Debug.WriteLine("1st stop");

                        if (superAdmin_MappingForm != null)
                        {
                            Debug.WriteLine("2nd stop");

                            superAdmin_MappingForm.UpdatePCOnMappingPanel(pcName, clientMessage);
                            SuperAdmin_PCInfo pcInfoForm = Application.OpenForms.OfType<SuperAdmin_PCInfo>().FirstOrDefault(form => form.PCName == pcName);

                            if (clientMessage.Contains("Mouse is connected"))
                            {
                                UpdateMouseIconInDatabase(pcName, clientMessage);
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateMouseStatusImage(true);

                                }
                            }

                            if (clientMessage.Contains("Mouse is disconnected"))
                            {
                                UpdateMouseIconInDatabase(pcName, clientMessage);
                                LogMouseDisconnection(pcName);
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateMouseStatusImage(false);
                                }
                            }

                            if (clientMessage.Contains("Keyboard is connected"))
                            {
                                UpdateKeyboardIconInDatabase(pcName, clientMessage);
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateKeyboardStatusImage(true);
                                }
                            }

                            else if (clientMessage.Contains("Keyboard is disconnected"))
                            {
                                UpdateKeyboardIconInDatabase(pcName, clientMessage);
                                LogKeyboardDisconnection(pcName);
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateKeyboardStatusImage(false);
                                }
                            }
                        }
                    }
                }

                client.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private void UpdateMouseIconInDatabase(string pcName, string clientMessage)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Determine the mouse icon path based on the clientMessage
                        string mouseIconPath = "";

                        if (clientMessage.Contains("Mouse is connected"))
                        {
                            mouseIconPath = "img\\circle_green.png";
                        }
                        else if (clientMessage.Contains("Mouse is disconnected"))
                        {
                            mouseIconPath = "img\\circle_red.png";
                        }

                        // Update the database with the new mouse icon path
                        string updateQuery = "UPDATE PCMap SET MouseIconPath = @MouseIconPath WHERE PCName = @PCName";

                        command.CommandText = updateQuery;
                        command.Parameters.AddWithValue("@MouseIconPath", mouseIconPath);
                        command.Parameters.AddWithValue("@PCName", pcName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating mouse icon in the database: {ex.Message}");
            }
        }

        private void UpdateKeyboardIconInDatabase(string pcName, string clientMessage)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Determine the keyboard icon path based on the clientMessage
                        string keyboardIconPath = "";

                        if (clientMessage.Contains("Keyboard is connected"))
                        {
                            keyboardIconPath = "img\\circle_green.png";
                        }
                        else if (clientMessage.Contains("Keyboard is disconnected"))
                        {
                            keyboardIconPath = "img\\circle_red.png";
                        }

                        // Update the database with the new keyboard icon path
                        string updateQuery = "UPDATE PCMap SET KeyboardIconPath = @KeyboardIconPath WHERE PCName = @PCName";

                        command.CommandText = updateQuery;
                        command.Parameters.AddWithValue("@KeyboardIconPath", keyboardIconPath);
                        command.Parameters.AddWithValue("@PCName", pcName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating keyboard icon in the database: {ex.Message}");
            }
        }

        private void LogMouseDisconnection(string pcName)
        {
            try
            {
                // Get the CLno from the database
                int clno = GetCLnoFromDatabase(pcName);

                if (clno != -1)
                {
                    string currentDateFormatted = DateTime.Now.ToString("MMM dd yyyy");
                    string currentTimeFormatted = DateTime.Now.ToString("h:mm tt");

                    // Create a SQL connection and insert a new row into the HistoryLog table
                    using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                    {
                        connection.Open();
                        string query = "INSERT INTO HistoryLog (PCName, CLno, Issue_Desc, Date, Time) VALUES (@pcName, @clno, @issueDesc, @date, @time)";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@pcName", pcName);
                        command.Parameters.AddWithValue("@clno", clno);
                        command.Parameters.AddWithValue("@issueDesc", "Mouse is disconnected");
                        command.Parameters.AddWithValue("@date", currentDateFormatted); // Use the formatted date string
                        command.Parameters.AddWithValue("@time", currentTimeFormatted); // You can leave the time part empty

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error logging mouse disconnection: " + ex.Message);
            }
        }

        private void LogKeyboardDisconnection(string pcName)
        {
            try
            {
                // Get the CLno from the database
                int clno = GetCLnoFromDatabase(pcName);

                if (clno != -1)
                {
                    string currentDateFormatted = DateTime.Now.ToString("MMM dd yyyy");
                    string currentTimeFormatted = DateTime.Now.ToString("h:mm tt");

                    // Create a SQL connection and insert a new row into the HistoryLog table
                    using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                    {
                        connection.Open();
                        string query = "INSERT INTO HistoryLog (PCName, CLno, Issue_Desc, Date, Time) VALUES (@pcName, @clno, @issueDesc, @date, @time)";
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@pcName", pcName);
                        command.Parameters.AddWithValue("@clno", clno);
                        command.Parameters.AddWithValue("@issueDesc", "Keyboard is disconnected");
                        command.Parameters.AddWithValue("@date", currentDateFormatted);
                        command.Parameters.AddWithValue("@time", currentTimeFormatted); // Use the formatted time

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error logging keyboard disconnection: " + ex.Message);
            }
        }

        private int GetCLnoFromDatabase(string pcName)
        {
            int clno = -1; // Default value in case of an error or not found

            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();
                    string query = "SELECT CLno FROM PCMap WHERE PCName = @pcName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@pcName", pcName);

                    // Execute the query to retrieve CLno
                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        clno = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error fetching CLno from the database: " + ex.Message);
            }

            return clno;
        }
    }
}
