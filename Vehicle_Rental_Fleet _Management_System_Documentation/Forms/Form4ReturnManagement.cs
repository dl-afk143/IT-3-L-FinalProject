
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class Form4ReturnManagement : Form
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        private long 
            rentalId;
        private int vehicleId;

        // =========================
        // FORM CONSTRUCTORS
        // =========================
        public Form4ReturnManagement() : this(0)
        {
        }

        public Form4ReturnManagement(long selectedRentalId)
        {
            InitializeComponent();

            rentalId = selectedRentalId;

            ApplyReturnVehicleDesign();

            // Sidebar navigation
            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnVehicles.Click -= btnVehicles_Click;
            btnVehicles.Click += btnVehicles_Click;

            btnRentals.Click -= btnRentals_Click;
            btnRentals.Click += btnRentals_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;

            btnCustomers.Click -= btnCustomers_Click;
            btnCustomers.Click += btnCustomers_Click;

            // Return actions
            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;

            btnCompleteReturn.Click -= btnCompleteReturn_Click;
            btnCompleteReturn.Click += btnCompleteReturn_Click;

            this.Load -= Form4ReturnManagement_Load;
            this.Load += Form4ReturnManagement_Load;
        }

        // =========================
        // RETURN VEHICLE DESIGN
        // =========================
        private void ApplyReturnVehicleDesign()
        {
            Color pageBackground = Color.FromArgb(242, 242, 242);
            Color headerBlue = Color.FromArgb(217, 231, 245);
            Color borderBlue = Color.FromArgb(190, 210, 232);
            Color mintBackground = Color.FromArgb(234, 246, 237);
            Color darkGreen = Color.FromArgb(0, 110, 65);
            Color completeGreen = Color.FromArgb(0, 140, 0);
            Color darkText = Color.FromArgb(25, 25, 25);

            this.BackColor = pageBackground;
            this.ForeColor = darkText;
            this.Font = new Font("Segoe UI", 10F);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlDashboardSidebar.BackColor =
                Color.FromArgb(11, 55, 100);

            pnlRentalInformation.BackColor = Color.White;
            pnlRentalInformation.BorderColor = borderBlue;

            roundedGroupBox1.BackColor = Color.White;
            roundedGroupBox1.BorderColor = borderBlue;

            roundedGroupBox2.BackColor = Color.White;
            roundedGroupBox2.BorderColor = borderBlue;

            roundedGroupBox3.BackColor = Color.White;
            roundedGroupBox3.BorderColor = borderBlue;

            roundedGroupBox4.BackColor = mintBackground;
            roundedGroupBox4.BorderColor =
                Color.FromArgb(200, 228, 207);

            roundedPanel1.BackColor = headerBlue;
            roundedPanel2.BackColor = headerBlue;
            roundedPanel3.BackColor = headerBlue;
            roundedPanel6.BackColor = headerBlue;

            roundedPanel1.BorderRadius = 12;
            roundedPanel2.BorderRadius = 12;
            roundedPanel3.BorderRadius = 12;
            roundedPanel6.BorderRadius = 12;

            StyleSectionTitle(label13);
            StyleSectionTitle(label15);
            StyleSectionTitle(label10);
            StyleSectionTitle(label36);

            // Selected rental
            StyleValue(lblRentalID);
            StyleValue(lblCustomer);
            StyleValue(lblContactNumber);
            StyleValue(lblDate1);
            StyleValue(lblDate2);
            StyleValue(lblDays);
            StyleValue(lblRentalType);
            StyleValue(lblTotalAmount);
            StyleValue(lbAmountPaid);

            // Vehicle information
            StyleValue(lblBrandModel);
            StyleValue(lblVehicleType);
            StyleValue(lblPlateNumber);
            StyleValue(lblBrandModel1);
            StyleValue(lblDailyRate1);

            roundedPanel4.BackColor = headerBlue;
            roundedPanel4.BorderRadius = 10;

            // Rental summary
            StyleValue(lblRentalDays);
            StyleValue(lblDailyRate);
            StyleValue(lblTotalAmount1);
            StyleValue(lblAmountPaid);
            StyleValue(lblRemainingBalance);

            roundedPanel5.BackColor = headerBlue;
            roundedPanel5.BorderRadius = 12;

            // Actual return date
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dddd, MMMM dd, yyyy";
            dateTimePicker2.Font = new Font("Segoe UI", 10F);
            dateTimePicker2.Value = DateTime.Today;

            // Actual return time
            dtReturnTime.Format = DateTimePickerFormat.Custom;
            dtReturnTime.CustomFormat = "hh:mm tt";
            dtReturnTime.ShowUpDown = true;
            dtReturnTime.Font = new Font("Segoe UI", 10F);
            dtReturnTime.Value = DateTime.Now;

            // Fuel level
            cbFuelLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuelLevel.Font = new Font("Segoe UI", 10F);

            if (cbFuelLevel.Items.Count == 0)
            {
                cbFuelLevel.Items.AddRange(new object[]
                {
                    "Empty (0%)",
                    "1/4 (25%)",
                    "1/2 (50%)",
                    "3/4 (75%)",
                    "Full (100%)"
                });
            }

            // Vehicle condition
            cbVehicleCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehicleCondition.Font = new Font("Segoe UI", 10F);

            if (cbVehicleCondition.Items.Count == 0)
            {
                cbVehicleCondition.Items.AddRange(new object[]
                {
                    "Good",
                    "Minor Damage",
                    "Major Damage",
                    "Needs Maintenance"
                });
            }

            if (cbFuelLevel.Items.Count > 0)
                cbFuelLevel.SelectedIndex = 0;

            if (cbVehicleCondition.Items.Count > 0)
                cbVehicleCondition.SelectedIndex = 0;

            // Confirmation notice
            label45.BackColor = mintBackground;
            label45.ForeColor = darkGreen;
            label45.Font = new Font("Segoe UI", 10F);
            label45.AutoSize = false;
            label45.Size = new Size(498, 76);
            label45.TextAlign = ContentAlignment.MiddleLeft;

            // Buttons
            StyleActionButton(
                btnCancel,
                Color.FromArgb(235, 235, 235),
                darkText,
                borderBlue);

            StyleActionButton(
                btnReceipt,
                Color.White,
                Color.FromArgb(20, 45, 80),
                borderBlue);

            StyleActionButton(
                btnCompleteReturn,
                completeGreen,
                Color.White,
                completeGreen);
        }

        // =========================
        // STYLE SECTION TITLES
        // =========================
        private void StyleSectionTitle(Label label)
        {
            label.Font = new Font(
                "Segoe UI",
                15F,
                FontStyle.Bold);

            label.ForeColor = Color.Black;
            label.TextAlign = ContentAlignment.MiddleLeft;
        }

        // =========================
        // STYLE DISPLAY VALUES
        // =========================
        private void StyleValue(Label label)
        {
            label.ForeColor = Color.FromArgb(25, 25, 25);

            label.Font = new Font(
                "Segoe UI",
                10.5F,
                FontStyle.Regular);
        }

        // =========================
        // STYLE ACTION BUTTONS
        // =========================
        private void StyleActionButton(
            Button button,
            Color background,
            Color foreground,
            Color border)
        {
            button.BackColor = background;
            button.ForeColor = foreground;
            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = border;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void Form4ReturnManagement_Load(
            object sender,
            EventArgs e)
        {
            if (rentalId > 0)
            {
                LoadRentalDetails(rentalId);
            }
            else
            {
                label45.Text =
                    "Select an active rental before processing its return.";
            }
        }

        // =========================
        // LOAD RENTAL FROM MYSQL
        // =========================
        private void LoadRentalDetails(long selectedRentalId)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            r.rental_id,
                            r.vehicle_id,
                            c.full_name,
                            c.contact_number,
                            r.rental_date,
                            r.expected_return,
                            r.total_amount,
                            r.amount_paid,
                            r.rental_type,
                            r.status AS rental_status,
                            v.vehicle_type,
                            v.brand,
                            v.model,
                            v.plate_number,
                            v.daily_rate
                        FROM rentals r
                        INNER JOIN customers c
                            ON r.customer_id = c.customer_id
                        INNER JOIN vehicles v
                            ON r.vehicle_id = v.vehicle_id
                        WHERE r.rental_id = @rentalId
                        LIMIT 1;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@rentalId",
                            selectedRentalId);

                        using (MySqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "The selected rental was not found.",
                                    "Rental Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            string status =
                                reader["rental_status"].ToString();

                            if (!status.Equals(
                                "Active",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show(
                                    "Only active rentals can be returned.",
                                    "Invalid Rental",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            rentalId = Convert.ToInt64(
                                reader["rental_id"]);

                            vehicleId = Convert.ToInt32(
                                reader["vehicle_id"]);

                            string customerName =
                                reader["full_name"].ToString();

                            string contactNumber =
                                reader["contact_number"] == DBNull.Value
                                ? "N/A"
                                : reader["contact_number"].ToString();

                            DateTime pickupDate =
                                Convert.ToDateTime(
                                    reader["rental_date"]);

                            DateTime expectedReturn =
                                Convert.ToDateTime(
                                    reader["expected_return"]);

                            decimal totalAmount =
                                Convert.ToDecimal(
                                    reader["total_amount"]);

                            decimal amountPaid =
                                reader["amount_paid"] == DBNull.Value
                                ? 0m
                                : Convert.ToDecimal(
                                    reader["amount_paid"]);

                            decimal dailyRate =
                                Convert.ToDecimal(
                                    reader["daily_rate"]);

                            string rentalType =
                                reader["rental_type"] == DBNull.Value
                                ? "N/A"
                                : reader["rental_type"].ToString();

                            string vehicleType =
                                reader["vehicle_type"].ToString();

                            string brand =
                                reader["brand"].ToString();

                            string model =
                                reader["model"].ToString();

                            string plateNumber =
                                reader["plate_number"].ToString();

                            int rentalDays = Math.Max(
                                1,
                                (expectedReturn.Date -
                                 pickupDate.Date).Days);

                            decimal remainingBalance =
                                Math.Max(0m, totalAmount - amountPaid);

                            // Selected Rental
                            lblRentalID.Text =
                                rentalId.ToString();

                            lblCustomer.Text =
                                customerName;

                            lblContactNumber.Text =
                                contactNumber;

                            lblDate1.Text =
                                pickupDate.ToString("MMM dd, yyyy");

                            lblDate2.Text =
                                expectedReturn.ToString("MMM dd, yyyy");

                            lblDays.Text =
                                rentalDays + " days";

                            lblRentalType.Text =
                                rentalType;

                            lblTotalAmount.Text =
                                totalAmount.ToString("#,##0.00");

                            lbAmountPaid.Text =
                                amountPaid.ToString("#,##0.00");

                            // Vehicle Information
                            lblVehicleType.Text =
                                vehicleType;

                            lblBrandModel.Text =
                                brand + " " + model;

                            lblBrandModel1.Text =
                                brand + " " + model;

                            lblPlateNumber.Text =
                                plateNumber;

                            lblDailyRate1.Text =
                                dailyRate.ToString("#,##0.00");

                            // Rental Summary
                            lblRentalDays.Text =
                                rentalDays.ToString();

                            lblDailyRate.Text =
                                dailyRate.ToString("#,##0.00");

                            lblTotalAmount1.Text =
                                totalAmount.ToString("#,##0.00");

                            lblAmountPaid.Text =
                                amountPaid.ToString("#,##0.00");

                            lblRemainingBalance.Text =
                                remainingBalance.ToString("#,##0.00");

                            label45.Text =
                                "Confirm the vehicle condition and fuel level before completing the return.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load rental details.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // COMPLETE RETURN
        // =========================
        private void btnCompleteReturn_Click(
            object sender,
            EventArgs e)
        {
            if (rentalId <= 0 || vehicleId <= 0)
            {
                MessageBox.Show(
                    "Load an active rental before completing its return.",
                    "No Rental Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cbFuelLevel.SelectedIndex < 0 ||
                cbVehicleCondition.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select the fuel level and vehicle condition.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to complete this vehicle return?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlTransaction tran = conn.BeginTransaction())
                    {
                        // Verify the rental is still active.
                        string checkQuery = @"
                            SELECT vehicle_id
                            FROM rentals
                            WHERE rental_id = @rentalId
                              AND status = 'Active'
                            FOR UPDATE;";

                        using (MySqlCommand checkCmd =
                            new MySqlCommand(
                                checkQuery,
                                conn,
                                tran))
                        {
                            checkCmd.Parameters.AddWithValue(
                                "@rentalId",
                                rentalId);

                            object result = checkCmd.ExecuteScalar();

                            if (result == null)
                            {
                                tran.Rollback();

                                MessageBox.Show(
                                    "This rental is no longer active. Refresh the rental details.",
                                    "Rental Already Processed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            vehicleId = Convert.ToInt32(result);
                        }

                        // Complete the rental.
                        string rentalQuery = @"
                            UPDATE rentals
                            SET status = 'Completed'
                            WHERE rental_id = @rentalId
                              AND status = 'Active';";

                        using (MySqlCommand rentalCmd =
                            new MySqlCommand(
                                rentalQuery,
                                conn,
                                tran))
                        {
                            rentalCmd.Parameters.AddWithValue(
                                "@rentalId",
                                rentalId);

                            int affected = rentalCmd.ExecuteNonQuery();

                            if (affected != 1)
                            {
                                tran.Rollback();

                                MessageBox.Show(
                                    "The rental could not be completed.",
                                    "Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }
                        }

                        // Make vehicle available only if it is not
                        // marked as Maintenance.
                        string vehicleQuery = @"
                            UPDATE vehicles
                            SET status = 'Available'
                            WHERE vehicle_id = @vehicleId
                              AND status = 'Rented';";

                        using (MySqlCommand vehicleCmd =
                            new MySqlCommand(
                                vehicleQuery,
                                conn,
                                tran))
                        {
                            vehicleCmd.Parameters.AddWithValue(
                                "@vehicleId",
                                vehicleId);

                            vehicleCmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                }

                MessageBox.Show(
                    "Vehicle return completed successfully.\n\n" +
                    "Rental ID: " + rentalId +
                    "\nFuel Level: " + cbFuelLevel.Text +
                    "\nVehicle Condition: " + cbVehicleCondition.Text +
                    "\n\nNote: Fuel level and vehicle condition are displayed " +
                    "for confirmation but are not saved to the database by this code.",
                    "Return Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                label45.Text =
                    "Return completed successfully.";

                btnCompleteReturn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to complete the return.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // OPEN OTHER FORMS
        // =========================
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

        // =========================
        // SIDEBAR NAVIGATION
        // =========================
        private void btnDashboard_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void btnVehicles_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new Form2Vehicles());
        }

        private void btnRentals_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new Form3RentalManagement());
        }

        private void btnReturns_Click(
            object sender,
            EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void btnCustomers_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new CustomerManagementForm());
        }

        private void btnReports_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new Form5Reports());
        }

        // =========================
        // CANCEL RETURN
        // =========================
        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new Form3RentalManagement());
        }

        // =========================
        // EXISTING DESIGNER EVENTS
        // =========================
        private void label3_Click(
            object sender,
            EventArgs e)
        {
        }

        private void dgvRecentRentals_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void grbRentalInformation_Enter(
            object sender,
            EventArgs e)
        {
        }

        private void pictureBox15_Click(
            object sender,
            EventArgs e)
        {
        }

        private void pictureBox21_Click(
            object sender,
            EventArgs e)
        {
        }

        private void roundedButton1_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Receipt generation has not been implemented yet.",
                "Receipt",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnCompleteReturn_Click_1(object sender, EventArgs e)
        {
            if (rentalId <= 0)
            {
                MessageBox.Show(
                    "No rental was selected. Please open Returns from the Rental List.",
                    "Missing Rental",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int vehicleId;

                        // Check that this rental is still active.
                        using (MySqlCommand checkCmd = new MySqlCommand(
                            "SELECT vehicle_id FROM rentals " +
                            "WHERE rental_id = @rentalId AND status = 'Active' " +
                            "FOR UPDATE",
                            conn, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@rentalId", rentalId);

                            object result = checkCmd.ExecuteScalar();

                            if (result == null)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "This rental was not found or has already been returned.",
                                    "Return Not Available",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }

                            vehicleId = Convert.ToInt32(result);
                        }

                        // Mark the rental as completed.
                        using (MySqlCommand updateRentalCmd = new MySqlCommand(
                            "UPDATE rentals SET status = 'Completed' " +
                            "WHERE rental_id = @rentalId AND status = 'Active'",
                            conn, transaction))
                        {
                            updateRentalCmd.Parameters.AddWithValue("@rentalId", rentalId);

                            if (updateRentalCmd.ExecuteNonQuery() != 1)
                            {
                                throw new Exception("The rental status could not be updated.");
                            }
                        }

                        // Make the vehicle available again.
                        using (MySqlCommand updateVehicleCmd = new MySqlCommand(
                            "UPDATE vehicles SET status = 'Available' " +
                            "WHERE vehicle_id = @vehicleId AND status = 'Rented'",
                            conn, transaction))
                        {
                            updateVehicleCmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                            updateVehicleCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                            // Ignore rollback errors.
                        }

                        MessageBox.Show(
                            "Unable to complete the vehicle return.\n\n" + ex.Message,
                            "Return Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show(
                "Vehicle return completed successfully!",
                "Return Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reopen Rental Management to refresh the active rental list.
            Form3RentalManagement rentalForm = new Form3RentalManagement();

            rentalForm.StartPosition = FormStartPosition.Manual;
            rentalForm.Location = this.Location;
            rentalForm.Size = this.Size;
            rentalForm.WindowState = this.WindowState;

            rentalForm.Show();
            this.Hide();
        }

    }
}
