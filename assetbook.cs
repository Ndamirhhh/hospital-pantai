using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTVISUALPROGRAMMING_TSE2473_
{
    public partial class assetbook : Form
    {
        public assetbook()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\PROJECTVISUALPROGRAMMING(TSE2473)\hospital.mdf;Integrated Security=True");

        private void lOGOUTToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            patient_doctorhomepage patientDoctorHomepageForm = new patient_doctorhomepage();
            patientDoctorHomepageForm.Show();

            // Close this form
            this.Close();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show this bookassetform
            assetbook BookAssetForm = new assetbook();
            BookAssetForm.Show();

            // Close this form
            this.Close();
        }

        private void assetbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet7.operationroom' table. You can move, or remove it, as needed.
            this.operationroomTableAdapter.Fill(this.hospitalDataSet7.operationroom);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSurgeon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOperationRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAnesthesia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnbook_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve selected values from ComboBoxes
                string operationRoom = comboBoxOperationRoom.SelectedItem?.ToString();
                DateTime bookingDate = dateTimePickerBookingDate.Value;
                string doctorName = comboBoxSurgeon.SelectedItem?.ToString();
                string anesthesia = comboBoxAnesthesia.SelectedItem?.ToString();

                // Check if any of the ComboBoxes are not selected
                if (string.IsNullOrEmpty(operationRoom) || string.IsNullOrEmpty(doctorName) || string.IsNullOrEmpty(anesthesia))
                {
                    MessageBox.Show("Please select values for operation room, doctor, and anesthesia.");
                    return;
                }

                // Construct SQL query for insertion
                string query = "INSERT INTO bookassets (room_id, book_datetime, surgeon_name, anesthesia_type) VALUES (@OperationRoom, @BookingDate, @DoctorName, @Anesthesia); SELECT SCOPE_IDENTITY();";
                string updateQuery = "UPDATE operationroom SET room_avaibility = 'booked' WHERE room_id = @OperationRoom";

                // Open the connection
                conn.Open();

                // Execute the insertion query
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OperationRoom", operationRoom);
                    cmd.Parameters.AddWithValue("@BookingDate", bookingDate);
                    cmd.Parameters.AddWithValue("@DoctorName", doctorName);
                    cmd.Parameters.AddWithValue("@Anesthesia", anesthesia);

                    int newBookId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Check if insertion was successful
                    if (newBookId > 0)
                    {
                        // Execute the update query to mark the room as booked
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@OperationRoom", operationRoom);
                            updateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Booking successfully added to the database. Book ID: " + newBookId);

                        // Clear form fields
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add booking to the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            comboBoxOperationRoom.SelectedIndex = -1;
            dateTimePickerBookingDate.Value = DateTime.Now;
            comboBoxSurgeon.SelectedIndex = -1;
            comboBoxAnesthesia.SelectedIndex = -1;
        }

        private void ClearFormFields()
        {
            comboBoxOperationRoom.SelectedIndex = -1;
            dateTimePickerBookingDate.Value = DateTime.Now;
            comboBoxSurgeon.SelectedIndex = -1;
            comboBoxAnesthesia.SelectedIndex = -1;
        }
    }
}