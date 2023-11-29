using System.Data.SqlClient;


namespace CSOL_Connect_Server_App
{
    public partial class Admin_Mapping : Form
    {
        SQL_Connection sql_Connection = new SQL_Connection();
        Server_Handler server_Handler;


        public Admin_Mapping()
        {
            InitializeComponent();
            LoadPCIconsFromDatabase();
            server_Handler = new Server_Handler(this);
            server_Handler.NetworkMain();

            PreSelectElementaryCL();
        }

        //-------------------------------------------------//
        //              Code for SideNav                   //
        //-------------------------------------------------//

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard page = new Admin_Dashboard();
            page.Show();
        }

        private void Button_Mapping_Click(object sender, EventArgs e)
        {

        }

        private void Button_Scheduler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Scheduler page = new Admin_Scheduler();
            page.Show();
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm page = new LoginForm();
            page.Show();
        }


        private List<PictureBox> pcIcons = new List<PictureBox>();
        private List<System.Windows.Forms.Label> pcLabels = new List<System.Windows.Forms.Label>();

        //-------------------------------------------------//
        //           LoadPCIconsFromDatabase();            //
        //       Retrieved the last known location         // 
        //       of the added PCs                         // 
        //-------------------------------------------------//

        private void LoadPCIconsFromDatabase()
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                connection.Open();

                string query = "SELECT PCName, XCoord, YCoord, IconPath, CLno FROM PCMap";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string pcName = reader["PCName"].ToString();
                    int xCoord = Convert.ToInt32(reader["XCoord"]);
                    int yCoord = Convert.ToInt32(reader["YCoord"]);
                    string iconPath = reader["IconPath"].ToString();
                    int clno = Convert.ToInt32(reader["CLno"]); // Add this line

                    // Determine the appropriate panel based on CLno
                    Panel targetPanel;
                    switch (clno)
                    {
                        case 1:
                            targetPanel = MainPanel_ElementaryCL;
                            break;
                        case 2:
                            targetPanel = MainPanel_HighschoolCL;
                            break;
                        case 3:
                            targetPanel = MainPanel_SeniorhighCL;
                            break;
                        default:
                            // Handle any other CLno values or provide a default panel
                            targetPanel = MainPanel_ElementaryCL; // You can change this to another panel if needed
                            break;
                    }

                    // Create and position the PC Icon PictureBox and Label
                    PictureBox PC_Icon = new PictureBox();
                    PC_Icon.Image = Image.FromFile(iconPath);
                    PC_Icon.SizeMode = PictureBoxSizeMode.Normal;
                    PC_Icon.Location = new Point(xCoord, yCoord);

                    Label label = new Label();
                    label.Text = pcName;
                    label.AutoSize = true;
                    label.Location = new Point(xCoord, yCoord + PC_Icon.Height);

                    // Attach the event handlers for moving the PC Icon
                    PC_Icon.MouseDown += PC_Icon_MouseDown;
                    PC_Icon.MouseMove += PC_Icon_MouseMove;
                    PC_Icon.MouseUp += PC_Icon_MouseUp;
                    PC_Icon.MouseEnter += PC_Icon_MouseEnter;
                    PC_Icon.MouseLeave += PC_Icon_MouseLeave;

                    PC_Icon.Click += PC_Icon_Click;

                    // Add the PictureBox and Label to the determined panel
                    targetPanel.Controls.Add(PC_Icon);
                    targetPanel.Controls.Add(label);

                    // Add the PictureBox to the list of PC Icons
                    pcIcons.Add(PC_Icon);
                    pcLabels.Add(label);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading PC Icons: " + ex.Message);
            }
        }

        //-------------------------------------------------//
        //            Code for PC_Icon_Click               //
        //     Also includes Delete Icon/Refresh Panel     //
        //-------------------------------------------------//

        private bool isDragging = false; // Flag to track dragging

        private void PC_Icon_Click(object sender, EventArgs e)
        {
            // Check if the mouse has moved while clicking (indicating a drag)
            if (!isDragging)
            {
                PictureBox clickedPCIcon = (PictureBox)sender;

                // Find the index of the clicked PC Icon in the list
                int index = pcIcons.IndexOf(clickedPCIcon);

                if (index >= 0 && index < pcLabels.Count)
                {
                    string pcName = pcLabels[index].Text;

                    // Pass the PC name to the PC_Info form
                    SuperAdmin_PCInfo pcInfoForm = new SuperAdmin_PCInfo(pcName);
                    pcInfoForm.ShowDialog();

                    // Check if the PC was successfully deleted in PC_Info form
                    if (pcInfoForm.PCDeletedSuccessfully)
                    {
                        // Remove the PC Icon and Label from the Panel and lists
                        MainPanel_ElementaryCL.Controls.Remove(clickedPCIcon);
                        MainPanel_ElementaryCL.Controls.Remove(pcLabels[index]);
                        MainPanel_HighschoolCL.Controls.Remove(clickedPCIcon);
                        MainPanel_HighschoolCL.Controls.Remove(pcLabels[index]);
                        MainPanel_SeniorhighCL.Controls.Remove(clickedPCIcon);
                        MainPanel_SeniorhighCL.Controls.Remove(pcLabels[index]);
                        pcIcons.RemoveAt(index);
                        pcLabels.RemoveAt(index);
                    }
                }
            }
        }


        //-------------------------------------------------//
        //            Code for PanelIconMove               //
        //         So that when I drag the PC Icon         //
        //          It is only within the Panel            //
        //-------------------------------------------------//

        private void PC_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox PC_Icon = (PictureBox)sender;
            PC_Icon.BringToFront();
            PC_Icon.Tag = e.Location;

            PC_Icon.Capture = true;
            isDragging = false; // Reset the flag
        }

        private void PC_Icon_MouseMove(object sender, MouseEventArgs e)
        {
            isDragging = true;
            PictureBox PC_Icon = (PictureBox)sender;

            if (PC_Icon.Capture)
            {
                Point offset = (Point)PC_Icon.Tag;
                int newX = e.X + PC_Icon.Left - offset.X;
                int newY = e.Y + PC_Icon.Top - offset.Y;

                UpdateLabelPosition();

                if (newX < 0)
                    newX = 0;
                else if (newX + PC_Icon.Width > MainPanel_ElementaryCL.Width)
                    newX = MainPanel_ElementaryCL.Width - PC_Icon.Width;

                if (newY < 0)
                    newY = 0;
                else if (newY + PC_Icon.Height > MainPanel_ElementaryCL.Height)
                    newY = MainPanel_ElementaryCL.Height - PC_Icon.Height;

                PC_Icon.Left = newX;
                PC_Icon.Top = newY;

                UpdateDatabaseCoordinates(PC_Icon);
            }
        }

        private void UpdateDatabaseCoordinates(PictureBox PC_Icon)
        {
            // Get the PC Name associated with this PictureBox
            int index = pcIcons.IndexOf(PC_Icon);
            string pcName = pcLabels[index].Text;

            // Update the database with the new coordinates
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                connection.Open();

                string query = "UPDATE PCMap SET XCoord = @x, YCoord = @y WHERE PCName = @name";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@x", PC_Icon.Left);
                command.Parameters.AddWithValue("@y", PC_Icon.Top);
                command.Parameters.AddWithValue("@name", pcName);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating coordinates: " + ex.Message);
            }
        }

        private void PC_Icon_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox PC_Icon = (PictureBox)sender;
            PC_Icon.Capture = false;
            isDragging = false; // Reset the flag
        }

        private void PC_Icon_MouseEnter(object sender, EventArgs e)
        {
            PictureBox PC_Icon = (PictureBox)sender;
            PC_Icon.Cursor = Cursors.Hand;
        }

        private void PC_Icon_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PC_Icon = (PictureBox)sender;
            PC_Icon.Cursor = Cursors.Default;
        }

        private void UpdateLabelPosition()
        {
            for (int i = 0; i < pcIcons.Count; i++)
            {
                pcLabels[i].Location = new Point(pcIcons[i].Left, pcIcons[i].Bottom);
            }
        }

        //-------------------------------------------------//
        //        Code for Updating Computer Icon          //
        //-------------------------------------------------//

        Dictionary<string, bool[]> pcStates = new Dictionary<string, bool[]>();

        public void UpdatePCOnMappingPanel(string pcName, string message)
        {
            // Initialize the state if it doesn't exist
            if (!pcStates.ContainsKey(pcName))
            {
                pcStates[pcName] = new bool[2]; // Assuming 2 elements for mouse and keyboard states
            }

            // Update the state based on the message
            if (message.Contains("Mouse is connected"))
            {
                pcStates[pcName][0] = true; // Mouse connected
            }
            else if (message.Contains("Mouse is disconnected"))
            {
                pcStates[pcName][0] = false; // Mouse disconnected
            }

            if (message.Contains("Keyboard is connected"))
            {
                pcStates[pcName][1] = true; // Keyboard connected
            }
            else if (message.Contains("Keyboard is disconnected"))
            {
                pcStates[pcName][1] = false; // Keyboard disconnected
            }

            // Update the icon based on the overall state
            if (pcStates[pcName][0] && pcStates[pcName][1])
            {
                // Both mouse and keyboard are connected
                UpdateIcon(pcName, "img\\computer_green.png");
            }
            else
            {
                // Either mouse or keyboard is disconnected
                UpdateIcon(pcName, "img\\computer_red.png");
            }
        }

        private void UpdateIcon(string pcName, string imagePath)
        {
            // Search for the PC icon based on the provided PC name
            PictureBox pcIcon = pcIcons.FirstOrDefault(icon => pcLabels[pcIcons.IndexOf(icon)].Text == pcName);

            if (pcIcon != null)
            {
                pcIcon.Image = Image.FromFile(imagePath);
                UpdateDatabaseIconStatus(pcName, imagePath);
            }
        }

        private void UpdateDatabaseIconStatus(string pcName, string iconPath)
        {
            try
            {
                SqlConnection connection = new SqlConnection(sql_Connection.SQLConnection());
                connection.Open();

                string query = "UPDATE PCMap SET IconPath = @iconPath WHERE PCName = @name";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@iconPath", iconPath);
                command.Parameters.AddWithValue("@name", pcName);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating icon status: " + ex.Message);
            }
        }

        //-------------------------------------------------//
        //          Code for Computer Lab Buttons          //
        //-------------------------------------------------//

        private void PictureBox_ElementaryCL_Click(object sender, EventArgs e)
        {
            MainPanel_ElementaryCL.Visible = true;
            MainPanel_HighschoolCL.Visible = false;
            MainPanel_SeniorhighCL.Visible = false;

            PictureBox_ElementaryCL.BackColor = Color.FromArgb(252, 207, 15);
            PictureBox_HighschoolCL.BackColor = SystemColors.Control;
            PictureBox_SeniorhighCL.BackColor = SystemColors.Control;
        }

        private void PictureBox_HighschoolCL_Click(object sender, EventArgs e)
        {
            MainPanel_ElementaryCL.Visible = false;
            MainPanel_HighschoolCL.Visible = true;
            MainPanel_SeniorhighCL.Visible = false;

            PictureBox_HighschoolCL.BackColor = Color.FromArgb(252, 207, 15);
            PictureBox_ElementaryCL.BackColor = SystemColors.Control;
            PictureBox_SeniorhighCL.BackColor = SystemColors.Control;
        }

        private void PictureBox_SeniorhighCL_Click(object sender, EventArgs e)
        {
            MainPanel_ElementaryCL.Visible = false;
            MainPanel_HighschoolCL.Visible = false;
            MainPanel_SeniorhighCL.Visible = true;

            PictureBox_SeniorhighCL.BackColor = Color.FromArgb(251, 207, 15);
            PictureBox_ElementaryCL.BackColor = SystemColors.Control;
            PictureBox_HighschoolCL.BackColor = SystemColors.Control;
        }

        public void PreSelectElementaryCL()
        {
            MainPanel_ElementaryCL.Visible = true;
            MainPanel_HighschoolCL.Visible = false;
            MainPanel_SeniorhighCL.Visible = false;

            PictureBox_ElementaryCL.BackColor = Color.FromArgb(252, 207, 15);
            PictureBox_HighschoolCL.BackColor = SystemColors.Control;
            PictureBox_SeniorhighCL.BackColor = SystemColors.Control;
        }
    }
}
