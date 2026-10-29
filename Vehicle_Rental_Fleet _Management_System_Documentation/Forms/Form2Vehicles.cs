
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vehicle_Rental_Fleet__Management_System_Documentation;

namespace Vehicle_Rental_Fleet__Management_System_Documentation.Form2
{
    public partial class Form2Vehicles : Form
    {
        private readonly DatabaseConnection db = new DatabaseConnection();
        private bool isLoading = false;

        public Form2Vehicles()
        {
            InitializeComponent();

            StyleVehicleDataGridView();

            // Ensure the form loads vehicles automatically.
            this.Load -= Form2Vehicles_Load;
            this.Load += Form2Vehicles_Load;

            // Navigation buttons
            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnVehicles.Click -= btnVehicles_Click;
            btnVehicles.Click += btnVehicles_Click;

            btnRentals.Click -= btnRentals_Click;
            btnRentals.Click += btnRentals_Click;

            btnReturns.Click -= btnReturns_Click;
            btnReturns.Click += btnReturns_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;

            btnCustomers.Click -= btnCustomers_Click;
            btnCustomers.Click += btnCustomers_Click;

            // Vehicle buttons
            btnAddVehicle.Click -= btnAddVehicle_Click;
            btnAddVehicle.Click += btnAddVehicle_Click;

            btnUpdateVehicle.Click -= btnUpdateVehicle_Click;
            btnUpdateVehicle.Click += btnUpdateVehicle_Click;

            btnDeactivateVehicle.Click -= btnDeactivateVehicle_Click;
            btnDeactivateVehicle.Click += btnDeactivateVehicle_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            dgvVehicle.SelectionChanged -= dgvVehicle_SelectionChanged;
            dgvVehicle.SelectionChanged += dgvVehicle_SelectionChanged;
        }

