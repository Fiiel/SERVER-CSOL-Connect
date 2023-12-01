using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace CSOL_Connect_Server_App
{
    public partial class SecurityQuestions : Form
    {
        public int UserID { get; set; }
        private string sq1Ans;
        private string sq2Ans;
        private string sq3Ans;

        SQL_Connection sql_Connection = new SQL_Connection();

        public SecurityQuestions(int Userid)
        {
            InitializeComponent();
            UserID = Userid;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Verify your identity by answering your security questions. " +
                "Keep in mind that this is case sensitive. " +
                "You will be able to reset/change your password once you answer all the security questions correctly.",
                "Security Question Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
);
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm page = new LoginForm();
            page.Show();
        }

        private void SecurityQuestions_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                // Assuming "Users" is the name of your table
                command.CommandText = "SELECT SQ1, SQ2, SQ3, SQ1_ans, SQ2_ans, SQ3_ans FROM Users WHERE [User ID] = @UserID";

                // Assuming you have a parameterized query to prevent SQL injection
                command.Parameters.AddWithValue("@UserID", UserID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve values from the database and store them in variables
                    string sq1 = reader["SQ1"].ToString();
                    string sq2 = reader["SQ2"].ToString();
                    string sq3 = reader["SQ3"].ToString();
                    sq1Ans = reader["SQ1_ans"].ToString();
                    sq2Ans = reader["SQ2_ans"].ToString();
                    sq3Ans = reader["SQ3_ans"].ToString();

                    Q1_label.Text = sq1;
                    Q2_label.Text = sq2;
                    Q3_label.Text = sq3;
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception, you might want to log it or show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            // Now you can use sq1Ans, sq2Ans, and sq3Ans in your Submit button logic
            // For example, you might want to compare the user's answers with these hashed values.
            string userAnswer1 = HashInput(Q1ans_txtbox.Text);
            string userAnswer2 = HashInput(Q2ans_txtbox.Text);
            string userAnswer3 = HashInput(Q3ans_txtbox.Text);

            // Check if all answers are provided
            if (userAnswer1 == sq1Ans && userAnswer2 == sq2Ans && userAnswer3 == sq3Ans)
            {
                // Show the captcha form
                using (CaptchaForm captchaForm = new CaptchaForm())
                {
                    // Check if the captcha is entered correctly
                    if (captchaForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                            {
                                connection.Open();

                                // Change the password for the user with the specified UserID
                                string newPassword = "CSOL-connect2023!";

                                // Hash the password using SHA256
                                byte[] passwordBytes = Encoding.UTF8.GetBytes(newPassword);
                                byte[] hashedPasswordBytes;

                                using (SHA256 sha256 = SHA256.Create())
                                {
                                    hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                                }

                                string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "").ToLower();

                                // Update the hashed password in the database
                                string changePasswordQuery = "UPDATE Users SET Password = @NewPassword WHERE [User ID] = @UserID";

                                using (SqlCommand changePasswordCommand = new SqlCommand(changePasswordQuery, connection))
                                {
                                    changePasswordCommand.Parameters.AddWithValue("@NewPassword", hashedPassword);
                                    changePasswordCommand.Parameters.AddWithValue("@UserID", UserID);

                                    int rowsAffected = changePasswordCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Password has been reset to CSOL-connect2023!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to reset the password.");
                                    }
                                }

                                SqlConnection connection2 = new SqlConnection(sql_Connection.SQLConnection());
                                connection2.Open();
                                string userLevelQuery = "SELECT [User Level] FROM Users WHERE [User ID] = @UserID";
                                using (SqlCommand userLevelCommand = new SqlCommand(userLevelQuery, connection2))
                                {
                                    userLevelCommand.Parameters.AddWithValue("@UserID", UserID);
                                    string userLevel = userLevelCommand.ExecuteScalar()?.ToString();

                                    if (userLevel == "Admin")
                                    {
                                        this.Close();
                                        forAdmin_ChangePW_Required page = new forAdmin_ChangePW_Required(UserID);
                                        page.Show();
                                    }
                                    else if (userLevel == "Super Admin")
                                    {
                                        this.Close();
                                        ChangePW_Required page = new ChangePW_Required(UserID);
                                        page.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Something went wrong.");
                                    }
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
                        // Captcha not entered correctly, show a message or take appropriate action
                        MessageBox.Show("Captcha failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please answer all security questions correctly before proceeding.");
            }
        }

        private string HashInput(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);
                string hashedInput = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hashedInput;
            }
        }

        private void Button_PWReset_Click(object sender, EventArgs e)
        {


            // Confirm with the user
            DialogResult result = MessageBox.Show("Request for a Password Reset? You will have to contact the Super Admin directly before they can reset your password.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Insert the user ID into the ResetPW table
                InsertUserIDAndEmailIntoResetPW(this.UserID.ToString());
            }
        }

        private void InsertUserIDAndEmailIntoResetPW(string userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection()))
                {
                    connection.Open();

                    // Check if the [User ID] already exists in ResetPW table
                    string checkQuery = "SELECT COUNT(*) FROM ResetPW WHERE [User ID] = @UserID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", userID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            // [User ID] doesn't exist in ResetPW table, so insert it along with [Email Address]
                            string insertQuery = "INSERT INTO ResetPW ([User ID], [Email Address]) " +
                                                 "SELECT [User ID], [Email Address] FROM Users WHERE [User ID] = @UserID";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserID", userID);
                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Request Sent");
                                }
                                else
                                {
                                    MessageBox.Show("User ID not found in Users table.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("The password reset is already existing. Please contact the Super Admin directly to confirm your request.");
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
        private void SecurityQuestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            LoginForm page = new LoginForm();
            page.Show();
        }
    }
}
