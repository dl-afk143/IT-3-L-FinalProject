
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class Form1 : Form
    {
        public string LoggedInFullName { get; private set; }
        public string LoggedInRole { get; private set; }

        public Form1() : this("", "Staff")
        {
        }

        public Form1(string loggedInFullName, string loggedInRole)
        {
            InitializeComponent();
            btnManageUsers.Visible = loggedInRole == "Admin";

            LoggedInFullName = loggedInFullName;
            LoggedInRole = loggedInRole;

            // Make the dashboard fit the available screen.
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.MinimumSize = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Connect navigation buttons.
            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnVehicles.Click -= btnVehicles_Click;
            btnVehicles.Click += btnVehicles_Click;

            btnCustomers.Click -= btnCustomerManagement_Click;
            btnCustomers.Click += btnCustomerManagement_Click;

            btnRentals.Click -= btnRentals_Click;
            btnRentals.Click += btnRentals_Click;

            btnDriver.Click -= btnDriver_Click;
            btnDriver.Click += btnDriver_Click;

            btnReturns.Click -= btnReturns_Click;
            btnReturns.Click += btnReturns_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;

            // Keep the existing design but make the main sections responsive.
            this.Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyDashboardLayout();
            LoadDashboardData();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ApplyDashboardLayout();
        }

        private void ApplyDashboardLayout()
        {
            if (pnlDashboardSidebar == null ||
                panel1 == null ||
                dgv == null ||
                roundedPanel1 == null)
                return;

            int sidebarWidth = 244;
            int contentLeft = sidebarWidth + 12;
            int rightMargin = 14;
            int contentWidth = Math.Max(
                500,
                this.ClientSize.Width - contentLeft - rightMargin);

            // Sidebar stays on the left.
            pnlDashboardSidebar.Location = new Point(0, 0);
            pnlDashboardSidebar.Width = sidebarWidth;
            pnlDashboardSidebar.Height = this.ClientSize.Height;

            // Header fills the available content area.
            panel1.Location = new Point(sidebarWidth, 0);
            panel1.Width = Math.Max(500, this.ClientSize.Width - sidebarWidth);
            panel1.Height = 127;

            // Resize the five statistic cards evenly.
            int gap = 12;
            int cardWidth = Math.Max(120, (contentWidth - gap * 4) / 5);
            int cardY = 145;
            int cardHeight = 166;

            RoundedPanel[] cards =
            {
                roundedPanel1,
                roundedPanel3,
                roundedPanel5,
                roundedPanel7,
                roundedPanel9
            };

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Location = new Point(
                    contentLeft + i * (cardWidth + gap),
                    cardY);

                cards[i].Size = new Size(cardWidth, cardHeight);

                // Resize the white inner card to match.
                if (cards[i].Controls.Count > 0)
                {
                    Control inner = cards[i].Controls[0];
                    inner.Location = new Point(0, 8);
                    inner.Size = new Size(cardWidth, cardHeight - 8);
                }
            }

            // Recent rental section expands with the form.
            int tableY = cardY + cardHeight + 12;
            int revenueHeight = 45;
            int bottomMargin = 75;
            int tableHeight = Math.Max(
                180,
                this.ClientSize.Height - tableY - revenueHeight - bottomMargin);

            dgv.Location = new Point(contentLeft, tableY);
            dgv.Size = new Size(contentWidth, tableHeight);

            label22.Location = new Point(12, 12);

            dgvRentalReport.Location = new Point(12, 48);
            dgvRentalReport.Size = new Size(
                Math.Max(300, dgv.ClientSize.Width - 24),
                Math.Max(100, dgv.ClientSize.Height - 60));

            // Keep the revenue summary below the table.
            label14.Location = new Point(contentLeft, tableY + tableHeight + 18);
            lblTotalRentalRevenue.Location = new Point(
                label14.Right + 8,
                label14.Top + 3);
        }

        private void LoadDashboardData()
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();

                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    // Total vehicles.
                    lblTotalVehicle.Text = GetCount(
                        connection,
                        "SELECT COUNT(*) FROM vehicles");

                    // Available vehicles.
                    lblAvailableCount.Text = GetCount(
                        connection,
                        "SELECT COUNT(*) FROM vehicles WHERE status = 'Available'");

                    // Vehicles under maintenance.
                    lblMaintenanceCount.Text = GetCount(
                        connection,
                        "SELECT COUNT(*) FROM vehicles WHERE status = 'Maintenance'");

                    // Currently rented vehicles.
                    lblRentedCount.Text = GetCount(
                        connection,
                        "SELECT COUNT(*) FROM vehicles WHERE status = 'Rented'");

                    // Active rentals are counted from the rentals table.
                    lblActiveVehicle.Text = GetCount(
                        connection,
                        "SELECT COUNT(*) FROM rentals WHERE status = 'Active'");

                    using (MySqlCommand command = new MySqlCommand(
                        "SELECT COALESCE(SUM(total_amount), 0) FROM rentals " +
                        "WHERE status IN ('Active', 'Completed')",
                        connection))
                    {
                        decimal revenue = Convert.ToDecimal(command.ExecuteScalar());
                        lblTotalRentalRevenue.Text = revenue.ToString("₱#,##0.00");
                    }

                    LoadRecentRentals(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GetCount(MySqlConnection connection, string query)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                return Convert.ToInt32(command.ExecuteScalar()).ToString();
            }
        }

        private void LoadRecentRentals(MySqlConnection connection)
        {
            string query =
                "SELECT r.rental_id, c.full_name AS Customer, " +
                "CONCAT(v.brand, ' ', v.model) AS Vehicle, " +
                "v.plate_number AS PlateNumber, v.vehicle_type AS VehicleType, " +
                "r.rental_date AS RentalDate, v.daily_rate AS DailyRate, " +
                "r.status AS Status " +
                "FROM rentals r " +
                "INNER JOIN customers c ON r.customer_id = c.customer_id " +
                "INNER JOIN vehicles v ON r.vehicle_id = v.vehicle_id " +
                "ORDER BY r.created_at DESC LIMIT 10";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);

                dgvRentalReport.DataSource = null;
                dgvRentalReport.Columns.Clear();
                dgvRentalReport.AutoGenerateColumns = true;
                dgvRentalReport.DataSource = table;

                dgvRentalReport.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvRentalReport.ReadOnly = true;
                dgvRentalReport.AllowUserToAddRows = false;
                dgvRentalReport.RowHeadersVisible = false;
                dgvRentalReport.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            }
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Already on the dashboard.
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2Vehicles());
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerManagementForm());
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3RentalManagement());
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            OpenForm(new DriverManagementForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5Reports());
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

        private void TestDatabaseConnection()
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();

                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Database connection successful!",
                        "Connection Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed!\n\n" + ex.Message,
                    "Connection Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void dgvRecentRentals_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }
        private void label22_Click(object sender, EventArgs e) { }
        private void tbSearch_TextChanged(object sender, EventArgs e) { }
    }
}
