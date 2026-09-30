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



namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
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
                string.IsNullOrWhiteSpace(type) ||
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

            // Year and daily rate must be numbers

            if (!int.TryParse(year.Trim(), out int yearModel))
            {
                MessageBox.Show(
                    "Year must be a valid number.",
                    "Invalid Year",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(dailyRate.Trim(), out decimal rate))
            {
                MessageBox.Show(
                    "Daily rate must be a valid number.",
                    "Invalid Daily Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Use Available if no status was chosen

            if (string.IsNullOrWhiteSpace(status))
            {
                status = "Available";
            }

            try
            {
                // Save the vehicle to the database

                DatabaseConnection db = new DatabaseConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO vehicles
                (plate_number, vehicle_type, brand, model, year_model, daily_rate, status)
                VALUES (@plate, @type, @brand, @model, @year, @rate, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@plate", plate.Trim());
                        cmd.Parameters.AddWithValue("@type", type.Trim());
                        cmd.Parameters.AddWithValue("@brand", vehicleBrand.Trim());
                        cmd.Parameters.AddWithValue("@model", vehicleModel.Trim());
                        cmd.Parameters.AddWithValue("@year", yearModel);
                        cmd.Parameters.AddWithValue("@rate", rate);
                        cmd.Parameters.AddWithValue("@status", status.Trim());

                        cmd.ExecuteNonQuery();
                    }
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
            catch (MySqlException ex)
            {
                // Duplicate plate number

                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "That plate number is already registered.",
                        "Duplicate Plate Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Database error:\n\n" + ex.Message,
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
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
            this.Close();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
        }

        private void tbVehicleBrand_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
