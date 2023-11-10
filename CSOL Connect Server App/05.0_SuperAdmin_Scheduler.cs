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
    public partial class SuperAdmin_Scheduler : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public SuperAdmin_Scheduler()
        {
            InitializeComponent();
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

        }

        private void Button_Accounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
            page.Show();
        }

        private void Button_NewSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_AddSchedule page = new SuperAdmin_AddSchedule();
            page.ShowDialog();
        }

        private void RefreshGrid()
        {
            // Get the data from the database and bind it to the DataGridView
            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
            string query = "SELECT * FROM Schedules";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }


        private void SuperAdmin_Scheduler_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                string query = "SELECT * FROM Schedules";
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

                dataGridView.Columns["Schedule ID"].Visible = false;
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
                    int Schedid = (int)row.Cells["Schedule ID"].Value;
                    string day = (string)row.Cells["Day"].Value;
                    TimeSpan schedstart = (TimeSpan)row.Cells["Sched Start"].Value;
                    TimeSpan schedend = (TimeSpan)row.Cells["Sched End"].Value;
                    string grns = (string)row.Cells["Grade and Section"].Value;
                    string ins = (string)row.Cells["Instructor"].Value;
                    int clno = (int)row.Cells["CL Number"].Value;

                    // Open the edit form and pass the data as parameters
                    SuperAdmin_EditSchedule editForm = new SuperAdmin_EditSchedule(Schedid, day, schedstart, schedend, grns, ins, clno);
                    this.Hide();
                    DialogResult result = editForm.ShowDialog();

                    // If the user clicked the "Save" button, update the database and refresh the grid
                    if (result == DialogResult.OK)
                    {

                    }
                }

                else if (e.ColumnIndex == dataGridView.Columns["Delete"].Index)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];

                    // Retrieve the value of the User ID column from the selected row
                    int schedID = Convert.ToInt32(selectedRow.Cells["Schedule ID"].Value.ToString());

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        dataGridView.Rows.RemoveAt(rowIndex);

                        try
                        {
                            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                            connection.Open();
                            SqlCommand command = new SqlCommand("DELETE FROM Schedules WHERE [Schedule ID]=@SchedID", connection);
                            command.Parameters.AddWithValue("@SchedID", schedID);
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Schedule deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Schedule deletion failed.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
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
                string query = $"SELECT * FROM Schedules " +
                               $"WHERE [Day] LIKE '%{searchQuery}%' OR " +
                               $"[Sched Start] LIKE '%{searchQuery}%' OR " +
                               $"[Sched End] LIKE '%{searchQuery}%' OR " +
                               $"[Grade and Section] LIKE '%{searchQuery}%' OR " +
                               $"[Instructor] LIKE '%{searchQuery}%' OR " +
                               $"[CL Number] LIKE '%{searchQuery}%'";

                // Execute the SQL query
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the filtered data to the DataGridView
                dataGridView.DataSource = dataTable;
                dataGridView.Columns["Schedule ID"].Visible = false;
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

        private void instructorbtn_Click(object sender, EventArgs e)
        {
            Instructors page = new Instructors();
            page.Show();
        }
    }
}
