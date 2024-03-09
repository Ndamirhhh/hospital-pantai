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

namespace PROJECTVISUALPROGRAMMING_TSE2473_
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }

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

        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (count < 2)
                {
                    pictureBoxss.Image = imageList1.Images[count];
                    count++;
                }
                else
                {
                    count = 0;
                }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {

        }
    }
}