        // NAVIGATION
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
            Show();
            Activate();
            LoadVehicles();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3RentalManagement());
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please open Rentals Management and select an active rental before processing a return.",
                "Rental Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Reports());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerManagementForm());
        }

        // FORM LOAD
        private void Form2Vehicles_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        // ADD VEHICLE
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicle.SelectedRows.Count > 0 &&
            !string.IsNullOrWhiteSpace(tbVehicleID.Text))
            {
                MessageBox.Show(
                    "A vehicle is selected. Click Clear before adding a new vehicle, " +
                    "or use Update Vehicle to edit it.",
                    "Add Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string plate = tbPlateNumber.Text.Trim().ToUpperInvariant();
            string brand = tbVehicleBrand.Text.Trim();
            string model = tbVehicleModel.Text.Trim();
            string type = cmbVehicleType.Text.Trim();

            if (string.IsNullOrWhiteSpace(plate) ||
                string.IsNullOrWhiteSpace(brand) ||
                string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(tbYearModel.Text) ||
                string.IsNullOrWhiteSpace(tbDailyRate.Text))
            {
                MessageBox.Show(
                    "Please fill in all vehicle information.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbYearModel.Text.Trim(), out int yearModel) ||
                yearModel < 2000 ||
                yearModel > DateTime.Now.Year + 1)
            {
                MessageBox.Show(
                    "Enter a valid year between 2000 and " +
                    (DateTime.Now.Year + 1) + ".",
                    "Invalid Year",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbYearModel.Focus();
                return;
            }

            if (!TryParseRate(tbDailyRate.Text, out decimal dailyRate))
            {
                MessageBox.Show(
                    "Enter a valid daily rate greater than zero.",
                    "Invalid Daily Rate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbDailyRate.Focus();
                return;
            }

            string status = string.IsNullOrWhiteSpace(cmbStatus.Text)
                ? "Available"
                : cmbStatus.Text.Trim();

            try
            {
                long newVehicleID;

                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        INSERT INTO vehicles
                            (plate_number, vehicle_type, brand, model,
                             year_model, daily_rate, status, created_at)
                        VALUES
                            (@plate, @type, @brand, @model,
                             @year, @rate, @status, NOW());";

                    using (MySqlCommand command =
                        new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@plate", plate);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@brand", brand);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@year", yearModel);
                        command.Parameters.AddWithValue("@rate", dailyRate);
                        command.Parameters.AddWithValue("@status", status);

                        int inserted = command.ExecuteNonQuery();
                        newVehicleID = command.LastInsertedId;

                        if (inserted != 1)
                        {
                            MessageBox.Show(
                                "MySQL did not confirm that the vehicle was saved.",
                                "Insert Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Refresh the grid from MySQL after saving.
                LoadVehicles();

                // Clear the form inputs after saving.
                ClearFields();

                MessageBox.Show(
                    "Vehicle added successfully!\n\nVehicle ID: " +
                    newVehicleID,
                    "Vehicle Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                string message = "MySQL error " + ex.Number + ":\n" + ex.Message;

                if (ex.Number == 1062)
                {
                    message =
                        "This plate number is already registered.\n\n" +
                        ex.Message;
                }

                MessageBox.Show(
                    message,
                    "Database Insert Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add vehicle:\n\n" + ex.Message,
                    "Add Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // LOAD VEHICLES FROM MYSQL
        private void LoadVehicles()
        {
            isLoading = true;

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        SELECT vehicle_id, plate_number, vehicle_type,
                               brand, model, year_model, daily_rate,
                               status, created_at
                        FROM vehicles
                        ORDER BY vehicle_id ASC;";

                    using (MySqlCommand command =
                        new MySqlCommand(sql, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // This code expects nine manually configured columns.
                        if (dgvVehicle.Columns.Count != 9)
                        {
                            MessageBox.Show(
                                "The vehicle grid needs exactly 9 columns.\n\n" +
                                "Current column count: " +
                                dgvVehicle.Columns.Count + "\n\n" +
                                "Check dgvVehicle in the Designer.",
                                "Grid Configuration",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        dgvVehicle.Rows.Clear();

                        while (reader.Read())
                        {
                            int rowIndex = dgvVehicle.Rows.Add();
                            DataGridViewRow row = dgvVehicle.Rows[rowIndex];

                            row.Cells[0].Value = reader["vehicle_id"];
                            row.Cells[1].Value = reader["plate_number"];
                            row.Cells[2].Value = reader["vehicle_type"];
                            row.Cells[3].Value = reader["brand"];
                            row.Cells[4].Value = reader["model"];
                            row.Cells[5].Value = reader["year_model"];

                            row.Cells[6].Value =
                                "₱" + Convert.ToDecimal(
                                    reader["daily_rate"]).ToString("N2");

                            row.Cells[7].Value = reader["status"];

                            row.Cells[8].Value =
                                reader["created_at"] == DBNull.Value
                                ? ""
                                : Convert.ToDateTime(
                                    reader["created_at"]).ToString(
                                        "yyyy-MM-dd HH:mm");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load vehicles from MySQL.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dgvVehicle.ClearSelection();
                dgvVehicle.CurrentCell = null;
                isLoading = false;
            }
        }

        // SELECT A VEHICLE
        private void dgvVehicle_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading ||
                dgvVehicle.CurrentRow == null ||
                dgvVehicle.CurrentRow.IsNewRow)
            {
                return;
            }

            DataGridViewRow row = dgvVehicle.CurrentRow;

            tbVehicleID.Text = row.Cells[0].Value?.ToString() ?? "";
            tbPlateNumber.Text = row.Cells[1].Value?.ToString() ?? "";
            cmbVehicleType.Text = row.Cells[2].Value?.ToString() ?? "";
            tbVehicleBrand.Text = row.Cells[3].Value?.ToString() ?? "";
            tbVehicleModel.Text = row.Cells[4].Value?.ToString() ?? "";
            tbYearModel.Text = row.Cells[5].Value?.ToString() ?? "";

            tbDailyRate.Text = (row.Cells[6].Value?.ToString() ?? "")
                .Replace("₱", "")
                .Replace(",", "");

            cmbStatus.Text = row.Cells[7].Value?.ToString() ?? "";
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // CLEAR INPUT FIELDS
        private void ClearFields()
        {
            isLoading = true;

            try
            {
                tbVehicleID.Clear();
                tbPlateNumber.Clear();
                tbVehicleBrand.Clear();
                tbVehicleModel.Clear();
                tbYearModel.Clear();
                tbDailyRate.Clear();

                cmbVehicleType.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                dgvVehicle.ClearSelection();
                dgvVehicle.CurrentCell = null;
            }
            finally
            {
                isLoading = false;
            }
        }

        // PARSE DAILY RATE
        private static bool TryParseRate(string text, out decimal rate)
        {
            string cleaned = (text ?? "")
                .Replace("₱", "")
                .Replace(",", "")
                .Trim();

            return decimal.TryParse(cleaned, out rate) && rate > 0;
        }

        // UPDATE VEHICLE

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbVehicleID.Text.Trim(), out int vehicleID)
                || vehicleID <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid Vehicle ID.",
                    "Invalid Vehicle ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();


                    int activeRentalCount = 0;

                    string rentalCheckSql = @"
    SELECT COUNT(*)
    FROM rentals
    WHERE vehicle_id = @id
      AND status = 'Active';";

                    using (MySqlCommand rentalCheckCommand =
                        new MySqlCommand(rentalCheckSql, connection))
                    {
                        rentalCheckCommand.Parameters.AddWithValue("@id", vehicleID);

                        activeRentalCount = Convert.ToInt32(
                            rentalCheckCommand.ExecuteScalar());
                    }

                    if (activeRentalCount > 0)
                    {
                        MessageBox.Show(
                            "This vehicle cannot be updated because it has an active rental. " +
                            "You can update it after the trip is completed or cancelled.",
                            "Update Unavailable",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }


                    // Load the existing vehicle first.
                    string selectSql = @"
                SELECT plate_number, vehicle_type, brand, model,
                       year_model, daily_rate, status
                FROM vehicles
                WHERE vehicle_id = @id;";

                    string plate;
                    string type;
                    string brand;
                    string model;
                    int yearModel;
                    decimal dailyRate;
                    string status;

                    using (MySqlCommand selectCommand =
                        new MySqlCommand(selectSql, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@id", vehicleID);

                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "Vehicle ID " + vehicleID + " was not found.",
                                    "Vehicle Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }

                            plate = reader["plate_number"].ToString();
                            type = reader["vehicle_type"].ToString();
                            brand = reader["brand"].ToString();
                            model = reader["model"].ToString();
                            yearModel = Convert.ToInt32(reader["year_model"]);
                            dailyRate = Convert.ToDecimal(reader["daily_rate"]);
                            status = reader["status"].ToString();
                        }
                    }

                    // Replace existing values only when a field has been filled in.
                    if (!string.IsNullOrWhiteSpace(tbPlateNumber.Text))
                        plate = tbPlateNumber.Text.Trim().ToUpperInvariant();

                    if (!string.IsNullOrWhiteSpace(cmbVehicleType.Text))
                        type = cmbVehicleType.Text.Trim();

                    if (!string.IsNullOrWhiteSpace(tbVehicleBrand.Text))
                        brand = tbVehicleBrand.Text.Trim();

                    if (!string.IsNullOrWhiteSpace(tbVehicleModel.Text))
                        model = tbVehicleModel.Text.Trim();

                    if (!string.IsNullOrWhiteSpace(tbYearModel.Text))
                    {
                        if (!int.TryParse(tbYearModel.Text.Trim(), out yearModel)
                            || yearModel < 2000
                            || yearModel > DateTime.Now.Year + 1)
                        {
                            MessageBox.Show(
                                "Please enter a valid year model.",
                                "Invalid Year",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(tbDailyRate.Text))
                    {
                        if (!TryParseRate(tbDailyRate.Text, out dailyRate))
                        {
                            MessageBox.Show(
                                "Please enter a valid daily rate greater than zero.",
                                "Invalid Daily Rate",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(cmbStatus.Text))
                        status = cmbStatus.Text.Trim();

                    string updateSql = @"
                UPDATE vehicles
                SET plate_number = @plate,
                    vehicle_type = @type,
                    brand = @brand,
                    model = @model,
                    year_model = @year,
                    daily_rate = @rate,
                    status = @status
                WHERE vehicle_id = @id;";

                    using (MySqlCommand updateCommand =
                        new MySqlCommand(updateSql, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@plate", plate);
                        updateCommand.Parameters.AddWithValue("@type", type);
                        updateCommand.Parameters.AddWithValue("@brand", brand);
                        updateCommand.Parameters.AddWithValue("@model", model);
                        updateCommand.Parameters.AddWithValue("@year", yearModel);
                        updateCommand.Parameters.AddWithValue("@rate", dailyRate);
                        updateCommand.Parameters.AddWithValue("@status", status);
                        updateCommand.Parameters.AddWithValue("@id", vehicleID);

                        updateCommand.ExecuteNonQuery();
                    }
                }

                LoadVehicles();
                ClearFields();

                MessageBox.Show(
                    "Vehicle updated successfully!",
                    "Update Vehicle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update vehicle:\n\n" + ex.Message,
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // DEACTIVATE VEHICLE
        private void btnDeactivateVehicle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbVehicleID.Text.Trim(), out int vehicleID))
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Deactivate this vehicle? Its rental history will be kept.",
                "Deactivate Vehicle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string sql = @"
                        UPDATE vehicles
                        SET status='Inactive'
                        WHERE vehicle_id=@id
                          AND status <> 'Rented';";

                    using (MySqlCommand command =
                        new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", vehicleID);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            LoadVehicles();
                            ClearFields();

                            MessageBox.Show(
                                "Vehicle deactivated successfully!",
                                "Deactivate Vehicle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Vehicle was not changed. It may be rented, " +
                                "inactive, or missing.",
                                "Deactivate Vehicle",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to deactivate vehicle:\n\n" + ex.Message,
                    "Deactivate Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // DATAGRIDVIEW DESIGN
        private void StyleVehicleDataGridView()
        {
            dgvVehicle.SuspendLayout();

            dgvVehicle.BorderStyle = BorderStyle.None;
            dgvVehicle.BackgroundColor = Color.White;
            dgvVehicle.GridColor = Color.FromArgb(229, 235, 245);
            dgvVehicle.EnableHeadersVisualStyles = false;
            dgvVehicle.RowHeadersVisible = false;
            dgvVehicle.ReadOnly = true;
            dgvVehicle.AllowUserToAddRows = false;
            dgvVehicle.AllowUserToResizeRows = false;
            dgvVehicle.MultiSelect = false;
            dgvVehicle.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvVehicle.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvVehicle.ColumnHeadersHeight = 40;
            dgvVehicle.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvVehicle.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(239, 245, 252);
            dgvVehicle.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(48, 64, 91);
            dgvVehicle.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVehicle.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(239, 245, 252);
            dgvVehicle.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(48, 64, 91);
            dgvVehicle.ColumnHeadersDefaultCellStyle.Padding =
                new Padding(8, 0, 0, 0);

            dgvVehicle.DefaultCellStyle.BackColor = Color.White;
            dgvVehicle.DefaultCellStyle.ForeColor =
                Color.FromArgb(35, 51, 77);
            dgvVehicle.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);
            dgvVehicle.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(218, 232, 250);
            dgvVehicle.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 51, 77);
            dgvVehicle.DefaultCellStyle.Padding =
                new Padding(8, 4, 8, 4);

            dgvVehicle.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(230, 239, 252);
            dgvVehicle.AlternatingRowsDefaultCellStyle.ForeColor =
                Color.FromArgb(35, 51, 77);
            dgvVehicle.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(218, 232, 250);
            dgvVehicle.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 51, 77);

            dgvVehicle.RowTemplate.Height = 40;
            dgvVehicle.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicle.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;

            dgvVehicle.CellPainting -= dgvVehicles_CellPainting;
            dgvVehicle.CellPainting += dgvVehicles_CellPainting;

            dgvVehicle.ResumeLayout();
        }

        // STATUS BADGES
        private void dgvVehicles_CellPainting(
            object sender,
            DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex != 7 ||
                e.Value == null)
            {
                return;
            }

            string status = e.Value.ToString();
            Color badgeBack;
            Color badgeFore;

            switch (status.Trim().ToLowerInvariant())
            {
                case "available":
                    badgeBack = Color.FromArgb(220, 245, 230);
                    badgeFore = Color.FromArgb(27, 120, 65);
                    break;

                case "rented":
                    badgeBack = Color.FromArgb(255, 235, 210);
                    badgeFore = Color.FromArgb(155, 85, 20);
                    break;

                case "under maintenance":
                    badgeBack = Color.FromArgb(255, 243, 180);
                    badgeFore = Color.FromArgb(115, 91, 10);
                    break;

                case "inactive":
                    badgeBack = Color.FromArgb(230, 234, 241);
                    badgeFore = Color.FromArgb(75, 86, 105);
                    break;

                default:
                    return;
            }

            e.PaintBackground(e.CellBounds, true);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Font font = new Font(
                "Segoe UI", 8.5F, FontStyle.Bold))
            using (SolidBrush backBrush = new SolidBrush(badgeBack))
            using (SolidBrush foreBrush = new SolidBrush(badgeFore))
            using (StringFormat format = new StringFormat())
            {
                SizeF textSize = g.MeasureString(status, font);

                int badgeWidth = Math.Min(
                    e.CellBounds.Width - 12,
                    (int)Math.Ceiling(textSize.Width) + 20);

                if (badgeWidth <= 0)
                {
                    e.Handled = true;
                    return;
                }

                int badgeHeight = 25;

                Rectangle badge = new Rectangle(
                    e.CellBounds.X +
                        (e.CellBounds.Width - badgeWidth) / 2,
                    e.CellBounds.Y +
                        (e.CellBounds.Height - badgeHeight) / 2,
                    badgeWidth,
                    badgeHeight);

                int radius = badgeHeight / 2;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(
                        badge.X, badge.Y,
                        radius * 2, badge.Height, 90, 180);

                    path.AddArc(
                        badge.Right - radius * 2, badge.Y,
                        radius * 2, badge.Height, 270, 180);

                    path.CloseFigure();
                    g.FillPath(backBrush, path);
                }

                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString(status, font, foreBrush, badge, format);
            }

            e.Handled = true;
        }

        private void grbVehicleInformation_Enter(
            object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}   