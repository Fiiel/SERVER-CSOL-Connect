using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Data.SqlClient;
using System.Media;
using System.Collections.Concurrent;

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

        //private Dictionary<string, bool> lanDisconnectedState = new Dictionary<string, bool>();

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

                            UpdatePCOnMappingPanel(pcName, clientMessage);
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

                            //if (clientMessage.Contains("LAN is connected"))
                            //{
                            //    // Reset LAN disconnected state when LAN is connected
                            //    lanDisconnectedState[pcName] = false;

                            //    UpdateEthernetIconInDatabase(pcName, clientMessage);
                            //    if (pcInfoForm != null)
                            //    {
                            //        pcInfoForm.UpdateEthernetStatusImage(true);
                            //    }
                            //}
                            //else if (clientMessage.Contains("LAN is disconnected"))
                            //{
                            //    if (!lanDisconnectedState.ContainsKey(pcName) || !lanDisconnectedState[pcName])
                            //    {
                            //        // Update the state to indicate that LAN is already disconnected
                            //        UpdateEthernetIconInDatabase(pcName, clientMessage);
                            //        lanDisconnectedState[pcName] = true;

                            //        // Log LAN disconnection
                            //        LogEthernetDisconnection(pcName);

                            //        if (pcInfoForm != null)
                            //        {
                            //            pcInfoForm.UpdateEthernetStatusImage(false);
                            //        }
                            //    }
                            //}
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

        Dictionary<string, bool[]> pcStates = new Dictionary<string, bool[]>();

        public void UpdatePCOnMappingPanel(string pcName, string clientMessage)
        {
            Debug.WriteLine("3rd stop");
            // Initialize the state if it doesn't exist
            if (!pcStates.ContainsKey(pcName))
            {
                Debug.WriteLine("4th stop");
                pcStates[pcName] = new bool[3]; // Assuming 2 elements for mouse and keyboard states
            }

            // Update the state based on the message
            if (clientMessage.Contains("Mouse is connected"))
            {
                pcStates[pcName][0] = true; // Mouse connected
            }
            else if (clientMessage.Contains("Mouse is disconnected"))
            {
                playDisconnectSFX();
                pcStates[pcName][0] = false; // Mouse disconnected
            }

            if (clientMessage.Contains("Keyboard is connected"))
            {
                pcStates[pcName][1] = true; // Keyboard connected
            }
            else if (clientMessage.Contains("Keyboard is disconnected"))
            {
                playDisconnectSFX();
                pcStates[pcName][1] = false; // Keyboard disconnected
            }

            //if (clientMessage.Contains("LAN is connected"))
            //{
            //    pcStates[pcName][2] = true; // LAN connected
            //}
            //else if (clientMessage.Contains("LAN is disconnected"))
            //{
            //    playDisconnectSFX();
            //    pcStates[pcName][2] = false; // LAN disconnected
            //}

            // Update the icon based on the overall state
            if (pcStates[pcName][0] && pcStates[pcName][1])
            {
                // Both mouse and keyboard are connected
                UpdateIcon(pcName, "img\\computer_green.png");
            }
            else
            {
                // Either mouse or keyboard is disconnected
                UpdateIcon(pcName, "img\\computer_red.png");
            }
        }

        private void UpdateIcon(string pcName, string imagePath)
        {
            // Search for the PC icon based on the provided PC name
            PictureBox pcIcon = superAdmin_MappingForm.pcIcons.FirstOrDefault(icon => superAdmin_MappingForm.pcLabels[superAdmin_MappingForm.pcIcons.IndexOf(icon)].Text == pcName);

            if (pcIcon != null)
            {
                pcIcon.Image = Image.FromFile(imagePath);
                UpdateDatabaseIconStatus(pcName, imagePath);
            }
        }

        private void UpdateDatabaseIconStatus(string pcName, string iconPath)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                connection.Open();

                string query = "UPDATE PCMap SET IconPath = @iconPath WHERE PCName = @name";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@iconPath", iconPath);
                command.Parameters.AddWithValue("@name", pcName);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating icon status: " + ex.Message);
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

        //private void UpdateEthernetIconInDatabase(string pcName, string clientMessage)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
        //        {
        //            connection.Open();

        //            using (SqlCommand command = new SqlCommand())
        //            {
        //                command.Connection = connection;

        //                // Determine the keyboard icon path based on the clientMessage
        //                string ethernetIconPath = "";

        //                if (clientMessage.Contains("LAN is connected"))
        //                {
        //                    ethernetIconPath = "img\\circle_green.png";
        //                }
        //                else if (clientMessage.Contains("LAN is disconnected"))
        //                {
        //                    ethernetIconPath = "img\\circle_red.png";
        //                }

        //                // Update the database with the new keyboard icon path
        //                string updateQuery = "UPDATE PCMap SET EthernetIconPath = @EthernetIconPath WHERE PCName = @PCName";

        //                command.CommandText = updateQuery;
        //                command.Parameters.AddWithValue("@EthernetIconPath", ethernetIconPath);
        //                command.Parameters.AddWithValue("@PCName", pcName);

        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine($"Error updating ethernet icon in the database: {ex.Message}");
        //    }
        //}

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

        //private void LogEthernetDisconnection(string pcName)
        //{
        //    try
        //    {
        //        // Get the CLno from the database
        //        int clno = GetCLnoFromDatabase(pcName);

        //        if (clno != -1)
        //        {
        //            string currentDateFormatted = DateTime.Now.ToString("MMM dd yyyy");
        //            string currentTimeFormatted = DateTime.Now.ToString("h:mm tt");

        //            // Create a SQL connection and insert a new row into the HistoryLog table
        //            using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
        //            {
        //                connection.Open();
        //                string query = "INSERT INTO HistoryLog (PCName, CLno, Issue_Desc, Date, Time) VALUES (@pcName, @clno, @issueDesc, @date, @time)";
        //                SqlCommand command = new SqlCommand(query, connection);

        //                command.Parameters.AddWithValue("@pcName", pcName);
        //                command.Parameters.AddWithValue("@clno", clno);
        //                command.Parameters.AddWithValue("@issueDesc", "Ethernet Cable is disconnected");
        //                command.Parameters.AddWithValue("@date", currentDateFormatted);
        //                command.Parameters.AddWithValue("@time", currentTimeFormatted); // Use the formatted time

        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Error logging ethernet disconnection: " + ex.Message);
        //    }
        //}

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

        private void playDisconnectSFX()
        {
            SoundPlayer disconnectSFX = new SoundPlayer();
            disconnectSFX.SoundLocation = "sfx\\disconnect-sfx.wav";
            disconnectSFX.Play();
        }
    }
}
