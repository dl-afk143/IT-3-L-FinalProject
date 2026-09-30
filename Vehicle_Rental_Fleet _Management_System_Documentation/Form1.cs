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

            // NEW: style the grid and hook up the status colors
            StyleGrid(dgvRecentRentals);
            dgvRecentRentals.CellFormatting += dgvRecentRentals_CellFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // NEW: sample values (replace with database calls later)
            lblTotalCount.Text = "24";
            lblAvailableCount.Text = "13";
            lblMaintenanceCount.Text = "3";
            lblRentedCount.Text = "8";
            lblActiveCount.Text = "8";

            dgvRecentRentals.Rows.Clear();
            dgvRecentRentals.Rows.Add();
            dgvRecentRentals.Rows.Add();
            dgvRecentRentals.Rows.Add();
        }

        // NEW: grid styling
        private void StyleGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(226, 231, 239);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 38;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 58, 107);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(11, 58, 107);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            dgv.RowTemplate.Height = 34;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(20, 32, 47);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 231, 246);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 32, 47);
            dgv.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 246, 250);
        }

        // NEW: colored Status text
        private void dgvRecentRentals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (dgvRecentRentals.Columns[e.ColumnIndex].HeaderText == "Status")
            {
                switch (e.Value.ToString())
                {
                    case "Active":
                        e.CellStyle.ForeColor = Color.FromArgb(122, 79, 214);
                        e.CellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                        break;
                    case "Returned":
                        e.CellStyle.ForeColor = Color.FromArgb(31, 157, 85);
                        e.CellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                        break;
                }
            }
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

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerManagementForm = new CustomerManagementForm();
            customerManagementForm.Show();

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