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
    public partial class Instructors : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public Instructors()
        {
            InitializeComponent();
        }

        private void Add_Instructor_Click(object sender, EventArgs e)
        {
            try
            {
                string instructorName = Instructor_Name.Text; // Get the instructor name from the textbox

                // Ensure the name is not empty before attempting to insert
                if (!string.IsNullOrWhiteSpace(instructorName))
                {
                    SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());

                    connection.Open();

                    // Check if the instructor already exists in the "Instructors" table
                    string checkQuery = "SELECT COUNT(*) FROM Instructors WHERE Name = @Name";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Name", instructorName);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount == 0)
                        {
                            // The instructor doesn't exist, so we can proceed with the insertion
                            string insertQuery = "INSERT INTO Instructors (Name) VALUES (@Name)";
                            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@Name", instructorName);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Instructor added successfully!");
                                    // Clear the textbox after successful insertion
                                    Instructors page = new Instructors();
                                    page.Show();
                                    this.Dispose();
                                    GC.Collect();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Insertion failed.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Instructor already exists.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an instructor name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void Instructor_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Instructors_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = sql_Connection.SQLConnection();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all instructor names from the "Instructors" table
                    string selectQuery = "SELECT Name FROM Instructors";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each instructor name to the ComboBox
                                Instructor_Combobox.Items.Add(reader["Name"].ToString());
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

        private void Delete_Instructor_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (Instructor_Combobox.SelectedIndex != -1)
            {
                try
                {
                    string selectedInstructor = Instructor_Combobox.SelectedItem.ToString();

                    string connectionString = sql_Connection.SQLConnection();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if the selected instructor is being used in the "Schedules" table
                        string checkUsageQuery = "SELECT COUNT(*) FROM Schedules WHERE Instructor = @Instructor";
                        using (SqlCommand checkUsageCmd = new SqlCommand(checkUsageQuery, connection))
                        {
                            checkUsageCmd.Parameters.AddWithValue("@Instructor", selectedInstructor);
                            int usageCount = (int)checkUsageCmd.ExecuteScalar();

                            if (usageCount > 0)
                            {
                                // The instructor is being used in schedules, so prevent deletion
                                MessageBox.Show("Cannot delete instructor because they have a schedule.");
                            }
                            else
                            {
                                // The instructor is not being used, proceed with deletion
                                string deleteQuery = "DELETE FROM Instructors WHERE Name = @Name";

                                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                                {
                                    cmd.Parameters.AddWithValue("@Name", selectedInstructor);
                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Instructor deleted successfully!");
                                        Instructor_Combobox.Items.RemoveAt(Instructor_Combobox.SelectedIndex);
                                        // Clear the ComboBox selection
                                        Instructors page = new Instructors();
                                        page.Show();
                                        this.Dispose();
                                        GC.Collect();
                                        this.Close();
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

        private void Instructors_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            GC.Collect();
            this.Close();
        }
    }
}
