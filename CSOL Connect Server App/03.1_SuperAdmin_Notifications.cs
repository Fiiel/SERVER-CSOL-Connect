using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_Notifications : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public SuperAdmin_Notifications()
        {
            InitializeComponent();
        }

        private void SuperAdmin_Notifications_Load(object sender, EventArgs e)
        {
            DataGridView_PasswordRequest.Font = new Font("Arial", 13, FontStyle.Regular);

            // Connection string to your database

            // SQL query to select all records from ResetPW table
            string query = "SELECT * FROM ResetPW";


            using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
            {
                // Create a SqlDataAdapter to fetch the data
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Create a DataSet to store the data
                DataSet dataSet = new DataSet();

                // Fill the DataSet with data from the ResetPW table
                adapter.Fill(dataSet, "ResetPW");

                // Bind the DataGridView to the ResetPW table in the DataSet
                DataGridView_PasswordRequest.DataSource = dataSet.Tables["ResetPW"];

                // Add a new column for the reset button
                DataGridViewImageColumn resetButtonColumn = new DataGridViewImageColumn();
                resetButtonColumn.Name = "Reset";
                resetButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                resetButtonColumn.Image = Properties.Resources.refreshSymbol; // Replace with your reset button image
                DataGridView_PasswordRequest.Columns.Add(resetButtonColumn);

                // Add a new column for the delete button
                DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                deleteButtonColumn.Image = Properties.Resources.delete_icon; // Replace with your delete button image
                DataGridView_PasswordRequest.Columns.Add(deleteButtonColumn);

                DataGridView_PasswordRequest.Columns["RequestID"].Visible = false;
            }
        }

        private void Button_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Dashboard page = new SuperAdmin_Dashboard();
            page.Show();
        }

        private void DataGridView_PasswordRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_PasswordRequest.Rows[e.RowIndex];

                if (e.ColumnIndex == DataGridView_PasswordRequest.Columns["Reset"].Index)
                {
                    // Reset button clicked
                    int userID = Convert.ToInt32(row.Cells["User ID"].Value); // Assuming "User ID" is the name of the column
                    string newPassword = "CSOL-connect2023!";

                    // Hash the password using SHA256
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(newPassword);
                    byte[] hashedPasswordBytes;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                    }
                    string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "").ToLower();

                    // Update the password of the user based on their user ID with the hashed password
                    if (UpdateUserPassword(userID, hashedPassword))
                    {
                        // Password reset successful

                        // Delete the request from the ResetPW table
                        if (DeleteRequest(Convert.ToInt32(row.Cells["RequestID"].Value))) // Delete the request from the database
                        {
                            MessageBox.Show("Password Reset Successfully to 'CSOL-connect2023!'");
                            DataGridView_PasswordRequest.Rows.RemoveAt(e.RowIndex); // Remove the row from the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Password Reset Successfully to 'CSOL-connect2023!', but failed to delete the request.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset the password.");
                    }
                }


                else if (e.ColumnIndex == DataGridView_PasswordRequest.Columns["Delete"].Index)
                {
                    // Delete button clicked
                    int requestID = Convert.ToInt32(row.Cells["RequestID"].Value); // Assuming "RequestID" is the name of the column

                    // Delete the request based on the request ID
                    if (DeleteRequest(requestID))
                    {
                        // Remove the request from the DataGridView
                        DataGridView_PasswordRequest.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the request.");
                    }
                }
            }
        }

        // Helper method to update the user's password based on their user ID
        private bool UpdateUserPassword(int userID, string newPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    string query = "UPDATE Users SET [Password] = @NewPassword WHERE [User ID] = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Password update successful
                            return true;
                        }
                        else
                        {
                            // Password update failed
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        // Helper method to delete a request based on the request ID
        private bool DeleteRequest(int requestID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    string query = "DELETE FROM ResetPW WHERE RequestID = @RequestID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestID", requestID);
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
