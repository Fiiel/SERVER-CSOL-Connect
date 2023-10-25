using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_AddPC : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public string PCName { get; private set; }
        public bool PCAddedSuccessfully { get; private set; }
        public string SelectedComputerLaboratory { get; set; }


        public SuperAdmin_AddPC()
        {
            InitializeComponent();
        }

        private void TextBox_PC_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            foreach (Char s in TextBox_PC.Text)
            {
                if (Char.IsLetter(s) == false && Char.IsWhiteSpace(s) == false)
                {
                    a += 1;
                }
            }
        }


        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (TextBox_PC.Text.Length == 0 || clncbox.SelectedItem == null)
            {
                MessageBox.Show("Please make sure to complete the form before submitting and select an item from the ComboBox.", "Input Error");
            }
            else
            {
                try
                {
                    SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                    connection.Open();

                    string query = "INSERT INTO PCMap (PCName, CLno, XCoord, YCoord, IconPath) VALUES (@val1, @val2, @val3, @val4, @val5)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Set the parameter values
                    command.Parameters.AddWithValue("@val1", TextBox_PC.Text);
                    command.Parameters.AddWithValue("@val2", clncbox.SelectedItem.ToString()); // Get the selected item from ComboBox
                    command.Parameters.AddWithValue("@val3", 300); // Default X coordinate
                    command.Parameters.AddWithValue("@val4", 50);  // Default Y coordinate
                    command.Parameters.AddWithValue("@val5", @"img\\computer_grey.png"); // Default icon path

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Computer Created Successfully!", "Computer Creation Result");
                        this.PCName = TextBox_PC.Text;
                        
                        this.SelectedComputerLaboratory = clncbox.SelectedItem.ToString();

                        this.PCAddedSuccessfully = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Computer Creation Failed.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Computer Creation Error");
                }
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_PC.ResetText();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
