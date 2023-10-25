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
            this.Hide();
            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
            page.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fn.ResetText();
            ln.ResetText();
            email.ResetText();
            Password.ResetText();
            ConfirmPass.ResetText();
            userlevelComboBox.SelectedIndex = -1;
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
            if (fn.Text.Length == 0 || ln.Text.Length == 0 || email.Text.Length == 0 || Password.Text.Length == 0 || ConfirmPass.Text.Length == 0 || userlevelComboBox.SelectedIndex == -1)
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

                        string query = "INSERT INTO Users ([First Name], [Last Name], [Email Address], Password, [User Level]) VALUES (@val1, @val2, @val3, @val4, @val5)";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Set the parameter values
                        command.Parameters.AddWithValue("@val1", fn.Text);
                        command.Parameters.AddWithValue("@val2", ln.Text);
                        command.Parameters.AddWithValue("@val3", email.Text);
                        command.Parameters.AddWithValue("@val4", hashedPassword);
                        command.Parameters.AddWithValue("@val5", userlevelComboBox.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");

                            this.Hide();
                            SuperAdmin_Accounts page = new SuperAdmin_Accounts();
                            page.ShowDialog();
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
                    fn.ResetText();
                    ln.ResetText();
                    email.ResetText();
                    Password.ResetText();
                    ConfirmPass.ResetText();
                    userlevelComboBox.SelectedIndex = -1;
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


    }
}
