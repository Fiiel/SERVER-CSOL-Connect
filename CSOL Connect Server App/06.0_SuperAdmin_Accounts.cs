using System.Data;
using System.Data.SqlClient;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_Accounts : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();
        private int superAdminCount;

        public SuperAdmin_Accounts()
        {
            InitializeComponent();
            superAdminCount = GetSuperAdminCount();
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm page = new LoginForm();
            page.Show();
        }

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Dashboard page = new SuperAdmin_Dashboard();
            page.Show();
        }

        private void Button_Mapping_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Mapping page = new SuperAdmin_Mapping();
            page.PreSelectElementaryCL();
            page.Show();
        }

        private void Button_Scheduler_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Scheduler page = new SuperAdmin_Scheduler();
            page.Show();
        }

        private void Button_Accounts_Click(object sender, EventArgs e)
        {

        }

        private void Button_AddUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_AddUsers addUsers = new SuperAdmin_AddUsers();
            addUsers.ShowDialog();
        }

        private void RefreshGrid()
        {
            // Get the data from the database and bind it to the DataGridView
            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
            string query = "SELECT * FROM Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        private void SuperAdmin_Accounts_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

                //EDIT AND DELETE BUTTONS

                dataGridView.Font = new Font("Arial", 13, FontStyle.Regular);

                DataGridViewImageColumn editButtonColumn = new DataGridViewImageColumn();
                editButtonColumn.Name = "Edit";
                editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                editButtonColumn.Image = Properties.Resources.edit_icon;
                dataGridView.Columns.Add(editButtonColumn);

                // Add a new column for the delete button
                DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                deleteButtonColumn.Image = Properties.Resources.delete_icon;
                dataGridView.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView.Columns["Edit"].Index)
                {
                    int rowIndex = e.RowIndex;

                    // Get the data for the selected row
                    DataGridViewRow row = dataGridView.Rows[rowIndex];
                    int Userid = (int)row.Cells["User ID"].Value;
                    string Firstname = (string)row.Cells["First Name"].Value;
                    string Lastname = (string)row.Cells["Last Name"].Value;
                    string email = (string)row.Cells["Email Address"].Value;
                    string password = (string)row.Cells["Password"].Value;
                    string Userlevel = (string)row.Cells["User Level"].Value;

                    // Open the edit form and pass the data as parameters
                    SuperAdmin_EditUsers editForm = new SuperAdmin_EditUsers(Userid, Firstname, Lastname, email, password, Userlevel);
                    this.Hide();
                    DialogResult result = editForm.ShowDialog();

                    // If the user clicked the "Save" button, update the database and refresh the grid
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                            connection.Open();

                            SqlCommand command = new SqlCommand("UPDATE Users SET [First Name] = @FirstName, [Last Name] = @LastName, [Email Address] = @Email, [Password] = @Password, [User Level] = @UserLevel WHERE [User ID] = @UserID", connection);
                            command.Parameters.AddWithValue("@UserID", editForm.UserID);
                            command.Parameters.AddWithValue("@FirstName", editForm.FirstName);
                            command.Parameters.AddWithValue("@LastName", editForm.LastName);
                            command.Parameters.AddWithValue("@Email", editForm.Email);
                            command.Parameters.AddWithValue("@Password", editForm.Pass);
                            command.Parameters.AddWithValue("@UserLevel", editForm.UserLevel);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected.");
                            }
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An Error occurred: " + ex.Message);
                        }

                        this.Hide();
                        SuperAdmin_Accounts page = new SuperAdmin_Accounts();
                        page.Show();

                    }
                }

                else if (e.ColumnIndex == dataGridView.Columns["Delete"].Index)
                {

                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];

                    // Retrieve the value of the User ID and User Level columns from the selected row
                    int userId = Convert.ToInt32(selectedRow.Cells["User ID"].Value.ToString());
                    string userLevel = selectedRow.Cells["User Level"].Value.ToString();

                    DialogResult result;

                    if (userLevel == "Super Admin")
                    {
                        result = MessageBox.Show("Are you sure you want to delete this Super Admin user?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
                    }

                    if (result == DialogResult.Yes)
                    {
                        GetSuperAdminCount();

                        if (userLevel == "Super Admin" && superAdminCount <= 1)
                        {
                            MessageBox.Show("Cannot delete the last Super Admin Account. Please make another Super Admin account before deleting this.");
                        }
                        else
                        {
                            dataGridView.Rows.RemoveAt(rowIndex);

                            try
                            {
                                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                                connection.Open();
                                SqlCommand command = new SqlCommand("DELETE FROM Users WHERE [User ID]=@UserID", connection);
                                command.Parameters.AddWithValue("@UserID", userId);
                                int rowsAffected = command.ExecuteNonQuery();
                                connection.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User Deleted Successfully.");
                                    this.Hide();
                                    SuperAdmin_Accounts page = new SuperAdmin_Accounts();
                                    page.Show();
                                }
                                else
                                {
                                    MessageBox.Show("User Deletion Failed.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            try
            {
                // Get the search query from the TextBox
                string searchQuery = Searchbar.Text;

                // Construct the SQL query
                string query = $"SELECT * FROM Users " +
                               $"WHERE [User ID] LIKE '%{searchQuery}%' OR " +
                               $"[First Name] LIKE '%{searchQuery}%' OR " +
                               $"[Last Name] LIKE '%{searchQuery}%' OR " +
                               $"[Email Address] LIKE '%{searchQuery}%' OR " +
                               $"[User Level] LIKE '%{searchQuery}%'";

                // Execute the SQL query
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the filtered data to the DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Searchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformSearch();
            }
        }

        private int GetSuperAdminCount()
        {
            int superAdminCount = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Construct the SQL query to count super admin accounts
                    string query = "SELECT COUNT(*) FROM Users WHERE [User Level] = 'Super Admin'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        superAdminCount = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as connection issues or SQL errors
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return superAdminCount;
        }
    }
}
