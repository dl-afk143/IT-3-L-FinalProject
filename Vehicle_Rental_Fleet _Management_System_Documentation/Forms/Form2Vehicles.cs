    using System;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;
    using Vehicle_Rental_Fleet__Management_System_Documentation;
    using System.Text.RegularExpressions;

namespace Vehicle_Rental_Fleet__Management_System_Documentation.Form2
    {
        public partial class Form2Vehicles : Form
        {
            private readonly DatabaseConnection db = new DatabaseConnection();

            public Form2Vehicles()
            {
                InitializeComponent();
            }

            private void btnDashboard_Click(object sender, EventArgs e)
            {
                new Form1().Show();
                this.Hide();
            }

            private void btnVehicles_Click(object sender, EventArgs e)
            {
                new Form2Vehicles().Show();
                this.Hide();
            }

            private void btnRentals_Click(object sender, EventArgs e)
            {
                new Form3RentalManagement().Show();
                this.Hide();
            }

            private void btnReturns_Click(object sender, EventArgs e)
            {
                new Form4ReturnManagement().Show();
                this.Hide();
            }

            private void btnReports_Click(object sender, EventArgs e)
            {
                new Form5Reports().Show();
                this.Hide();
            }

            private void btnAddVehicle_Click(object sender, EventArgs e)
            {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(tbPlateNumber.Text) ||
                string.IsNullOrWhiteSpace(cmbVehicleType.Text) ||
                string.IsNullOrWhiteSpace(tbBrand.Text) ||
                string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbYear.Text) ||
                string.IsNullOrWhiteSpace(tbDailyRate.Text))
            {
                MessageBox.Show(
                    "Please fill in all vehicle information.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate plate number: ABC 1234 or ABC1234
            string plateNumber = tbPlateNumber.Text.Trim();

            if (!Regex.IsMatch(plateNumber, @"^[A-Za-z]{3}\s?\d{4}$"))
            {
                MessageBox.Show(
                    "Invalid plate number. Use the format ABC 1234.",
                    "Invalid Plate Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbPlateNumber.Focus();
                return;
            }

            // Validate year model
            if (!int.TryParse(tbYear.Text.Trim(), out int yearModel))
            {
                MessageBox.Show(
                    "Year Model must be a valid number.",
                    "Invalid Year Model",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbYear.Focus();
                return;
            }

            // Validate daily rate
            if (!decimal.TryParse(
                    tbDailyRate.Text.Trim(), out decimal dailyRate)
                || dailyRate <= 0)
            {
                MessageBox.Show(
                    "Daily Rate must be a valid amount greater than zero.",
                    "Invalid Daily Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbDailyRate.Focus();
                return;
            }

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                INSERT INTO vehicles
                    (plate_number, vehicle_type, brand, model,
                     year_model, daily_rate, status)
                VALUES
                    (@plateNumber, @vehicleType, @brand, @model,
                     @yearModel, @dailyRate, @status)";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@plateNumber", plateNumber.ToUpperInvariant());

                        command.Parameters.AddWithValue(
                            "@vehicleType", cmbVehicleType.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@brand", tbBrand.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@model", tbModel.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@yearModel", yearModel);

                        command.Parameters.AddWithValue(
                            "@dailyRate", dailyRate);

                        // Automatically set new vehicles as Available
                        command.Parameters.AddWithValue(
                            "@status", "Available");

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Vehicle added successfully!",
                    "Add Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadVehicles();
                ClearFields();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "That plate number is already registered.",
                        "Duplicate Plate Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Database error:\n\n" + ex.Message,
                        "Add Vehicle Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Add Vehicle Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

            private void Form2Vehicles_Load(object sender, EventArgs e)
            {
                LoadVehicles();
            }

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

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
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
                                    Convert.ToDateTime(reader["created_at"])
                                        .ToString("yyyy-MM-dd HH:mm")
                                );
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

            private void dgvVehicle_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvVehicles.CurrentRow == null ||
            dgvVehicles.CurrentRow.IsNewRow)
                {
                    return;
                }

                DataGridViewRow row = dgvVehicles.CurrentRow;

                tbVehicleID.Text = row.Cells[0].Value?.ToString() ?? "";
                tbPlateNumber.Text = row.Cells[1].Value?.ToString() ?? "";

                cmbVehicleType.SelectedItem =
                    row.Cells[2].Value?.ToString();

                tbBrand.Text = row.Cells[3].Value?.ToString() ?? "";
                tbModel.Text = row.Cells[4].Value?.ToString() ?? "";
                tbYear.Text = row.Cells[5].Value?.ToString() ?? "";
                tbDailyRate.Text = row.Cells[6].Value?.ToString() ?? "";

                cmbStatus.SelectedItem =
                    row.Cells[7].Value?.ToString();
                tbDateCreated.Text =
                    row.Cells[8].Value?.ToString() ?? "";
        }

            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearFields();
            }

            private void ClearFields()
            {
                tbVehicleID.Clear();
                tbPlateNumber.Clear();
                tbBrand.Clear();
                tbModel.Clear();
                tbYear.Clear();
                tbDailyRate.Clear();
                tbDateCreated.Clear();

                cmbVehicleType.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;
            }

            private void btnUpdateVehicle_Click(object sender, EventArgs e)
            {
            // Check if a vehicle is selected
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

            // Validate required fields
            if (string.IsNullOrWhiteSpace(tbPlateNumber.Text) ||
                string.IsNullOrWhiteSpace(cmbVehicleType.Text) ||
                string.IsNullOrWhiteSpace(tbBrand.Text) ||
                string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbYear.Text) ||
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

            // Validate Vehicle ID
            if (!int.TryParse(tbVehicleID.Text.Trim(), out int vehicleID))
            {
                MessageBox.Show(
                    "Vehicle ID must be a valid number.",
                    "Invalid Vehicle ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Year Model
            if (!int.TryParse(tbYear.Text.Trim(), out int yearModel))
            {
                MessageBox.Show(
                    "Year Model must be a valid number.",
                    "Invalid Year Model",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                tbYear.Focus();
                return;
            }

            // Validate Daily Rate
            if (!decimal.TryParse(
                    tbDailyRate.Text.Trim(),
                    out decimal dailyRate) ||
                dailyRate <= 0)
            {
                MessageBox.Show(
                    "Daily Rate must be a valid number greater than zero.",
                    "Invalid Daily Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                tbDailyRate.Focus();
                return;
            }

            try
            {
                using (MySqlConnection connection = db.GetConnection())
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
                            tbPlateNumber.Text.Trim().ToUpperInvariant()
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

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Vehicle updated successfully!",
                                "Update Vehicle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LoadVehicles();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No vehicle was updated. Please check the Vehicle ID.",
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

                if (!int.TryParse(tbVehicleID.Text.Trim(), out int vehicleID))
                {
                    MessageBox.Show(
                        "Invalid Vehicle ID.",
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

                if (result != DialogResult.Yes)
                    return;

                try
                {
                    using (MySqlConnection connection = db.GetConnection())
                    {
                        connection.Open();

                        string query = @"
                            DELETE FROM vehicles
                            WHERE vehicle_id = @vehicleID";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue(
                                "@vehicleID",
                                vehicleID
                            );

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(
                                    "Vehicle deleted successfully!",
                                    "Delete Vehicle",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                LoadVehicles();
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

            private void grbVehicleInformation_Enter(object sender, EventArgs e)
            {
            }

        private void tbDailyRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }