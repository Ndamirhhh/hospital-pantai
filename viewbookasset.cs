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
    public partial class viewbookasset : Form
    {
        public viewbookasset()
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

            // Close assetForm
            this.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this homepageadminform
            homepageadmin homepageAdminForm = new homepageadmin();
            homepageAdminForm.Show();

            // Close this form
            this.Close();
        }

        private void aSSETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this assetform
            asset AssetForm = new asset();
            AssetForm.Show();

            // Close this form
            this.Close();
        }

        private void bOOKASSETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this bookassetform
            viewbookasset ViewBookAssetForm = new viewbookasset();
            ViewBookAssetForm.Show();

            // Close this form
            this.Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewbookasset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet8.UserWardView' table. You can move, or remove it, as needed.
            this.userWardViewTableAdapter3.Fill(this.hospitalDataSet8.UserWardView);
            // TODO: This line of code loads data into the 'hospitalDataSet8.bookassets' table. You can move, or remove it, as needed.
            this.bookassetsTableAdapter4.Fill(this.hospitalDataSet8.bookassets);


        }

        private void dataGridBookAssetView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}