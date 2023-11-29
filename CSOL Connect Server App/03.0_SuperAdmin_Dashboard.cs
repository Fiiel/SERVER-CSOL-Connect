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
            LoadHistoryLogData();
            LoadOngoingLabsData();

            PopulatePCNamesComboBox();
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

        private void LoadOngoingLabsData()
        {
            string currentDay = DateTime.Now.ToString("dddd");
            string currentTime = DateTime.Now.ToString("HH:mm");

            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    string query = "SELECT [CL Number], [Grade and Section], [Instructor] " +
                           "FROM Schedules " +
                           "WHERE [Day] = @currentDay " +
                           "AND [Sched Start] <= @currentTime AND [Sched End] >= @currentTime";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@currentDay", currentDay);
                        command.Parameters.AddWithValue("@currentTime", currentTime);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the data to the DataGridView
                        OngoingLabsTable.DataSource = dataTable;
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

        private void PerformSearchFilter()
        {
            try
            {
                // Get the selected values from combo boxes and date time picker
                string pcNameFilter = PCName_Filter_ComboBox.SelectedItem?.ToString();
                string clFilter = CL_Filter_ComboBox.SelectedItem?.ToString();
                string selectedDate = DateTimePicker.Text;
                string timeFilter = Time_Filter_TextBox.Text;
                string deviceFilter = Device_Filter_ComboBox.SelectedItem?.ToString();

                // Construct the SQL query for searching in the "HistoryLogs" table
                string query = $"SELECT * FROM HistoryLog " +
                               $"WHERE ([PCName] LIKE '%{pcNameFilter}%' OR '{pcNameFilter}' IS NULL) AND " +
                               $"([CLno] LIKE '%{clFilter}%' OR '{clFilter}' IS NULL) AND " +
                               $"([Date] = '{selectedDate}' OR '{selectedDate}' IS NULL) AND " +
                               $"([Time] LIKE '%{timeFilter}%' OR '{timeFilter}' IS NULL) AND " +
                               $"([Issue_Desc] LIKE '%{deviceFilter}%' OR '{deviceFilter}' IS NULL)";

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

        private void Button_SearchFilter_Click(object sender, EventArgs e)
        {
            PerformSearchFilter();
        }

        private void Button_ClearFilter_Click(object sender, EventArgs e)
        {
            // Clear the text box
            Time_Filter_TextBox.Text = string.Empty;

            // Clear the combo boxes
            PCName_Filter_ComboBox.SelectedItem = null;
            CL_Filter_ComboBox.SelectedItem = null;
            Device_Filter_ComboBox.SelectedItem = null;

            LoadHistoryLogData();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            LoadHistoryLogData();
        }

        private void PopulatePCNamesComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Replace "YourTableName" with the actual table name
                    string query = "SELECT PCName FROM PCMap";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            PCName_Filter_ComboBox.Items.Clear();

                            // Populate ComboBox with PCNames
                            while (reader.Read())
                            {
                                string pcName = reader["PCName"].ToString();
                                PCName_Filter_ComboBox.Items.Add(pcName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately (e.g., show an error message)
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
