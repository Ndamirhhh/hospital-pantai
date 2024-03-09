using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PROJECTVISUALPROGRAMMING_TSE2473_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\PROJECTVISUALPROGRAMMING(TSE2473)\hospital.mdf;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LOGO_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtuserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userid, password;
            userid = txtuserid.Text;
            password = txtpassword.Text;

            try
            {
                string query = "SELECT * FROM [dbo].[login] WHERE user_id = '" + userid + "' AND user_password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    string userType = dtable.Rows[0]["user_id"].ToString(); // Assuming "user_id" column contains user type

                    if (userType == "BPN2212")
                    {
                        homepageadmin homepageAdminForm = new homepageadmin();
                        homepageAdminForm.Show();
                        this.Hide();
                    }
                    else if (userType == "BPD2210")
                    {
                        patient_doctorhomepage patientDoctorHomepageForm = new patient_doctorhomepage();
                        patientDoctorHomepageForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login");
                        txtuserid.Clear();
                        txtpassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login");
                    txtuserid.Clear();
                    txtpassword.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pATIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this form
            patient patientForm = new patient();
            patientForm.Show();

            Hide();
        }
    }
}
