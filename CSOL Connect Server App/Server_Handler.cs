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

        private LoadingScreenForm loadingScreenForm; // Reference to the mapping form
        private SuperAdmin_Mapping mappingForm; // Reference to the mapping form
        private Admin_Mapping admin_Mapping; // Reference to the mapping form

        public Server_Handler(SuperAdmin_Mapping mappingForm)
        {
            this.mappingForm = mappingForm;
        }

        public Server_Handler(Admin_Mapping admin_Mapping)
        {
            this.admin_Mapping = admin_Mapping;
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

                        if (mappingForm != null)
                        {
                            mappingForm.UpdatePCOnMappingPanel(pcName, clientMessage);
                            SuperAdmin_PCInfo pcInfoForm = Application.OpenForms.OfType<SuperAdmin_PCInfo>().FirstOrDefault(form => form.PCName == pcName);

                            if (clientMessage.Contains("Mouse is connected"))
                            {
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateMouseStatusImage(true);

                                }
                            }

                            if (clientMessage.Contains("Mouse is disconnected"))
                            {
                                LogMouseDisconnection(pcName);
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateMouseStatusImage(false);
                                }
                            }

                            if (clientMessage.Contains("Keyboard is connected"))
                            {
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateKeyboardStatusImage(true);
                                }
                            }

                            else if (clientMessage.Contains("Keyboard is disconnected"))
                            {
                                LogKeyboardDisconnection(pcName);
                                if (pcInfoForm != null)
                                {
                                    // Update the keyboard image status on the PC info form
                                    pcInfoForm.UpdateKeyboardStatusImage(false);
                                }
                            }
                        }

                        if (admin_Mapping != null)
                        {
                            admin_Mapping.UpdatePCOnMappingPanel(pcName, clientMessage);
                            Admin_PCInfo adminPCInfoForm = Application.OpenForms.OfType<Admin_PCInfo>().FirstOrDefault(form => form.PCName == pcName);

                            if (clientMessage.Contains("Mouse is connected"))
                            {
                                if (adminPCInfoForm != null)
                                {
                                    adminPCInfoForm.UpdateMouseStatusImage(true);
                                }
                            }

                            if (clientMessage.Contains("Mouse is disconnected"))
                            {
                                LogMouseDisconnection(pcName);
                                if (adminPCInfoForm != null)
                                {
                                    adminPCInfoForm.UpdateMouseStatusImage(false);
                                }
                            }

                            if (clientMessage.Contains("Keyboard is connected"))
                            {
                                if (adminPCInfoForm != null)
                                {
                                    adminPCInfoForm.UpdateKeyboardStatusImage(true);
                                }
                            }

                            else if (clientMessage.Contains("Keyboard is disconnected"))
                            {
                                LogKeyboardDisconnection(pcName);
                                if (adminPCInfoForm != null)
                                {
                                    adminPCInfoForm.UpdateKeyboardStatusImage(false);
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

        internal void HandleClientAsync()
        {
            throw new NotImplementedException();
        }
    }
}
