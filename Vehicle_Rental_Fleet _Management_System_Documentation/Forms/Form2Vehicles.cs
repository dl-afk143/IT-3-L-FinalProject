using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using Vehicle_Rental_Fleet__Management_System_Documentation;

namespace Vehicle_Rental_Fleet__Management_System_Documentation.Form2
{
    public partial class Form2Vehicles : Form
    {
        // Database connection
        private DatabaseConnection db = new DatabaseConnection();


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public Form2Vehicles()
        {
            InitializeComponent();
        }


        // =========================================================
        // DASHBOARD BUTTON
        // =========================================================

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();

            this.Hide();
        }


        // =========================================================
        // VEHICLES BUTTON
        // =========================================================

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Form2Vehicles form2VehiclesForm = new Form2Vehicles();
            form2VehiclesForm.Show();

            this.Hide();
        }


        // =========================================================
        // RENTALS BUTTON
        // =========================================================

        private void btnRentals_Click(object sender, EventArgs e)
        {
            Form3RentalManagement form3RentalManagementForm =
                new Form3RentalManagement();

            form3RentalManagementForm.Show();

            this.Hide();
        }


        // =========================================================
        // RETURNS BUTTON
        // =========================================================

        private void btnReturns_Click(object sender, EventArgs e)
        {
            Form4ReturnManagement form4ReturnManagementForm =
                new Form4ReturnManagement();

            form4ReturnManagementForm.Show();

            this.Hide();
        }


        // =========================================================
        // REPORTS BUTTON
        // =========================================================

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form5Reports form5ReportsForm =
                new Form5Reports();

            form5ReportsForm.Show();

            this.Hide();
        }


        // =========================================================
        // ADD VEHICLE BUTTON
        // =========================================================

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicleForm = new AddVehicle();

            addVehicleForm.Show();

            this.Hide();
        }


        // =========================================================
        // FORM LOAD
        // =========================================================

        private void Form2Vehicles_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }


        // This is included because your Designer may be connected
        // to Form2Vehicles_Load_1 instead of Form2Vehicles_Load.
        private void Form2Vehicles_Load_1(object sender, EventArgs e)
        {
            LoadVehicles();
        }


        // =========================================================
        // LOAD VEHICLES FROM DATABASE
        // =========================================================

        private void LoadVehicles()
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            vehicle_id,
                            plate_number,
                            vehicle_type,
                            brand,
                            model,
                            year_model,
                            daily_rate,
                            status,
                            created_at
                        FROM vehicles
                        ORDER BY vehicle_id ASC";


                    using (MySqlCommand command =
                        new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader =
                            command.ExecuteReader())
                        {
                            // Remove existing rows
                            dgvVehicles.Rows.Clear();

                            while (reader.Read())
                            {
                                dgvVehicles.Rows.Add(
                                    reader["vehicle_id"].ToString(),
                                    reader["plate_number"].ToString(),
                                    reader["vehicle_type"].ToString(),
                                    reader["brand"].ToString(),
                                    reader["model"].ToString(),
                                    reader["year_model"].ToString(),
                                    reader["daily_rate"].ToString(),
                                    reader["status"].ToString(),
                                    Convert.ToDateTime(
                                        reader["created_at"]
                                    ).ToString("yyyy-MM-dd HH:mm")
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load vehicles.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // VEHICLE LIST - CLICK ROW
        // =========================================================

        private void dgvRecentRentals_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvVehicles.Rows[e.RowIndex];

            // Ignore the empty "new row"
            if (row.IsNewRow)
                return;


            try
            {
                // Column 0 = Vehicle ID
                tbVehicleID.Text =
                    row.Cells[0].Value?.ToString() ?? "";


                // Column 1 = Plate Number
                tbPlateNumber.Text =
                    row.Cells[1].Value?.ToString() ?? "";


                // Column 2 = Vehicle Type
                cmbVehicleType.Text =
                    row.Cells[2].Value?.ToString() ?? "";


                // Column 3 = Brand
                tbBrand.Text =
                    row.Cells[3].Value?.ToString() ?? "";


                // Column 4 = Model
                tbModel.Text =
                    row.Cells[4].Value?.ToString() ?? "";


                // Column 5 = Year Model
                tbYearModel.Text =
                    row.Cells[5].Value?.ToString() ?? "";


                // Column 6 = Daily Rate
                tbDailyRate.Text =
                    row.Cells[6].Value?.ToString() ?? "";


                // Column 7 = Status
                cmbStatus.Text =
                    row.Cells[7].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to select vehicle.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // CLEAR BUTTON
        // =========================================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        // =========================================================
        // CLEAR FIELDS METHOD
        // =========================================================

        private void ClearFields()
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


        // =========================================================
        // UPDATE VEHICLE
        // =========================================================

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            // Check Vehicle ID
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(tbVehicleID.Text))
            {
                MessageBox.Show(
                    "Please select a vehicle first.",
                    "Update Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // -----------------------------------------------------
            // Check required fields
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(tbPlateNumber.Text) ||
                string.IsNullOrWhiteSpace(cmbVehicleType.Text) ||
                string.IsNullOrWhiteSpace(tbBrand.Text) ||
                string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbYearModel.Text) ||
                string.IsNullOrWhiteSpace(tbDailyRate.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show(
                    "Please fill in all vehicle information.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // -----------------------------------------------------
            // Validate Vehicle ID
            // -----------------------------------------------------

            if (!int.TryParse(
                tbVehicleID.Text.Trim(),
                out int vehicleID))
            {
                MessageBox.Show(
                    "Vehicle ID must be a valid number.",
                    "Invalid Vehicle ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // -----------------------------------------------------
            // Validate Year Model
            // -----------------------------------------------------

            if (!int.TryParse(
                tbYearModel.Text.Trim(),
                out int yearModel))
            {
                MessageBox.Show(
                    "Year Model must be a valid number.",
                    "Invalid Year Model",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // -----------------------------------------------------
            // Validate Daily Rate
            // -----------------------------------------------------

            if (!decimal.TryParse(
                tbDailyRate.Text.Trim(),
                out decimal dailyRate))
            {
                MessageBox.Show(
                    "Daily Rate must be a valid number.",
                    "Invalid Daily Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            try
            {
                using (MySqlConnection connection =
                    db.GetConnection())
                {
                    connection.Open();


                    string query = @"
                        UPDATE vehicles
                        SET
                            plate_number = @plateNumber,
                            vehicle_type = @vehicleType,
                            brand = @brand,
                            model = @model,
                            year_model = @yearModel,
                            daily_rate = @dailyRate,
                            status = @status
                        WHERE vehicle_id = @vehicleID";


                    using (MySqlCommand command =
                        new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@plateNumber",
                            tbPlateNumber.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@vehicleType",
                            cmbVehicleType.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@brand",
                            tbBrand.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@model",
                            tbModel.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@yearModel",
                            yearModel
                        );

                        command.Parameters.AddWithValue(
                            "@dailyRate",
                            dailyRate
                        );

                        command.Parameters.AddWithValue(
                            "@status",
                            cmbStatus.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@vehicleID",
                            vehicleID
                        );


                        int rowsAffected =
                            command.ExecuteNonQuery();


                        // -------------------------------------------------
                        // Update successful
                        // -------------------------------------------------

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Vehicle updated successfully!",
                                "Update Vehicle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // Refresh vehicle list
                            LoadVehicles();

                            // Clear fields
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Vehicle ID was not found.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
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
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // DELETE VEHICLE
        // =========================================================

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------
            // Check Vehicle ID
            // -----------------------------------------------------

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


            // -----------------------------------------------------
            // Validate Vehicle ID
            // -----------------------------------------------------

            if (!int.TryParse(
                tbVehicleID.Text.Trim(),
                out int vehicleID))
            {
                MessageBox.Show(
                    "Invalid Vehicle ID.",
                    "Delete Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // -----------------------------------------------------
            // Confirmation
            // -----------------------------------------------------

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this vehicle?",
                "Delete Vehicle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (result != DialogResult.Yes)
            {
                return;
            }


            try
            {
                using (MySqlConnection connection =
                    db.GetConnection())
                {
                    connection.Open();


                    string query = @"
                        DELETE FROM vehicles
                        WHERE vehicle_id = @vehicleID";


                    using (MySqlCommand command =
                        new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@vehicleID",
                            vehicleID
                        );


                        int rowsAffected =
                            command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Vehicle deleted successfully!",
                                "Delete Vehicle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );


                            // Refresh list
                            LoadVehicles();


                            // Clear form
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Vehicle ID was not found.",
                                "Delete Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Foreign key constraint
                if (ex.Number == 1451)
                {
                    MessageBox.Show(
                        "This vehicle cannot be deleted because it is already associated with a rental record.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Database error:\n\n" + ex.Message,
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Delete Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // GROUP BOX EVENT
        // =========================================================

        private void grbVehicleInformation_Enter(
            object sender,
            EventArgs e)
        {
        }
    }
}
