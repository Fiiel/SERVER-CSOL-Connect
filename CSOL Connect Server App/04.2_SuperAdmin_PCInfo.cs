using System.Data.SqlClient;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_PCInfo : Form
    {
        private string pcName;
        private string mouseIconPath; // Separate variables for mouse and keyboard images
        private string keyboardIconPath;

        public bool PCDeletedSuccessfully { get; private set; }

        public string PCName
        {
            get { return pcName; }
            set { pcName = value; }
        }

        SQL_Connection sql_Connection = new SQL_Connection();

        public SuperAdmin_PCInfo(string pcName)
        {
            InitializeComponent();
            this.PCName = pcName; // Store the PC name for later use
            this.Text = pcName; // Set the form's title to the PC name

            //LoadLastKnownMouseImageFromDatabase();
            //LoadLastKnownKeyboardImageFromDatabase(); // Load the keyboard image separately
        }


        private void PictureBox_DeletePC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.PCName))
            {
                try
                {
                    // Delete the PC from the database using the stored PCName
                    SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                    connection.Open();

                    string query = "DELETE FROM PCMap WHERE PCName = @name";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", this.PCName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("PC Deleted Successfully!", "Delete Result");
                        this.PCDeletedSuccessfully = true; // Set the flag to indicate successful deletion
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("PC Deletion Failed.", "Delete Result");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Delete Error");
                }
            }
        }

        //private void LoadLastKnownMouseImageFromDatabase()
        //{
        //    if (!string.IsNullOrWhiteSpace(this.PCName))
        //    {
        //        try
        //        {
        //            // Retrieve the last known image path for the mouse from the database
        //            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
        //            connection.Open();

        //            string query = "SELECT MouseIconPath FROM PCMap WHERE PCName = @name";
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("@name", this.PCName);

        //            mouseIconPath = command.ExecuteScalar() as string; // Store in mouseIconPath

        //            if (!string.IsNullOrEmpty(mouseIconPath))
        //            {
        //                // Set the PictureBox_MouseRead's image to the last known image path
        //                PictureBox_MouseRead.Image = Image.FromFile(mouseIconPath);
        //            }

        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred while loading last known mouse image: " + ex.Message, "Load Error");
        //        }
        //    }
        //}

        //private void LoadLastKnownKeyboardImageFromDatabase()
        //{
        //    if (!string.IsNullOrWhiteSpace(this.PCName))
        //    {
        //        try
        //        {
        //            // Retrieve the last known image path for the keyboard from the database
        //            SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
        //            connection.Open();

        //            string query = "SELECT KeyboardIconPath FROM PCMap WHERE PCName = @name";
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("@name", this.PCName);

        //            keyboardIconPath = command.ExecuteScalar() as string; // Store in keyboardIconPath

        //            if (!string.IsNullOrEmpty(keyboardIconPath))
        //            {
        //                // Set the PictureBox_KeyboardRead's image to the last known image path
        //                PictureBox_KeyboardRead.Image = Image.FromFile(keyboardIconPath);
        //            }

        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred while loading last known keyboard image: " + ex.Message, "Load Error");
        //        }
        //    }
        //}

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
