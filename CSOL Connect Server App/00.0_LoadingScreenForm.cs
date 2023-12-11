using System.Data.SqlClient;
using Timer = System.Windows.Forms.Timer;

namespace CSOL_Connect_Server_App
{
    public partial class LoadingScreenForm : Form
    {
        Server_Handler server_Handler;
        SuperAdmin_Mapping superAdmin_MappingForm;
        //Admin_Mapping admin_MappingForm;
        Timer timer;

        public LoadingScreenForm()
        {
            InitializeComponent();
            superAdmin_MappingForm = new SuperAdmin_Mapping();
            //admin_MappingForm = new Admin_Mapping();
            server_Handler = new Server_Handler(superAdmin_MappingForm);
            //server_Handler = new Server_Handler(admin_MappingForm);
            server_Handler.NetworkMain();
            StartLoading();
        }

        private void StartLoading()
        {
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
                        // Use a timer to delay showing the SuperAdmin_AddUsers form
                        timer = new Timer();
                        timer.Interval = 3000; // 5000 milliseconds = 5 seconds
                        timer.Tick += (sender, e) =>
                        {
                            timer.Stop(); // Stop the timer to prevent it from firing again
                            SuperAdmin_AddUsers superAdmin_AddUsers = new SuperAdmin_AddUsers();
                            superAdmin_AddUsers.Show();

                            // Close the loading screen
                            this.Hide();
                        };
                        timer.Start();
                    }
                    else
                    {
                        // Use a timer to delay showing the LoginForm
                        timer = new Timer();
                        timer.Interval = 3000; // 5000 milliseconds = 5 seconds
                        timer.Tick += (sender, e) =>
                        {
                            timer.Stop(); // Stop the timer to prevent it from firing again
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();

                            // Close the loading screen
                            this.Hide();
                        };
                        timer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Server Management Studio is not opened. " +  Environment.NewLine +
                "- Please quit this application, then open the SQL Server Management first" + Environment.NewLine +
                "- Then, connect to the local database, before starting the CSOL Connect Server application");
            }
        }
    }
}
