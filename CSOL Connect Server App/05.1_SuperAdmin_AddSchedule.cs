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
    public partial class SuperAdmin_AddSchedule : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public SuperAdmin_AddSchedule()
        {
            InitializeComponent();
        }

        private void SuperAdmin_AddSchedule_Load(object sender, EventArgs e)
        {
            // Set the format and limits for dateTimePicker1
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.MinDate = DateTime.Today.AddHours(8); // Set the minimum time to 8:00 AM
            dateTimePicker1.MaxDate = DateTime.Today.AddHours(17); // Set the maximum time to 5:00 PM
            dateTimePicker1.Value = DateTime.Today.AddHours(8); // Set the default value to 8:00 AM

            // Set the format and limits for dateTimePicker2
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.MinDate = DateTime.Today.AddHours(8); // Set the minimum time to 8:00 AM
            dateTimePicker2.MaxDate = DateTime.Today.AddHours(17); // Set the maximum time to 5:00 PM
            dateTimePicker2.Value = DateTime.Today.AddHours(8); // Set the default value to 8:00 AM
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Scheduler page = new SuperAdmin_Scheduler();
            page.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_AddSchedule page = new SuperAdmin_AddSchedule();
            page.ShowDialog();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (dayComboBox.SelectedIndex == -1 || gnstxtbox.Text.Length == 0 || instructortxt.Text.Length == 0 || clncbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure to complete the form before submitting.");
            }
            else
            {
                // Define the start and end times for the new schedule
                TimeSpan newScheduleStart = TimeSpan.Parse(dateTimePicker1.Text);
                TimeSpan newScheduleEnd = TimeSpan.Parse(dateTimePicker2.Text);

                // Check for overlapping schedules in the database
                if (IsScheduleOverlapping(dayComboBox.Text, newScheduleStart, newScheduleEnd, int.Parse(clncbox.Text)))
                {
                    MessageBox.Show("The new schedule overlaps with an existing schedule. Please choose a different time.");
                }
                else
                {
                    // Insert the new schedule into the database
                    DialogResult result = MessageBox.Show("Are you sure you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());

                            connection.Open();

                            string query = "INSERT INTO Schedules ([Day], [Sched Start], [Sched End], [Grade and Section], [Instructor], [CL Number]) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
                            SqlCommand command = new SqlCommand(query, connection);

                            // Set the parameter values
                            command.Parameters.AddWithValue("@val1", dayComboBox.Text);
                            command.Parameters.AddWithValue("@val2", newScheduleStart);
                            command.Parameters.AddWithValue("@val3", newScheduleEnd);
                            command.Parameters.AddWithValue("@val4", gnstxtbox.Text);
                            command.Parameters.AddWithValue("@val5", instructortxt.Text);
                            command.Parameters.AddWithValue("@val6", clncbox.Text);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Schedule Created Successfully!");

                                this.Hide();
                                SuperAdmin_Scheduler page = new SuperAdmin_Scheduler();
                                page.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Schedule Creation Failed.");
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
                        this.Hide();
                        SuperAdmin_AddSchedule page = new SuperAdmin_AddSchedule();
                        page.ShowDialog();
                    }
                }
            }
        }

        private bool IsScheduleOverlapping(string day, TimeSpan newScheduleStart, TimeSpan newScheduleEnd, int clNumber)
        {
            using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
            {
                connection.Open();

                // Check if there are any existing schedules on the same day that overlap with the new schedule,
                // including CL Number in the check
                string query = "SELECT COUNT(*) FROM Schedules WHERE [Day] = @day AND " +
                               "((@newStart >= [Sched Start] AND @newStart < [Sched End]) OR " +
                               "(@newEnd > [Sched Start] AND @newEnd <= [Sched End]) OR " +
                               "(@newStart <= [Sched Start] AND @newEnd >= [Sched End])) AND [CL Number] = @clNumber";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@day", day);
                command.Parameters.AddWithValue("@newStart", newScheduleStart);
                command.Parameters.AddWithValue("@newEnd", newScheduleEnd);
                command.Parameters.AddWithValue("@clNumber", clNumber);

                int overlappingCount = (int)command.ExecuteScalar();

                connection.Close();

                // If there are overlapping schedules on the same day and CL Number, return true
                if (overlappingCount > 0)
                {
                    return true;
                }

                // If no overlapping schedules were found on the same day and CL Number, return false
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

        private void schedtimer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
