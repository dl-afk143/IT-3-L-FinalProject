
using System;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dashboard statistics
            lblTotalCount.Text = "24";
            lblAvailableCount.Text = "13";
            lblMaintenanceCount.Text = "3";
            lblRentedCount.Text = "8";
            lblActiveCount.Text = "8";


            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnDriver.Click -= btnDriver_Click;
            btnDriver.Click += btnDriver_Click;

            btnVehicles.Click -= btnVehicles_Click;
            btnVehicles.Click += btnVehicles_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;

            btnCustomers.Click -= btnCustomerManagement_Click;
            btnCustomers.Click += btnCustomerManagement_Click;

            btnRentals.Click -= btnRentals_Click;
            btnRentals.Click += btnRentals_Click;

            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            // Do not modify dgvRecentRentals here.
            // Its appearance and layout remain controlled
            // by the Windows Forms Designer.
        }
        private void OpenForm(Form form)
        {
            if (form == null)
                return;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = Location;
            form.Size = Size;
            form.WindowState = WindowState;

            form.Show();
            Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2Vehicles());
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerManagementForm());
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3RentalManagement());
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            OpenForm(new DriverManagementForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Reports());
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

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4ReturnManagement());
        }
    }
}
