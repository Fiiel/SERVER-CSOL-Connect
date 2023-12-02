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
    public partial class Admin_Scheduler : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public Admin_Scheduler()
        {
            InitializeComponent();
        }

        private void Admin_Scheduler_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                string query = "SELECT * FROM Schedules";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;

                dataGridView.Font = new Font("Arial", 13, FontStyle.Regular);

                dataGridView.Columns["Schedule ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard page = new Admin_Dashboard();
            page.Show();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Button_Mapping_Click(object sender, EventArgs e)
        {
            Admin_Mapping page = new Admin_Mapping();
            page.Show();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Button_Scheduler_Click(object sender, EventArgs e)
        {

        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            LoginForm page = new LoginForm();
            page.Show();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Searchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformSearch();
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
    }
}
