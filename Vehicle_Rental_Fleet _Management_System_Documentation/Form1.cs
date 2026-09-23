using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();

            this.Hide();
        }

        // If I click the Vehicles button, open the Form2Vehicles form
        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Form2Vehicles form2VehiclesForm = new Form2Vehicles();
            form2VehiclesForm.Show();

            this.Hide();
        }

        // If I click the Rentals button, open the Form3RentalManagement form
        private void btnRentals_Click(object sender, EventArgs e)
        {
            Form3RentalManagement form3RentalManagementForm = new Form3RentalManagement();
            form3RentalManagementForm.Show();

            this.Hide();
        }

        // If I click the Returns button, open the Form4ReturnManagement form
        private void btnReturns_Click(object sender, EventArgs e)
        {
            Form4ReturnManagement form4ReturnManagementForm = new Form4ReturnManagement();
            form4ReturnManagementForm.Show();

            this.Hide();
        }

        // If I click the Reports button, open the Form5Reports form
        private void btnReports_Click(object sender, EventArgs e)
        {
            Form5Reports form5ReportsForm = new Form5Reports();
            form5ReportsForm.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dgvRecentRentals_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void TestDatabaseConnection()
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();

                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Database connection successful!",
                        "Connection Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed!\n\n" + ex.Message,
                    "Connection Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}