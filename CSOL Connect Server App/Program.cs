using System.Data.SqlClient;

namespace CSOL_Connect_Server_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SQL_Connection sql_Connection = new SQL_Connection();

            try
            {
                // Establish a database connection
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Create a SQL command to count the number of super admin users
                    string query = "SELECT COUNT(*) FROM Users WHERE [User Level] = 'Super Admin'";
                    SqlCommand command = new SqlCommand(query, connection);

                    int superAdminCount = Convert.ToInt32(command.ExecuteScalar());

                    if (superAdminCount <= 0)
                    {
                        Application.Run(new SuperAdmin_AddUsers());
                    }
                    else
                    {
                        Application.Run(new SuperAdmin_Scheduler());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with connecting to the database: " + ex.Message);
            }

        }
    }
}