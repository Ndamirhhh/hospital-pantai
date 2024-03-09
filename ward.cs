using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PROJECTVISUALPROGRAMMING_TSE2473_
{
    public partial class ward : Form
    {
        public ward()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\PROJECTVISUALPROGRAMMING(TSE2473)\hospital.mdf;Integrated Security=True");

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Show the existing instance of Form1/login
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.Show();
            }

            // Close homepageadminForm
            this.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this form
            patient patientForm = new patient();
            patientForm.Show();

            // Close this form
            this.Close();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this ward
            ward wardForm = new ward();
            wardForm.Show();

            // Close this form
            this.Close();
        }

        private void iGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Specify the Instagram URL
            string instagramUrl = "https://www.instagram.com/pantaihospitalbatupahat/";

            // Use Process.Start to open the default web browser with the URL
            Process.Start(instagramUrl);
        }

        private void fACEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Specify the facebbok URL
            string facebookUrl = "https://www.facebook.com/pantaihospitalbatupahat/?_rdc=1&_rdr";

            // Use Process.Start to open the default web browser with the URL
            Process.Start(facebookUrl);
        }

        private void wHATSAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Specify the URL
            string url = "https://api.whatsapp.com/send?phone=+6010-668%208811&text=Please%20make%20a%20Specialist%20Appointment:%0aPatient%27s%20Full%20Name:%0aNRIC/Passport%20No.:%0aNationality:%0aAge:%0aGender:%0aPreferred%20Appointment%20Date/Time:%0aPreferred%20Doctor%20(if%20any):%0aHow%20Did%20You%20Find%20Out%20About%20Us:";

            try
            {
                // Open the URL in the default web browser
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open link: " + ex.Message);
            }
        }

        private void mAINLINEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Assuming you want to dial the phone number when the link is clicked
            string phoneNumber = "+607-433 8811";
            System.Diagnostics.Process.Start("tel:" + phoneNumber);
        }

        private void emergencyDepartmentAmbulanceServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assuming you want to dial the phone number when the link is clicked
            string phoneNumber = "+607-433 9991"; ;
            System.Diagnostics.Process.Start("tel:" + phoneNumber);
        }

        private void mAPSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gOOGLEMAPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/search?sca_esv=63f71b581b7e33af&sca_upv=1&q=Pantai+Hospital+Batu+Pahat&ludocid=6061920529835174160&lsig=AB86z5W2jXyra8Xf2Ei9bX98Ffku&sa=X&ved=2ahUKEwiipvLR88WEAxWzUWwGHfdLAkAQoAJ6BAgSEAc";

            // Open the URL in the default browser
            Process.Start(url);
        }

        private void ward_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet4.ward' table. You can move, or remove it, as needed.
            this.wardTableAdapter1.Fill(this.hospitalDataSet4.ward);
            // TODO: This line of code loads data into the 'hospitalDataSet3.ward' table. You can move, or remove it, as needed.
            this.wardTableAdapter.Fill(this.hospitalDataSet3.ward);

        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            string usernameValue = username.Text;
            string userphoneValue = userphone.Text;
            string useremailValue = useremail.Text;
            string selectedWard = comboBoxWard.SelectedItem?.ToString(); // Check if an item is selected

            try
            {
                // Open the connection
                conn.Open();

                // Generate the user_id
                string getUserIdQuery = "SELECT MAX(user_id) FROM login WHERE user_id LIKE 'BPP%'";
                SqlCommand getUserIdCommand = new SqlCommand(getUserIdQuery, conn);
                object maxUserIdObj = getUserIdCommand.ExecuteScalar();
                string maxUserId = maxUserIdObj as string;

                // Extract the numeric part and increment it
                int numericPart;
                if (maxUserId != null && maxUserId.Length >= 7 && int.TryParse(maxUserId.Substring(3), out numericPart))
                {
                    numericPart++; // Increment the numeric part

                    // Construct the new user_id
                    string newUserId = "BPP" + numericPart.ToString("0000");

                    // Insert user information into the login table
                    string insertLoginQuery = "INSERT INTO login (user_id, user_name, user_phone, user_email, user_status) VALUES (@userid, @username, @userphone, @useremail, 'PATIENT')";
                    SqlCommand insertLoginCommand = new SqlCommand(insertLoginQuery, conn);
                    insertLoginCommand.Parameters.AddWithValue("@userid", newUserId);
                    insertLoginCommand.Parameters.AddWithValue("@username", usernameValue);
                    insertLoginCommand.Parameters.AddWithValue("@userphone", userphoneValue);
                    insertLoginCommand.Parameters.AddWithValue("@useremail", useremailValue);
                    insertLoginCommand.ExecuteNonQuery();

                    if (!string.IsNullOrEmpty(selectedWard))
                    {
                        // Update the availability of the selected ward
                        string updateWardQuery = "UPDATE ward SET avaibility = avaibility - 1 WHERE ward_name = @wardName";
                        SqlCommand updateWardCommand = new SqlCommand(updateWardQuery, conn);
                        updateWardCommand.Parameters.AddWithValue("@wardName", selectedWard);
                        updateWardCommand.ExecuteNonQuery();
                    }



                    // Inform the user about the successful booking
                    MessageBox.Show("Booking successful! Your user ID is: " + newUserId);

                    // Clear input fields
                    username.Text = "";
                    userphone.Text = "";
                    useremail.Text = "";
                    comboBoxWard.SelectedIndex = -1; // Clear the selected item
                }
                else
                {
                    MessageBox.Show("Failed to generate user ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }




        private void comboBoxWard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void userphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void useremail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
