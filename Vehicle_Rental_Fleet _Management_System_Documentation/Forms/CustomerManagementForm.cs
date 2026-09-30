using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
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


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            string customerID = tbCustomerID.Text;
            string fullName = tbFullName.Text;
            string contactNumber = tbContactNumber.Text;
            string address = tbAddress.Text;

            // Check if fields are empty
            if (customerID == "" ||
                fullName == "" ||
                contactNumber == "" ||
                address == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Show the entered information
            MessageBox.Show(
                "Customer Added!\n\n" +
                "Customer ID: " + customerID + "\n" +
                "Full Name: " + fullName + "\n" +
                "Contact Number: " + contactNumber + "\n" +
                "Address: " + address,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Clear the fields after adding
            tbCustomerID.Clear();
            tbFullName.Clear();
            tbContactNumber.Clear();
            tbAddress.Clear();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string customerID = tbCustomerID.Text;
            string fullName = tbFullName.Text;
            string contactNumber = tbContactNumber.Text;
            string address = tbAddress.Text;

            if (customerID == "" || fullName == "" || contactNumber == "" || address == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            MessageBox.Show("Customer information is ready to update.");
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string customerID = tbCustomerID.Text;

            if (customerID == "")
            {
                MessageBox.Show("Please enter Customer ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Delete Customer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Customer is ready to be deleted.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCustomerFields();
        }

        private void ClearCustomerFields()
        {
            tbCustomerID.Clear();
            tbFullName.Clear();
            tbContactNumber.Clear();
            tbAddress.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dgvRecentRentals_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
