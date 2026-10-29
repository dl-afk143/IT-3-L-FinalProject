using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class Form3RentalManagement : Form
    {
        // ====== CHANGE THESE IF YOUR TABLE/COLUMN NAMES ARE DIFFERENT ======
        // vehicles  : vehicle_id, plate_number, brand, model, vehicle_type, daily_rate, status
        // customers : customer_id, full_name, license_no, status
        // rentals   : rental_id, customer_id, vehicle_id, rental_date, expected_return,
        //             total_amount, amount_paid (NEW - run the ALTER TABLE below), status
        //
        // Run this once in MySQL before using Create Rental:
        //   ALTER TABLE rentals ADD COLUMN amount_paid DECIMAL(10,2) NOT NULL DEFAULT 0;
        // ====================================================================

        private readonly DatabaseConnection db = new DatabaseConnection();
        private readonly CultureInfo peso = new CultureInfo("en-PH");

        private int selectedVehicleId = 0;
        private decimal selectedDailyRate = 0;
        private bool loading = false;

        public Form3RentalManagement()
        {
            InitializeComponent();

            button3.Click -= button3_Click;
            button3.Click += button3_Click;

            button4.Click -= button4_Click;
            button4.Click += button4_Click;

            button6.Click -= button6_Click;
            button6.Click += button6_Click;


            button1.Click -= button1_Click;
            button1.Click += button1_Click;
            
            btnDriver.Click -= btnDriver_Click;
            btnDriver.Click += btnDriver_Click;
            
            button5.Click -= button5_Click;
            button5.Click += button5_Click;

            button7.Click -= button7_Click;
            button7.Click += button7_Click;


        }

        // =================== FORM LOAD ===================
        private void Form3RentalManagement_Load(object sender, EventArgs e)
        {
            loading = true;

            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker2.Format = DateTimePickerFormat.Long;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(1);

            SetupAvailableGrid();
            SetupRentalGrid();
            LoadVehicleTypes();
            LoadCustomers();

            // events
            dateTimePicker1.ValueChanged += DatesChanged;
            dateTimePicker2.ValueChanged += DatesChanged;
            cbVehicleType.SelectedIndexChanged += FilterChanged;
            tbMaxDailyRate.TextChanged += FilterChanged;
            tbMaxDailyRate.KeyPress += NumberOnly_KeyPress;
            tbAmountPaid.KeyPress += NumberOnly_KeyPress;
            tbAmountPaid.TextChanged += (s, ev) => UpdateBalance();
            dgvAvailableVehicles.SelectionChanged += dgvAvailableVehicles_SelectionChanged;
            btnCreateRental.Click += btnCreateRental_Click;
            btnClear.Click += btnClear_Click;

            loading = false;

            ResetSummary();
            LoadAvailableVehicles();
            LoadRentals();
        }

        // =================== GRID SETUP ===================
        private void SetupAvailableGrid()
        {
            dgvAvailableVehicles.AutoGenerateColumns = false;
            dgvAvailableVehicles.Columns.Clear();
            dgvAvailableVehicles.AllowUserToAddRows = false;
            dgvAvailableVehicles.ReadOnly = true;
            dgvAvailableVehicles.MultiSelect = false;
            dgvAvailableVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableVehicles.RowHeadersVisible = false;

            dgvAvailableVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "vehicle_id", DataPropertyName = "vehicle_id", Visible = false });
            dgvAvailableVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "Plate", HeaderText = "Plate", DataPropertyName = "plate_number" });
            dgvAvailableVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "Type", HeaderText = "Type", DataPropertyName = "vehicle_type" });
            dgvAvailableVehicles.Columns.Add(new DataGridViewTextBoxColumn { Name = "Vehicle", HeaderText = "Vehicle", DataPropertyName = "vehicle_name" });
            var rate = new DataGridViewTextBoxColumn { Name = "DailyRate", HeaderText = "DailyRate", DataPropertyName = "daily_rate" };
            rate.DefaultCellStyle.Format = "N2";
            dgvAvailableVehicles.Columns.Add(rate);
        }

        private void SetupRentalGrid()
        {
            dgvRentalList.AutoGenerateColumns = false;
            dgvRentalList.Columns.Clear();
            dgvRentalList.AllowUserToAddRows = false;
            dgvRentalList.ReadOnly = true;
            dgvRentalList.MultiSelect = false;
            dgvRentalList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentalList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRentalList.RowHeadersVisible = false;

            dgvRentalList.Columns.Add(new DataGridViewTextBoxColumn { Name = "RentalID", HeaderText = "Rental ID", DataPropertyName = "rental_id" });
            dgvRentalList.Columns.Add(new DataGridViewTextBoxColumn { Name = "Customer", HeaderText = "Customer", DataPropertyName = "customer_name" });
            dgvRentalList.Columns.Add(new DataGridViewTextBoxColumn { Name = "VehicleModel", HeaderText = "VehicleModel", DataPropertyName = "vehicle_name" });
            dgvRentalList.Columns.Add(
    new DataGridViewTextBoxColumn
    {
        Name = "Driver",
        HeaderText = "Assigned Driver",
        DataPropertyName = "driver_name"
    });
            dgvRentalList.Columns.Add(
    new DataGridViewTextBoxColumn
    {
        Name = "Driver",
        HeaderText = "Driver",
        DataPropertyName = "driver_name"
    });
            var rd = new DataGridViewTextBoxColumn { Name = "RentalDate", HeaderText = "Rental Date", DataPropertyName = "rental_date" };
            rd.DefaultCellStyle.Format = "MMM dd, yyyy";
            dgvRentalList.Columns.Add(rd);
            var ret = new DataGridViewTextBoxColumn { Name = "ReturnDate", HeaderText = "Return Date", DataPropertyName = "return_date" };
            ret.DefaultCellStyle.Format = "MMM dd, yyyy";
            dgvRentalList.Columns.Add(ret);
            dgvRentalList.Columns.Add(new DataGridViewTextBoxColumn { Name = "Days", HeaderText = "Days", DataPropertyName = "days" });
            var tot = new DataGridViewTextBoxColumn { Name = "TotalAmount", HeaderText = "Total Amount", DataPropertyName = "total_amount" };
            tot.DefaultCellStyle.Format = "N2";
            dgvRentalList.Columns.Add(tot);
            dgvRentalList.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "status" });
        }

        // =================== LOAD COMBOBOXES ===================
        private void LoadVehicleTypes()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    var da = new MySqlDataAdapter(
                        "SELECT DISTINCT vehicle_type FROM vehicles WHERE status = 'Available' ORDER BY vehicle_type", conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    var row = dt.NewRow();
                    row["vehicle_type"] = "All Types";
                    dt.Rows.InsertAt(row, 0);

                    cbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbVehicleType.DisplayMember = "vehicle_type";
                    cbVehicleType.ValueMember = "vehicle_type";
                    cbVehicleType.DataSource = dt;
                    cbVehicleType.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { ShowError("Failed to load vehicle types", ex); }
        }

        private void LoadCustomers()
        {
            // Only Active customers that have a license number on file
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    var da = new MySqlDataAdapter(
                        @"SELECT customer_id, full_name FROM customers
                          WHERE status = 'Active' AND license_no IS NOT NULL AND license_no <> ''
                          ORDER BY full_name", conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbCustomer.DisplayMember = "full_name";
                    cbCustomer.ValueMember = "customer_id";
                    cbCustomer.DataSource = dt;
                    cbCustomer.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { ShowError("Failed to load customers", ex); }
        }

        // =================== AVAILABLE VEHICLES ===================
        private void LoadAvailableVehicles()
        {
            if (loading) return;

            DateTime pickup = dateTimePicker1.Value.Date;
            DateTime ret = dateTimePicker2.Value.Date;

            if (ret < pickup)
            {
                dgvAvailableVehicles.DataSource = null;
                return;
            }


            string sql = @"
    SELECT v.vehicle_id, v.plate_number, v.vehicle_type,
           CONCAT(v.brand, ' ', v.model) AS vehicle_name,
           v.daily_rate
    FROM vehicles v
    WHERE v.status IN ('Available', 'Rented')
      AND NOT EXISTS (
            SELECT 1
            FROM rentals r
            WHERE r.vehicle_id = v.vehicle_id
              AND r.status = 'Active'
              AND DATE(r.rental_date) <= @ret
              AND DATE(r.expected_return) >= @pickup
      )";


            bool filterType = cbVehicleType.SelectedIndex > 0;
            if (filterType) sql += " AND v.vehicle_type = @type";

            decimal maxRate;
            bool filterRate = decimal.TryParse(tbMaxDailyRate.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out maxRate) && maxRate > 0;
            if (filterRate) sql += " AND v.daily_rate <= @maxRate";

            sql += " ORDER BY v.daily_rate ASC";

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    var da = new MySqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@pickup", pickup);
                    da.SelectCommand.Parameters.AddWithValue("@ret", ret);
                    if (filterType) da.SelectCommand.Parameters.AddWithValue("@type", cbVehicleType.Text);
                    if (filterRate) da.SelectCommand.Parameters.AddWithValue("@maxRate", maxRate);

                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvAvailableVehicles.DataSource = dt;
                    dgvAvailableVehicles.ClearSelection();
                }
            }
            catch (Exception ex) { ShowError("Failed to load available vehicles", ex); }

            // selected vehicle may no longer be available for the new dates
            selectedVehicleId = 0;
            selectedDailyRate = 0;
            UpdateSummary();
        }

        private void DatesChanged(object sender, EventArgs e)
        {
            if (loading) return;

            // return date can't be before pick-up date
            if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                loading = true;
                dateTimePicker2.Value = dateTimePicker1.Value.Date;
                loading = false;
            }
            dateTimePicker2.MinDate = dateTimePicker1.Value.Date;

            LoadAvailableVehicles();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadAvailableVehicles();
        }

        private void dgvAvailableVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (loading || dgvAvailableVehicles.CurrentRow == null || !dgvAvailableVehicles.CurrentRow.Selected)
                return;

            var row = dgvAvailableVehicles.CurrentRow;
            selectedVehicleId = Convert.ToInt32(row.Cells["vehicle_id"].Value);
            selectedDailyRate = Convert.ToDecimal(row.Cells["DailyRate"].Value);
            lblSelectedVehicle.Text = row.Cells["Plate"].Value + " " + row.Cells["Vehicle"].Value;
            UpdateSummary();
        }

        // =================== SUMMARY / COMPUTATION ===================
        private int GetRentalDays()
        {
            int days = (dateTimePicker2.Value.Date - dateTimePicker1.Value.Date).Days;
            return days < 1 ? 1 : days; // same-day rental counts as 1 day
        }

        private void UpdateSummary()
        {
            if (selectedVehicleId == 0)
            {
                ResetSummary();
                return;
            }

            int days = GetRentalDays();
            decimal total = selectedDailyRate * days;

            lblDailyRate.Text = selectedDailyRate.ToString("N2");
            lblRentalDays.Text = days.ToString();
            lblRentalTotal.Text = total.ToString("N2");
            UpdateBalance();
        }

        private void ResetSummary()
        {
            lblSelectedVehicle.Text = "—";
            lblDailyRate.Text = "0.00";
            lblRentalDays.Text = "0";
            lblRentalTotal.Text = "0.00";
            lblBalanceDue.Text = "0.00";
        }

        private decimal ParseMoney(string text)
        {
            decimal v;
            return decimal.TryParse(text.Replace(",", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out v) ? v : 0m;
        }

        private void UpdateBalance()
        {
            decimal total = ParseMoney(lblRentalTotal.Text);
            decimal paid = ParseMoney(tbAmountPaid.Text);
            lblBalanceDue.Text = (total - paid).ToString("N2");
        }

        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !tb.Text.Contains(".")) return;
            e.Handled = true;
        }

        // =================== CREATE RENTAL ===================

        private void btnCreateRental_Click(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue == null || cbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer.", "Missing Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCustomer.Focus();
                return;
            }

            if (selectedVehicleId == 0)
            {
                MessageBox.Show("Please select a vehicle from the available list.",
                    "Missing Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime pickup = dateTimePicker1.Value.Date;
            DateTime ret = dateTimePicker2.Value.Date;

            if (pickup < DateTime.Today)
            {
                MessageBox.Show("Pick-up date cannot be in the past.",
                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ret < pickup)
            {
                MessageBox.Show("Return date cannot be before the pick-up date.",
                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int days = GetRentalDays();
            decimal total = selectedDailyRate * days;
            decimal paid = ParseMoney(tbAmountPaid.Text);

            if (paid < 0 || paid > total)
            {
                MessageBox.Show(
                    "Amount paid must be between 0 and the total (" +
                    total.ToString("N2") + ").",
                    "Invalid Amount", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbAmountPaid.Focus();
                return;
            }

            // Detect the Driver checkbox. No Driver follows the existing self-drive flow.
            bool withDriver = IsDriverSelected();

            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    using (var tran = conn.BeginTransaction())
                    {
                        int driverId = 0;

                        // Recheck vehicle availability before creating the rental.
                        using (var check = new MySqlCommand(@"
                    SELECT COUNT(*)
                    FROM rentals
                    WHERE vehicle_id = @vid
                      AND status = 'Active'
                      AND DATE(rental_date) <= @ret
                      AND DATE(expected_return) >= @pickup",
                            conn, tran))
                        {
                            check.Parameters.AddWithValue("@vid", selectedVehicleId);
                            check.Parameters.AddWithValue("@pickup", pickup);
                            check.Parameters.AddWithValue("@ret", ret);

                            if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                            {
                                tran.Rollback();

                                MessageBox.Show(
                                    "This vehicle was just booked for overlapping dates. Please pick another.",
                                    "Not Available", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                LoadAvailableVehicles();
                                return;
                            }
                        }

                        // Automatically reserve an available driver when requested.
                        if (withDriver)
                        {
                            using (var driverCmd = new MySqlCommand(@"
                        SELECT driver_id
                        FROM drivers
                        WHERE status = 'Available'
                          AND (license_expiry IS NULL
                               OR license_expiry >= @pickup)
                        ORDER BY driver_id
                        LIMIT 1
                        FOR UPDATE",
                                conn, tran))
                            {
                                driverCmd.Parameters.AddWithValue("@pickup", pickup);

                                object result = driverCmd.ExecuteScalar();

                                if (result == null || result == DBNull.Value)
                                {
                                    tran.Rollback();

                                    MessageBox.Show(
                                        "No available driver with a valid license was found. " +
                                        "Please choose No Driver or make a driver available.",
                                        "No Driver Available",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                    return;
                                }

                                driverId = Convert.ToInt32(result);
                            }
                        }

                        // Save rental and its driver assignment together.
                        using (var cmd = new MySqlCommand(@"
                    INSERT INTO rentals
                        (customer_id, vehicle_id, rental_date,
                         expected_return, total_amount, amount_paid,
                         status, rental_type, driver_id, driver_fee)
                    VALUES
                        (@cid, @vid, @pickup, @ret, @total, @paid,
                         'Active', @rentalType, @driverId, 0)",
                            conn, tran))
                        {
                            cmd.Parameters.AddWithValue(
                                "@cid", Convert.ToInt32(cbCustomer.SelectedValue));
                            cmd.Parameters.AddWithValue("@vid", selectedVehicleId);
                            cmd.Parameters.AddWithValue("@pickup", pickup);
                            cmd.Parameters.AddWithValue("@ret", ret);
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@paid", paid);
                            cmd.Parameters.AddWithValue(
                                "@rentalType", withDriver ? "With Driver" : "Self-Drive");

                            if (withDriver)
                                cmd.Parameters.AddWithValue("@driverId", driverId);
                            else
                                cmd.Parameters.AddWithValue("@driverId", DBNull.Value);

                            cmd.ExecuteNonQuery();
                        }


                        // Keep driver status unchanged.
                        // Driver availability is checked against active rentals.
                        if (withDriver)
                        {
                            using (var checkDriver = new MySqlCommand(@"
                        SELECT COUNT(*)
                        FROM drivers d
                        WHERE d.driver_id = @driverId
                          AND d.status = 'Available'
                          AND (
                              d.license_expiry IS NULL
                              OR d.license_expiry >= @pickup
                          )
                          AND NOT EXISTS (
                              SELECT 1
                              FROM rentals r
                              WHERE r.driver_id = d.driver_id
                                AND r.status = 'Active'
                                AND DATE(r.rental_date) <= @ret
                                AND DATE(r.expected_return) >= @pickup
                          )",
                                conn, tran))
                            {
                                checkDriver.Parameters.AddWithValue("@driverId", driverId);
                                checkDriver.Parameters.AddWithValue("@pickup", pickup);
                                checkDriver.Parameters.AddWithValue("@ret", ret);

                                if (Convert.ToInt32(checkDriver.ExecuteScalar()) != 1)
                                {
                                    throw new Exception(
                                        "This driver is no longer available for the selected dates.");
                                }
                            }
                        }


                        // Preserve the existing vehicle-status behavior.
                        if (pickup == DateTime.Today)
                        {
                            using (var updateVehicle = new MySqlCommand(@"
                        UPDATE vehicles
                        SET status = 'Rented'
                        WHERE vehicle_id = @vid",
                                conn, tran))
                            {
                                updateVehicle.Parameters.AddWithValue("@vid", selectedVehicleId);
                                updateVehicle.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                    }
                }

                MessageBox.Show(
                    "Rental created successfully" +
                    (withDriver ? " with an assigned driver." : "."),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadVehicleTypes();
                LoadAvailableVehicles();
                LoadRentals();
            }
            catch (Exception ex)
            {
                ShowError("Failed to create rental", ex);
            }
        }


        // =================== RENTAL LIST ===================
        private void LoadRentals()
        {
            try
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    r.rental_id,
                    c.full_name AS customer_name,
                    CONCAT(v.brand, ' ', v.model) AS vehicle_name,
                    COALESCE(d.full_name, 'No Driver') AS driver_name,
                    r.rental_date,
                    r.expected_return AS return_date,
                    GREATEST(
                        DATEDIFF(r.expected_return, r.rental_date), 1
                    ) AS days,
                    r.total_amount,
                    r.status
                FROM rentals r
                JOIN customers c
                    ON c.customer_id = r.customer_id
                JOIN vehicles v
                    ON v.vehicle_id = r.vehicle_id
                LEFT JOIN drivers d
                    ON d.driver_id = r.driver_id
                WHERE r.status = 'Active'
                ORDER BY r.rental_id DESC;";

                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRentalList.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Failed to load active rentals", ex);
            }
        }

        // =================== CLEAR ===================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadAvailableVehicles();
        }

        private void ClearForm()
        {
            loading = true;

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(1);
            if (cbVehicleType.Items.Count > 0) cbVehicleType.SelectedIndex = 0;
            tbMaxDailyRate.Clear();
            cbCustomer.SelectedIndex = -1;
            tbAmountPaid.Clear();
            selectedVehicleId = 0;
            selectedDailyRate = 0;
            dgvAvailableVehicles.ClearSelection();

            loading = false;
            ResetSummary();
        }

        private void ShowError(string title, Exception ex)
        {
            MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool IsDriverSelected()
        {
            return FindDriverCheckbox(this.Controls);
        }

        private bool FindDriverCheckbox(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                CheckBox checkBox = control as CheckBox;

                if (checkBox != null &&
                    string.Equals(
                        checkBox.Text.Trim(),
                        "Driver",
                        StringComparison.OrdinalIgnoreCase))
                {
                    return checkBox.Checked;
                }

                if (control.HasChildren &&
                    FindDriverCheckbox(control.Controls))
                {
                    return true;
                }
            }

            return false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2Vehicles()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvRentalList.CurrentRow == null ||
                dgvRentalList.CurrentRow.Cells["RentalID"].Value == null)
            {
                MessageBox.Show(
                    "Please select an active rental from the Rental List first.",
                    "No Rental Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            long selectedRentalId = Convert.ToInt64(
                dgvRentalList.CurrentRow.Cells["RentalID"].Value);

            Form4ReturnManagement returnForm =
                new Form4ReturnManagement(selectedRentalId);

            returnForm.StartPosition = FormStartPosition.Manual;
            returnForm.Location = this.Location;
            returnForm.Size = this.Size;
            returnForm.WindowState = this.WindowState;

            returnForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3RentalManagement());

        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            OpenForm(new DriverManagementForm());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2Vehicles());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Reports());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
