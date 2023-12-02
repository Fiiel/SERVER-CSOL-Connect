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
    public partial class SuperAdmin_EditSchedule : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public SuperAdmin_EditSchedule()
        {
            InitializeComponent();
        }

        public int SCHEDID { get; set; }
        public string DAY { get; set; }
        public TimeSpan SCHEDSTART { get; set; }
        public TimeSpan SCHEDEND { get; set; }
        public string GRASEC { get; set; }
        public string INSTRUCT { get; set; }
        public int CLNUM { get; set; }

        public SuperAdmin_EditSchedule(int Schedid, string day, TimeSpan schedstart, TimeSpan schedend, string grns, string ins, int clno)
        {
            InitializeComponent();

            SCHEDID = Schedid;
            dayComboBox.SelectedItem = day;

            // Assign the start and end times from the data source
            TimeSpan start = schedstart;
            TimeSpan end = schedend;

            // Set the DateTimePicker controls to reflect the start and end times
            dateTimePicker1.Value = DateTime.Today.Add(start);
            dateTimePicker2.Value = DateTime.Today.Add(end);

            // Attach an event handler to the Load event
            this.Load += (sender, e) =>
            {
                // Set the selected index in the Instructor_Combobox
                int index = GraSec_Combobox.FindString(grns);
                if (index != -1)
                {
                    GraSec_Combobox.SelectedIndex = index;
                }
            };

            // Attach an event handler to the Load event
            this.Load += (sender, e) =>
            {
                // Set the selected index in the Instructor_Combobox
                int index = Instructor_Combobox.FindString(ins);
                if (index != -1)
                {
                    Instructor_Combobox.SelectedIndex = index;
                }
            };

            clncbox.Text = clno.ToString();
        }


        private void SuperAdmin_EditSchedule_Load(object sender, EventArgs e)
        {


            // Set the format and limits for dateTimePicker1
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.MinDate = DateTime.Today.AddHours(8); // Set the minimum time to 8:00 AM
            dateTimePicker1.MaxDate = DateTime.Today.AddHours(17); // Set the maximum time to 5:00 PM

            // Set the format and limits for dateTimePicker2
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.MinDate = DateTime.Today.AddHours(8); // Set the minimum time to 8:00 AM
            dateTimePicker2.MaxDate = DateTime.Today.AddHours(17); // Set the maximum time to 5:00 PM

            try
            {
                string connectionString = sql_Connection.SQLConnection();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all calss names from the "Classes" table
                    string selectQuery = "SELECT GraSec FROM Classes";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each instructor name to the ComboBox
                                GraSec_Combobox.Items.Add(reader["GraSec"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (dayComboBox.SelectedIndex == -1 || GraSec_Combobox.Text.Length == -1 || Instructor_Combobox.Text.Length == -1 || clncbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure to complete the form before submitting.");
            }
            else
            {
                // Define the start and end times for the updated schedule
                TimeSpan newScheduleStart = TimeSpan.Parse(dateTimePicker1.Text);
                TimeSpan newScheduleEnd = TimeSpan.Parse(dateTimePicker2.Text);

                // Check for overlapping schedules in the database
                if (IsScheduleOverlapping(dayComboBox.Text, newScheduleStart, newScheduleEnd, int.Parse(clncbox.Text), SCHEDID))
                {
                    MessageBox.Show("The updated schedule overlaps with an existing schedule. Please choose a different time.");
                }
                else
                {
                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to update this schedule?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());

                            connection.Open();

                            string query = "UPDATE Schedules SET [Day] = @val1, [Sched Start] = @val2, [Sched End] = @val3, " +
                                           "[Grade and Section] = @val4, [Instructor] = @val5, [CL Number] = @val6 " +
                                           "WHERE [Schedule ID] = @schedID";

                            SqlCommand command = new SqlCommand(query, connection);

                            // Set the parameter values
                            command.Parameters.AddWithValue("@val1", dayComboBox.Text);
                            command.Parameters.AddWithValue("@val2", newScheduleStart);
                            command.Parameters.AddWithValue("@val3", newScheduleEnd);
                            command.Parameters.AddWithValue("@val4", GraSec_Combobox.Text);
                            command.Parameters.AddWithValue("@val5", Instructor_Combobox.Text);
                            command.Parameters.AddWithValue("@val6", clncbox.Text);
                            command.Parameters.AddWithValue("@schedID", SCHEDID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Schedule Updated Successfully!");
                                SuperAdmin_Scheduler page = new SuperAdmin_Scheduler();
                                page.Show();
                                this.Dispose();
                                GC.Collect();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Schedule Update Failed.");
                            }
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    else
                    {
                        SuperAdmin_AddSchedule page = new SuperAdmin_AddSchedule();
                        page.Show();
                        this.Dispose();
                        GC.Collect();
                        this.Close();
                    }
                }
            }
        }

        private bool IsScheduleOverlapping(string day, TimeSpan newScheduleStart, TimeSpan newScheduleEnd, int clNumber, int schedID)
        {
            using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
            {
                connection.Open();

                // Check if there are any existing schedules on the same day that overlap with the updated schedule,
                // including CL Number in the check, but excluding the current schedule being updated
                string query = "SELECT COUNT(*) FROM Schedules WHERE [Schedule ID] != @schedID AND [Day] = @day AND " +
               "((@newStart >= [Sched Start] AND @newStart < [Sched End]) OR " +
               "(@newEnd > [Sched Start] AND @newEnd <= [Sched End]) OR " +
               "(@newStart <= [Sched Start] AND @newEnd >= [Sched End])) AND [CL Number] = @clNumber";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@schedID", schedID);
                command.Parameters.AddWithValue("@day", day);
                command.Parameters.AddWithValue("@newStart", newScheduleStart);
                command.Parameters.AddWithValue("@newEnd", newScheduleEnd);
                command.Parameters.AddWithValue("@clNumber", clNumber);

                int overlappingCount = (int)command.ExecuteScalar();

                connection.Close();

                // If there are overlapping schedules on the same day and CL Number (excluding the current schedule), return true
                if (overlappingCount > 0)
                {
                    return true;
                }

                // If no overlapping schedules were found on the same day and CL Number (excluding the current schedule), return false
                return false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if dateTimePicker2 value is earlier than dateTimePicker1
                if (dateTimePicker2.Value <= dateTimePicker1.Value)
                {
                    // Set dateTimePicker2 to match dateTimePicker1
                    dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
                }

            }
            catch
            {

                DateTime desiredTime = DateTime.Today.Date.AddHours(8); // Set to 8:00 AM today
                dateTimePicker1.Value = desiredTime;

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if dateTimePicker2 value is earlier than dateTimePicker1
                if (dateTimePicker2.Value <= dateTimePicker1.Value)
                {
                    // Set dateTimePicker2 to match dateTimePicker1
                    dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
                }
            }
            catch
            {
                DateTime desiredTime = DateTime.Today.Date.AddHours(9); // Set to 9:00 aM today
                dateTimePicker1.Value = desiredTime;
            }
        }

        private void Button_GoBack_Click(object sender, EventArgs e)
        {
            SuperAdmin_Scheduler page = new SuperAdmin_Scheduler();
            page.Show();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void SuperAdmin_EditSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back to the Scheduler", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Code to navigate back to the login form
                SuperAdmin_Scheduler loginForm = new SuperAdmin_Scheduler();
                loginForm.Show();
                this.Dispose();
                GC.Collect();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // Cancel the form closing event
                e.Cancel = true;
            }
        }
    }
}
