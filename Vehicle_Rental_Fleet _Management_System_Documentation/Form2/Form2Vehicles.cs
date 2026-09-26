using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Fleet__Management_System_Documentation.Form2
{
    public partial class Form2Vehicles : Form
    {
        public Form2Vehicles()
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

        
        
        private void dgvRecentRentals_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {


        }

        // If I click the Add Vehicle button, open the AddVehicle form
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();

            addVehicleForm.Show();

            this.Hide();
        }

        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbVehicleID.Clear();
            tbPlateNumber.Clear();
            tbBrand.Clear();
            tbModel.Clear();
            tbYearModel.Clear();
            tbDailyRate.Clear();

            cmbVehicleType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        //update button
        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbVehicleID.Text))
            {
                MessageBox.Show(
                    "Please enter or select a Vehicle ID first.",
                    "Update Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                "Vehicle updated successfully!",
                "Update Vehicle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        //delete button
        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbVehicleID.Text))
            {
                MessageBox.Show(
                    "Please select a vehicle first.",
                    "Delete Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this vehicle?",
                "Delete Vehicle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Vehicle deleted successfully!",
                    "Delete Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear the fields after deleting
                tbVehicleID.Clear();
                tbPlateNumber.Clear();
                tbBrand.Clear();
                tbModel.Clear();
                tbYearModel.Clear();
                tbDailyRate.Clear();

                cmbVehicleType.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
            }
        }



        private void Form2Vehicles_Load(object sender, EventArgs e)
        {

        }

        private void Form2Vehicles_Load_1(object sender, EventArgs e)
        {

        }

        private void grbVehicleInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}