using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_EditUsers : Form
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string UserLevel { get; set; }

        //OBJECT
        SQL_Connection sql_Connection = new SQL_Connection();


        public SuperAdmin_EditUsers(int Userid, string FirstName, string LastName, string Email, string password, string UserLevel)
        {
            InitializeComponent();

            UserID = Userid;
            fn.Text = FirstName;
            ln.Text = LastName;
            email.Text = Email;
            userlevelComboBox.SelectedItem = UserLevel;
        }

        private void SuperAdmin_EditUsers_Load(object sender, EventArgs e)
        {
            if (userlevelComboBox.Text == "Super Admin")
            {
                if (IsLastSuperAdmin())
                {
                    userlevelComboBox.Enabled = false;
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (fn.Text.Length == 0 || ln.Text.Length == 0 || email.Text.Length == 0 || Pword.Text.Length == 0 || ConfirmPass.Text.Length == 0 || userlevelComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure to complete the form before submitting.");
            }
            else if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                email.ResetText();
            }
            else if (pwReq1.ForeColor == Color.Red || pwReq2.ForeColor == Color.Red || pwReq3.ForeColor == Color.Red || pwReq4.ForeColor == Color.Red || pwReq5.ForeColor == Color.Red)
            {
                MessageBox.Show("Please ensure that your password meets all the necessary requirements.");
                Pword.ResetText();
                ConfirmPass.ResetText();
            }
            else if (Pword.Text != ConfirmPass.Text)
            {
                MessageBox.Show("Password doesn't match.");
                Pword.ResetText();
                ConfirmPass.ResetText();
            }

            else if (EmailExists(email.Text, UserID))
            {
                MessageBox.Show("An account with this email address already exists.");
                email.ResetText();
            }

            else
            {
                //Get new values
                FirstName = fn.Text;
                LastName = ln.Text;
                Email = email.Text;

                // Encrypt the password using SHA-256
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Pword.Text));
                    Pass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                }

                UserLevel = userlevelComboBox.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void fn_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            foreach (Char s in fn.Text)
            {
                if (Char.IsLetter(s) == false && Char.IsWhiteSpace(s) == false)
                {
                    a += 1;
                }
            }
            if (a > 0)
            {
                MessageBox.Show("Please only input letters in this field.");
                fn.ResetText();
            }
        }

        private void ln_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            foreach (Char s in ln.Text)
            {
                if (Char.IsLetter(s) == false && Char.IsWhiteSpace(s) == false)
                {
                    a += 1;
                }
            }
            if (a > 0)
            {
                MessageBox.Show("Please only input letters in this field.");
                ln.ResetText();
            }
        }

        //ENTROPY CHECKER FUNCTION
        private double CalculateEntropy(string password)
        {
            // Count the number of possible characters in the password
            int characterSetSize = 0;
            if (Regex.IsMatch(password, "[a-z]"))
            {
                characterSetSize += 26;
            }
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                characterSetSize += 26;
            }
            if (Regex.IsMatch(password, "[0-9]"))
            {
                characterSetSize += 10;
            }
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                characterSetSize += 32; // Assuming 32 special characters
            }

            // Calculate the entropy using the formula
            double entropy = Math.Log(Math.Pow(characterSetSize, password.Length), 2);

            return entropy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //PW Requirement 1
            if (Pword.Text.Length >= 12)
            {
                pwReq1.ForeColor = Color.Green;
            }
            else
            {
                pwReq1.ForeColor = Color.Red;
            }
            //PW Requirement 2
            int a = 0, b = 0;
            foreach (Char s in Pword.Text)
            {
                if (Char.IsUpper(s) == true)
                {
                    a += 1;
                }
                if (Char.IsLower(s) == true)
                {
                    b += 1;
                }
            }

            if ((a > 0) && (b > 0))
            {
                pwReq2.ForeColor = Color.Green;
            }
            else
            {
                pwReq2.ForeColor = Color.Red;
            }
            //PW Requirement 3
            int c = 0;
            foreach (Char s in Pword.Text)
            {
                if ((Char.IsDigit(s) == true))
                {
                    c += 1;
                }
            }

            if (c > 0)
            {
                pwReq3.ForeColor = Color.Green;
            }
            else
            {
                pwReq3.ForeColor = Color.Red;
            }
            //PW Requirement 4
            int d = 0;
            foreach (Char s in Pword.Text)
            {
                if ((Char.IsSymbol(s) == true) || (Char.IsPunctuation(s)))
                {
                    d += 1;
                }
            }

            if (d > 0)
            {
                pwReq4.ForeColor = Color.Green;
            }
            else
            {
                pwReq4.ForeColor = Color.Red;
            }

            //PW Requirement 5
            double entropy = CalculateEntropy(Pword.Text);
            if (entropy >= 64)
            {
                pwReq5.ForeColor = Color.Green;
            }
            else
            {
                pwReq5.ForeColor = Color.Red;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Pword.PasswordChar == '●')
            {
                Pword.PasswordChar = '\0';
            }
            else if (Pword.PasswordChar == '\0')
            {
                Pword.PasswordChar = '●';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ConfirmPass.PasswordChar == '●')
            {
                ConfirmPass.PasswordChar = '\0';
            }
            else if (ConfirmPass.PasswordChar == '\0')
            {
                ConfirmPass.PasswordChar = '●';
            }
        }

        private bool EmailExists(string emailAddress, int currentUserId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Convert the input email address to lowercase (or uppercase)
                    emailAddress = emailAddress.ToLower(); // or emailAddress.ToUpper() if you prefer uppercase

                    // Check if the email address already exists in the database (case-insensitive) but not for the current user
                    string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE LOWER([Email Address]) = @email AND [User ID] != @currentUserId";
                    using (SqlCommand checkEmailCommand = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@email", emailAddress);
                        checkEmailCommand.Parameters.AddWithValue("@currentUserId", currentUserId);
                        int emailCount = (int)checkEmailCommand.ExecuteScalar();

                        return emailCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Handle the exception appropriately for your application
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
            page.ShowDialog();
        }

        private bool IsLastSuperAdmin()
        {
            // Establish a database connection
            using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
            {
                connection.Open();

                // Create a SQL command to count the number of super admin users
                string query = "SELECT COUNT(*) FROM Users WHERE [User Level] = @UserLevel";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserLevel", "Super Admin");

                int superAdminCount = Convert.ToInt32(command.ExecuteScalar());

                // If there's only one super admin, return true
                return superAdminCount == 1;
            }
        }
    }
}
