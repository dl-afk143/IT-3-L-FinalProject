
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class DriverManagementForm : Form
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        public DriverManagementForm()
        {
            InitializeComponent();

            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Click -= btnDashboard_Click;

            btnVehicles.Click += btnVehicles_Click;
            btnVehicles.Click -= btnVehicles_Click;

            btnCustomers.Click += btnCustomers_Click;
            btnCustomers.Click -= btnCustomers_Click;

            btnRentals.Click += btnRentals_Click;
            btnRentals.Click -= btnRentals_Click;

            btnReports.Click += btnReports_Click;
            btnReports.Click -= btnReports_Click;

            btnDriver.Click += btnDriver_Click;
            btnDriver.Click -= btnDriver_Click;

            button1.Click += button1_Click;
            button1.Click -= button1_Click;

            // Connect the existing Designer buttons to their actions

            btnAddDriver.Click += btnAddDriver_Click;
            btnUpdateDriver.Click += btnUpdateDriver_Click;
            btnDeactivateDriver.Click += btnDeactivateDriver_Click;
            btnClearDriver.Click += btnClearDriver_Click;

            tbSearch.TextChanged += tbSearch_TextChanged;
            dgvDriverList.SelectionChanged += dgvDriverList_SelectionChanged;

            ConfigureDriverGrid();
            LoadDrivers();
        }

        private void ConfigureDriverGrid()
        {
            // Use the columns already created in DriverManagementForm.Designer.cs.
            dgvDriverList.AutoGenerateColumns = false;

            dgvDriverList.Columns["DriverID"].DataPropertyName = "driver_id";
            dgvDriverList.Columns["FullName"].DataPropertyName = "full_name";
            dgvDriverList.Columns["ContactNumber"].DataPropertyName = "contact_number";
            dgvDriverList.Columns["LicenseNumber"].DataPropertyName = "license_no";
            dgvDriverList.Columns["LicenseExpiry"].DataPropertyName = "license_expiry";
            dgvDriverList.Columns["DriverStatus"].DataPropertyName = "status";
            dgvDriverList.Columns["CreatedAt"].DataPropertyName = "created_at";

            // Your Designer currently has a second Status column.
            if (dgvDriverList.Columns.Contains("Status"))
            {
                dgvDriverList.Columns["Status"].Visible = false;
            }
        }

        // LOAD AND SEARCH DRIVERS
        private void LoadDrivers(string searchText = "")
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            driver_id,
                            full_name,
                            contact_number,
                            license_no,
                            DATE_FORMAT(license_expiry, '%b %d, %Y') AS license_expiry,
                            status,
                            created_at
                        FROM drivers
                        WHERE full_name LIKE @search
                           OR contact_number LIKE @search
                           OR license_no LIKE @search
                        ORDER BY driver_id DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@search", "%" + searchText.Trim() + "%");

                        using (MySqlDataAdapter adapter =
                            new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dgvDriverList.DataSource = table;
                        }
                    }
                }

                dgvDriverList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load drivers.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDrivers(tbSearch.Text);
        }

        // ADD DRIVER
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (!ValidateDriverInputs())
                return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO drivers
                            (full_name, contact_number, license_no,
                             license_expiry, status)
                        VALUES
                            (@name, @contact, @license,
                             @expiry, @status);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        AddDriverParameters(cmd);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Driver added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearDriverFields();
                LoadDrivers(tbSearch.Text);
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add driver.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // UPDATE DRIVER
        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            int driverId = GetSelectedDriverId();

            if (driverId <= 0)
            {
                MessageBox.Show(
                    "Please select a driver from the list first.",
                    "Select Driver",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateDriverInputs())
                return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE drivers
                        SET full_name = @name,
                            contact_number = @contact,
                            license_no = @license,
                            license_expiry = @expiry,
                            status = @status
                        WHERE driver_id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        AddDriverParameters(cmd);
                        cmd.Parameters.AddWithValue("@id", driverId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Driver updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearDriverFields();
                LoadDrivers(tbSearch.Text);
            }
            catch (MySqlException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update driver.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // DEACTIVATE DRIVER WITHOUT DELETING THE RECORD
        private void btnDeactivateDriver_Click(object sender, EventArgs e)
        {
            int driverId = GetSelectedDriverId();

            if (driverId <= 0)
            {
                MessageBox.Show(
                    "Please select a driver to deactivate.",
                    "Select Driver",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to deactivate this driver?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        UPDATE drivers
                        SET status = 'Inactive'
                        WHERE driver_id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", driverId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Driver deactivated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearDriverFields();
                LoadDrivers(tbSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to deactivate driver.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        // CLEAR INPUTS
        private void btnClearDriver_Click(object sender, EventArgs e)
        {
            ClearDriverFields();
        }

        private void ClearDriverFields()
        {
            tbFullName.Clear();
            tbContactNumber.Clear();
            tbLicenseNumber.Clear();

            DtpLicenseExpiry.Value = DateTime.Today;

            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;

            dgvDriverList.ClearSelection();
        }

        // SELECT A DRIVER FROM THE GRID
        private void dgvDriverList_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dgvDriverList.CurrentRow == null ||
                dgvDriverList.CurrentRow.IsNewRow ||
                !dgvDriverList.CurrentRow.Selected)
            {
                return;
            }

            DataGridViewRow row = dgvDriverList.CurrentRow;

            if (row.Cells["DriverID"].Value == null ||
                row.Cells["DriverID"].Value == DBNull.Value)
            {
                return;
            }

            tbFullName.Text =
                Convert.ToString(row.Cells["FullName"].Value);

            tbContactNumber.Text =
                Convert.ToString(row.Cells["ContactNumber"].Value);

            tbLicenseNumber.Text =
                Convert.ToString(row.Cells["LicenseNumber"].Value);

            string expiry =
                Convert.ToString(row.Cells["LicenseExpiry"].Value);

            DateTime parsedDate;

            if (DateTime.TryParse(expiry, out parsedDate))
            {
                if (parsedDate < DtpLicenseExpiry.MinDate)
                    parsedDate = DtpLicenseExpiry.MinDate;

                if (parsedDate > DtpLicenseExpiry.MaxDate)
                    parsedDate = DtpLicenseExpiry.MaxDate;

                DtpLicenseExpiry.Value = parsedDate;
            }

            string status =
                Convert.ToString(row.Cells["DriverStatus"].Value);

            if (cbStatus.Items.Contains(status))
                cbStatus.SelectedItem = status;
        }

        // VALIDATION
        private bool ValidateDriverInputs()
        {
            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                MessageBox.Show(
                    "Please enter the driver's full name.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbContactNumber.Text))
            {
                MessageBox.Show(
                    "Please enter the contact number.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbContactNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbLicenseNumber.Text))
            {
                MessageBox.Show(
                    "Please enter the driver's license number.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbLicenseNumber.Focus();
                return false;
            }

            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select the driver's status.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }


        private void AddDriverParameters(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue(
                "@name", tbFullName.Text.Trim());

            cmd.Parameters.AddWithValue(
                "@contact", tbContactNumber.Text.Trim());

            cmd.Parameters.AddWithValue(
                "@license", tbLicenseNumber.Text.Trim());

            cmd.Parameters.AddWithValue(
                "@expiry", DtpLicenseExpiry.Value.Date);

            cmd.Parameters.AddWithValue(
                "@status", cbStatus.SelectedItem.ToString());
        }



        private int GetSelectedDriverId()
        {
            if (dgvDriverList.CurrentRow == null ||
                !dgvDriverList.CurrentRow.Selected)
            {
                return 0;
            }

            object value =
                dgvDriverList.CurrentRow.Cells["DriverID"].Value;

            if (value == null || value == DBNull.Value)
                return 0;

            int id;
            return int.TryParse(value.ToString(), out id) ? id : 0;
        }

        private void ShowDatabaseError(MySqlException ex)
        {
            if (ex.Number == 1062)
            {
                MessageBox.Show(
                    "This driver's license number already exists. Please use a unique license number.",
                    "Duplicate License",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "A MySQL error occurred.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // EXISTING SIDEBAR NAVIGATION
        private void btnDriver_Click(object sender, EventArgs e)
        {
            // Already on the Driver Management screen.
        }

        private void OpenForm(Form form)
        {
            if (form == null)
                return;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Size = this.Size;
            form.WindowState = this.WindowState;

            form.Show();
            this.Hide();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3RentalManagement());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerManagementForm());
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2Vehicles());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // No action needed.
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Reports());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please open Rentals Management and select an active rental before processing a return.",
                "Rental Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }
    }
}
