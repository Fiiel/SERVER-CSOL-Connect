using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_Dashboard : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        //SuperAdmin_Dashboard
        public SuperAdmin_Dashboard()
        {
            InitializeComponent();
            OngoingLabsTrackbar_ValueChanged(this, EventArgs.Empty); // Call the event handler to load initial data
            LoadHistoryLogData();
        }

        //SuperAdmin_Dashboard_Load
        private void SuperAdmin_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM ResetPW";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int recordCount = (int)command.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            // Display the record count in the label
                            NotifCount.Text = recordCount.ToString();
                        }
                        else
                        {
                            NotifCount.Visible = false;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
            page.Show();
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm page = new LoginForm();
            page.Show();
        }

        private void PictureBox_Notification_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Notifications page = new SuperAdmin_Notifications();
            page.Show();
        }

        private void PrevSched_Click(object sender, EventArgs e)
        {
            if (OngoingLabsTrackbar.Value > OngoingLabsTrackbar.Minimum)
            {
                OngoingLabsTrackbar.Value--;
            }
            else
            {
                // Loop back to the maximum value when clicking "Previous" from the minimum value
                OngoingLabsTrackbar.Value = OngoingLabsTrackbar.Maximum;
            }
        }

        private void NextSched_Click(object sender, EventArgs e)
        {
            if (OngoingLabsTrackbar.Value < OngoingLabsTrackbar.Maximum)
            {
                OngoingLabsTrackbar.Value++;
            }
            else
            {
                // Loop back to the minimum value when clicking "Next" from the maximum value
                OngoingLabsTrackbar.Value = OngoingLabsTrackbar.Minimum;
            }
        }

        private void OngoingLabsTrackbar_ValueChanged(object sender, EventArgs e)
        {
            string currentDay = DateTime.Now.ToString("dddd");
            string currentTime = DateTime.Now.ToString("HH:mm");
            int rowCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Modify your SQL query to filter by day and time
                    string query = "SELECT * FROM Schedules WHERE [Day] = @currentDay " +
                                   "AND @currentTime >= [Sched Start] AND @currentTime <= [Sched End]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@currentDay", currentDay);
                        command.Parameters.AddWithValue("@currentTime", currentTime);

                        // Execute the query and fetch the results
                        SqlDataReader reader = command.ExecuteReader();

                        // Create a list to store the concatenated data
                        List<string> concatenatedDataList = new List<string>();

                        // Process the query results as needed
                        while (reader.Read())
                        {
                            // Access the columns of the selected rows
                            string clNumber = reader["CL Number"].ToString();
                            string gradeAndSection = reader["Grade and Section"].ToString();
                            string instructor = reader["Instructor"].ToString();

                            // Concatenate the data and add it to the list
                            string concatenatedData = $"CL {clNumber} : {gradeAndSection} : {instructor}";
                            concatenatedDataList.Add(concatenatedData);
                        }
                        reader.Close();

                        // Set the maximum value of the trackbar to the row count
                        rowCount = concatenatedDataList.Count;
                        OngoingLabsTrackbar.Maximum = rowCount - 1;

                        // Get the current value of the trackbar
                        int currentValue = OngoingLabsTrackbar.Value;

                        // Check if the current value is a valid index in your list
                        if (currentValue >= 0 && currentValue < concatenatedDataList.Count)
                        {
                            // Display the concatenated data in your label
                            OngoingLabsLabel.Text = concatenatedDataList[currentValue];
                        }
                        else
                        {
                            OngoingLabsLabel.Text = "No ongoing labs.";
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadHistoryLogData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    string query = "SELECT * FROM HistoryLog ORDER BY [Date] DESC, [Time] DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the data to the DataGridView
                        dataGridView1.DataSource = dataTable;

                        dataGridView1.Columns["IssueID"].Visible = false;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PerformHistoryLogSearch();
        }

        private void PerformHistoryLogSearch()
        {
            try
            {
                // Get the search query from the TextBox
                string searchQuery = Searchbar.Text;

                // Construct the SQL query for searching in the "HistoryLogs" table
                string query = $"SELECT * FROM HistoryLog " +
                               $"WHERE [PCName] LIKE '%{searchQuery}%' OR " +
                               $"[CLno] LIKE '%{searchQuery}%' OR " +
                               $"[Issue_Desc] LIKE '%{searchQuery}%' OR " +
                               $"[Date] LIKE '%{searchQuery}%' OR " +
                               $"[Time] LIKE '%{searchQuery}%'";

                // Execute the SQL query
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the filtered data to the DataGridView
                dataGridView1.DataSource = dataTable;
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
                PerformHistoryLogSearch();
            }
        }

        private void PictureBox_ExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                    saveFileDialog.FileName = "ExportedData.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath))
                        {
                            int columnCount = dataGridView1.Columns.Count;

                            // Write the column headers to the CSV file
                            for (int i = 0; i < columnCount; i++)
                            {
                                sw.Write(dataGridView1.Columns[i].HeaderText);
                                if (i < columnCount - 1)
                                {
                                    sw.Write(",");
                                }
                            }
                            sw.WriteLine();

                            // Write the data rows to the CSV file
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                for (int i = 0; i < columnCount; i++)
                                {
                                    if (row.Cells[i].Value != null)
                                    {
                                        sw.Write(row.Cells[i].Value.ToString());
                                    }

                                    if (i < columnCount - 1)
                                    {
                                        sw.Write(",");
                                    }
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Data exported to CSV successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
