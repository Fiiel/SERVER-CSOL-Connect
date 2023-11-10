using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOL_Connect_Server_App
{
    public partial class GradeAndSection : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public GradeAndSection()
        {
            InitializeComponent();
        }

        private void Add_GraSec_Click(object sender, EventArgs e)
        {
            try
            {
                string GradeSection = GraSec_Name.Text; // Get the grade se name from the textbox

                // Ensure the name is not empty before attempting to insert
                if (!string.IsNullOrWhiteSpace(GradeSection))
                {
                    SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());

                    connection.Open();

                    // Check if the instructor already exists in the "Instructors" table
                    string checkQuery = "SELECT COUNT(*) FROM Classes WHERE GraSec = @Name";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", GradeSection);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount == 0)
                        {
                            // The instructor doesn't exist, so we can proceed with the insertion
                            string insertQuery = "INSERT INTO Classes (GraSec) VALUES (@Name)";
                            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@Name", GradeSection);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Class added successfully!");
                                    // Clear the textbox after successful insertion
                                    this.Hide();
                                    GradeAndSection page = new GradeAndSection();
                                    page.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Insertion failed.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Class already exists.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Grade and Section.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void GradeAndSection_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = sql_Connection.SQLConnection();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all instructor names from the "Instructors" table
                    string selectQuery = "SELECT GraSec FROM Classes";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each instructor name to the ComboBox
                                Classes_Combobox.Items.Add(reader["GraSec"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Delete_GraSec_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (Classes_Combobox.SelectedIndex != -1)
            {
                try
                {
                    string selectedGraSec = Classes_Combobox.SelectedItem.ToString();

                    string connectionString = sql_Connection.SQLConnection();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if the selected instructor is being used in the "Schedules" table
                        string checkUsageQuery = "SELECT COUNT(*) FROM Schedules WHERE [Grade and Section] = @GraSec";
                        using (SqlCommand checkUsageCmd = new SqlCommand(checkUsageQuery, connection))
                        {
                            checkUsageCmd.Parameters.AddWithValue("@GraSec", selectedGraSec);
                            int usageCount = (int)checkUsageCmd.ExecuteScalar();
                           
                            if (usageCount > 0)
                            {
                                // The class is being used in schedules, so prevent deletion
                                MessageBox.Show("Cannot delete class because they have a schedule.");
                            }
                            else
                            {
                                // The class is not being used, proceed with deletion
                                string deleteQuery = "DELETE FROM Classes WHERE GraSec = @GraSec";

                                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                                {
                                    cmd.Parameters.AddWithValue("@GraSec", selectedGraSec);
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Class deleted successfully!");
                                        Classes_Combobox.Items.RemoveAt(Classes_Combobox.SelectedIndex);
                                        // Clear the ComboBox selection
                                        this.Hide();
                                        GradeAndSection page = new GradeAndSection();
                                        page.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Deletion failed.");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an instructor to delete.");
            }
        }
    }
}

