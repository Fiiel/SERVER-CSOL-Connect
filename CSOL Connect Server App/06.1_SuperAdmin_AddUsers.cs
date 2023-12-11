using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOL_Connect_Server_App
{
    public partial class SuperAdmin_AddUsers : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();

        public SuperAdmin_AddUsers()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
            page.ShowDialog();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SuperAdmin_AddUsers page = new SuperAdmin_AddUsers();
            page.ShowDialog();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void pwReq1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //PW Requirement 1
            if (Password.Text.Length >= 12)
            {
                pwReq1.ForeColor = Color.Green;
            }
            else
            {
                pwReq1.ForeColor = Color.Red;
            }
            //PW Requirement 2
            int a = 0, b = 0;
            foreach (Char s in Password.Text)
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
            foreach (Char s in Password.Text)
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
            foreach (Char s in Password.Text)
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
            double entropy = CalculateEntropy(Password.Text);
            if (entropy >= 64)
            {
                pwReq5.ForeColor = Color.Green;
            }
            else
            {
                pwReq5.ForeColor = Color.Red;
            }
        }

        private void PWtooltip_Popup(object sender, PopupEventArgs e)
        {

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

        private void nameTimer_Tick(object sender, EventArgs e)
        {

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



        private void Submit_Click(object sender, EventArgs e)
        {
            if (fn.Text.Length == 0 || ln.Text.Length == 0 || email.Text.Length == 0 || Password.Text.Length == 0 || ConfirmPass.Text.Length == 0 || userlevelComboBox.SelectedIndex == -1 || Q1_txtbox.TextLength == 0 || Q1ans_txtbox.TextLength == 0 || Q2_txtbox.TextLength == 0 || Q2ans_txtbox.TextLength == 0 || Q3_txtbox.TextLength == 0 || Q3ans_txtbox.TextLength == 0)
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
                Password.ResetText();
                ConfirmPass.ResetText();
            }
            else if (Password.Text != ConfirmPass.Text)
            {
                MessageBox.Show("Password doesn't match.");
                Password.ResetText();
                ConfirmPass.ResetText();
            }
            else if (Password.Text == "CSOL-connect2023!")
            {
                MessageBox.Show("Password can't be set to defaut password. Please choose a differennt password.");
                Password.ResetText();
                ConfirmPass.ResetText();
            }
            else if (EmailExists(email.Text))
            {
                MessageBox.Show("An account with this email address already exists.");
                email.ResetText();
            }

            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                        connection.Open();

                        // Hash the password using SHA256
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(Password.Text);
                        byte[] hashedPasswordBytes = SHA256.HashData(passwordBytes);
                        string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "").ToLower();

                        // Hash the Q1_ans using SHA256
                        byte[] Q1ansBytes = Encoding.UTF8.GetBytes(Q1ans_txtbox.Text);
                        byte[] hashedQ1ansBytes = SHA256.HashData(Q1ansBytes);
                        string hashedQ1ans = BitConverter.ToString(hashedQ1ansBytes).Replace("-", "").ToLower();

                        // Hash the Q2_ans using SHA256
                        byte[] Q2ansBytes = Encoding.UTF8.GetBytes(Q2ans_txtbox.Text);
                        byte[] hashedQ2ansBytes = SHA256.HashData(Q2ansBytes);
                        string hashedQ2ans = BitConverter.ToString(hashedQ2ansBytes).Replace("-", "").ToLower();

                        // Hash the Q3_ans using SHA256
                        byte[] Q3ansBytes = Encoding.UTF8.GetBytes(Q3ans_txtbox.Text);
                        byte[] hashedQ3ansBytes = SHA256.HashData(Q3ansBytes);
                        string hashedQ3ans = BitConverter.ToString(hashedQ3ansBytes).Replace("-", "").ToLower();


                        string query = "INSERT INTO Users ([First Name], [Last Name], [Email Address], Password, [User Level], SQ1, SQ2, SQ3, SQ1_ans, SQ2_ans, SQ3_ans) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11)";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Set the parameter values
                        command.Parameters.AddWithValue("@val1", fn.Text);
                        command.Parameters.AddWithValue("@val2", ln.Text);
                        command.Parameters.AddWithValue("@val3", email.Text);
                        command.Parameters.AddWithValue("@val4", hashedPassword);
                        command.Parameters.AddWithValue("@val5", userlevelComboBox.Text);
                        command.Parameters.AddWithValue("@val6", Q1_txtbox.Text);
                        command.Parameters.AddWithValue("@val7", Q2_txtbox.Text);
                        command.Parameters.AddWithValue("@val8", Q3_txtbox.Text);
                        command.Parameters.AddWithValue("@val9", hashedQ1ans);
                        command.Parameters.AddWithValue("@val10", hashedQ2ans);
                        command.Parameters.AddWithValue("@val11", hashedQ3ans);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");

                            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
                            page.ShowDialog();
                            this.Dispose();
                            GC.Collect();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Account Creation Failed.");
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
                    SuperAdmin_AddUsers page = new SuperAdmin_AddUsers();
                    page.ShowDialog();
                    this.Dispose();
                    GC.Collect();
                    this.Close();
                }
            }
        }

        private void pwReq4_Click(object sender, EventArgs e)
        {

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

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUsers_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                connection.Open();

                // Create a SQL command to count the number of super admin users
                string query = "SELECT COUNT(*) FROM Users WHERE [User Level] = 'Super Admin'";
                SqlCommand command = new SqlCommand(query, connection);

                int superAdminCount = Convert.ToInt32(command.ExecuteScalar());

                if (superAdminCount <= 0)
                {
                    userlevelComboBox.SelectedIndex = 1;
                    userlevelComboBox.Enabled = false;

                    BackButton.Visible = false;
                    BackButton.Enabled = false;

                    this.Text = "CSOL Connect - Root Account Set up";
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log, show an error message, etc.)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '●')
            {
                Password.PasswordChar = '\0';
            }
            else if (Password.PasswordChar == '\0')
            {
                Password.PasswordChar = '●';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private bool EmailExists(string emailAddress)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Convert the input email address to lowercase (or uppercase)
                    emailAddress = emailAddress.ToLower(); // or emailAddress.ToUpper() if you prefer uppercase

                    // Check if the email address already exists in the database (case-insensitive)
                    string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE LOWER([Email Address]) = @email";
                    using (SqlCommand checkEmailCommand = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCommand.Parameters.AddWithValue("@email", emailAddress);
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

        private void help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These security questions would be asked if you forget your password. Set them up carefully, this is case sensitive and make sure that the questions you provide are not easily attainable data.");
        }

        private void Q1_txtbox_TextChanged(object sender, EventArgs e)
        {
            Q1ans_txtbox.ResetText();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseDown_1(object sender, MouseEventArgs e)
        {
            Q1ans_txtbox.PasswordChar = '\0';
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Q1ans_txtbox.PasswordChar = '●';
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Q2ans_txtbox.PasswordChar = '\0';
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Q2ans_txtbox.PasswordChar = '●';
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            Q3ans_txtbox.PasswordChar = '\0';
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            Q3ans_txtbox.PasswordChar = '●';
        }

        private void Q2_txtbox_TextChanged(object sender, EventArgs e)
        {
            Q2ans_txtbox.ResetText();
        }

        private void Q3_txtbox_TextChanged(object sender, EventArgs e)
        {
            Q3ans_txtbox.ResetText();
        }

        private void SuperAdmin_AddUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Handle user closing the form
                Application.Exit();
            }
        }
    }
}
