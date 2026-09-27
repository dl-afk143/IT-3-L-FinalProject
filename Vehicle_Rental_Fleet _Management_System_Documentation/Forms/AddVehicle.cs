using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();

            this.Hide();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // kuhaon ang info sa form

            string vehicleBrand = tbVehicleBrand.Text;
            string vehicleModel = tbVehicleModel.Text;
            string type = cmbVehicleType.Text;
            string year = tbYearModel.Text;
            string plate = tbPlateNumber.Text;
            string dailyRate = tbDailyRate.Text;
            string status = cmbStatus.Text;

            // Check if required fields are empty

            if (string.IsNullOrWhiteSpace(vehicleBrand) ||
                string.IsNullOrWhiteSpace(vehicleModel) ||
                string.IsNullOrWhiteSpace(year) ||
                string.IsNullOrWhiteSpace(plate) ||
                string.IsNullOrWhiteSpace(dailyRate))
            {
                MessageBox.Show(
                    "Please fill in all the required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Confirmation

            MessageBox.Show(
                "Vehicle saved successfully!\n\n" +
                "Brand: " + vehicleBrand + "\n" +
                "Model: " + vehicleModel + "\n" +
                "Type: " + type + "\n" +
                "Year: " + year + "\n" +
                "Plate Number: " + plate + "\n" +
                "Daily Rate: " + dailyRate + "\n" +
                "Status: " + status,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear textboxes

            tbVehicleBrand.Clear();
            tbVehicleModel.Clear();
            tbYearModel.Clear();
            tbPlateNumber.Clear();
            tbDailyRate.Clear();

            // Clear ComboBoxes

            cmbVehicleType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
        }

        private void tbVehicleBrand_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
