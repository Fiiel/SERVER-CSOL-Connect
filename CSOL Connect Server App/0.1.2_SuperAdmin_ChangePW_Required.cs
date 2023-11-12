using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CSOL_Connect_Server_App
{
    public partial class ChangePW_Required : Form
    {
        public int userID { get; set; }

        SQL_Connection sql_Connection = new SQL_Connection();

        public ChangePW_Required(int UserID)
        {
            InitializeComponent();
            userID = UserID;
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

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Password.Text.Length <= 0 || ConfirmPass.Text.Length <= 0)
            {
                MessageBox.Show("Please fill up all the fields before submitting.");
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
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to make this your password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                        {
                            connection.Open();

                            // Hash the password using SHA256
                            byte[] passwordBytes = Encoding.UTF8.GetBytes(Password.Text);
                            byte[] hashedPasswordBytes = SHA256.HashData(passwordBytes);
                            string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "").ToLower();

                            // Update the password for the specified user ID
                            SqlCommand command = new SqlCommand("UPDATE Users SET [Password] = @hashedPassword WHERE [User ID] = @UserID", connection);
                            command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                            command.Parameters.AddWithValue("@UserID", userID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully.");
                                this.Hide();
                                SuperAdmin_Dashboard page = new SuperAdmin_Dashboard();
                                page.Show();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the password.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password update canceled.");
                    Password.ResetText();
                    ConfirmPass.ResetText();
                }
            }
        }


    }
}
