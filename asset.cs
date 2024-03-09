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
    public partial class asset : Form
    {
        public asset()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void assetnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void assetdetailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void asset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.asset' table. You can move, or remove it, as needed.
            this.assetTableAdapter.Fill(this.hospitalDataSet.asset);
            // TODO: This line of code loads data into the 'hospitalDataSet.assetcategory' table. You can move, or remove it, as needed.
            this.assetcategoryTableAdapter.Fill(this.hospitalDataSet.assetcategory);
            // Load data into the combobox
            LoadAssetCategoryComboBox();
            // Load data into the DataGridView
            LoadAssetData();
        }

        private void LoadAssetCategoryComboBox()
        {
            // Load asset categories into the ComboBox
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT cat_id, cat_type FROM assetcategory", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();

            comboBox.DisplayMember = "cat_type";
            comboBox.ValueMember = "cat_id";
            comboBox.DataSource = dt;
        }

        private void LoadAssetData()
        {
            // Load data into the DataGridView
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM asset", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            dataGridAssetView.DataSource = dt;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridAssetView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string assetName = assetnametxt.Text;
            int assetQuantity = 0;
            int.TryParse(quantitytxt.Text, out assetQuantity); // Convert quantity to int
            string assetDetail = assetdetailtxt.Text;
            string catId = comboBox.SelectedValue.ToString();
            DateTime assetDateTime = dateTimePicker1.Value;

            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO asset (asset_name, asset_quantity, asset_detail, asset_datetime, cat_id) VALUES (@assetName, @assetQuantity, @assetDetail, @assetDateTime, @catId)", conn);
            cmd.Parameters.AddWithValue("@assetName", assetName);
            cmd.Parameters.AddWithValue("@assetQuantity", assetQuantity);
            cmd.Parameters.AddWithValue("@assetDetail", assetDetail);
            cmd.Parameters.AddWithValue("@assetDateTime", assetDateTime);
            cmd.Parameters.AddWithValue("@catId", catId);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Asset added successfully.");
            LoadAssetData();
            resetbtn_Click(sender, e);
        }



        private void resetbtn_Click(object sender, EventArgs e)
        {
            assetnametxt.Clear();
            quantitytxt.Clear();
            assetdetailtxt.Clear();
            comboBox.SelectedIndex = -1; 
            dateTimePicker1.Value = DateTime.Now;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridAssetView.SelectedRows.Count > 0)
            {
                string assetId = dataGridAssetView.SelectedRows[0].Cells[0].Value.ToString(); // Assuming asset ID is in the first column
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM asset WHERE asset_id = @assetId", conn);
                cmd.Parameters.AddWithValue("@assetId", assetId);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Asset deleted successfully.");
                LoadAssetData();
            }
            else
            {
                MessageBox.Show("Please select an asset to delete.");
            }
        }

    }
}
