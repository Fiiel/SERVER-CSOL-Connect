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
                        mappingForm.UpdatePCOnMappingPanel(pcName, clientMessage);
                    }
                }

                client.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
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
