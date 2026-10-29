
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class Form5Reports : Form
    {
        private readonly DatabaseConnection db = new DatabaseConnection();
        private DataTable reportData = new DataTable();
        private readonly PrintDocument printDocument = new PrintDocument();
        private int printRowIndex = 0;

        public Form5Reports()
        {
            InitializeComponent();

            // Connect buttons and search field.
            btnGenerate.Click -= btnGenerate_Click;
            btnGenerate.Click += btnGenerate_Click;

            btnExport.Click -= btnExport_Click;
            btnExport.Click += btnExport_Click;

            btnPrint.Click -= btnPrint_Click;
            btnPrint.Click += btnPrint_Click;

            //tbSearch.TextChanged -= tbSearch_TextChanged;
            //tbSearch.TextChanged += tbSearch_TextChanged;

            printDocument.BeginPrint += printDocument_BeginPrint;
            printDocument.PrintPage += printDocument_PrintPage;

            LoadReportSettings();
        }

        private void LoadReportSettings()
        {
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Keep the report type names consistent with the Designer.
            if (cmbReportType.Items.Count == 0)
            {
                cmbReportType.Items.Add("Rental History");
                cmbReportType.Items.Add("Vehicle Status");
                cmbReportType.Items.Add("Customer Records");
                cmbReportType.Items.Add("Returned Vehicles");
            }

            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "MM/dd/yyyy";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";

            dtpFromDate.Value = DateTime.Today.AddMonths(-1);
            dateTimePicker1.Value = DateTime.Today;

            dgvRentalReport.DataSource = null;
            dgvRentalReport.Columns.Clear();
            dgvRentalReport.AutoGenerateColumns = true;
            dgvRentalReport.ReadOnly = true;
            dgvRentalReport.AllowUserToAddRows = false;
            dgvRentalReport.AllowUserToDeleteRows = false;
            dgvRentalReport.MultiSelect = false;
            dgvRentalReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvRentalReport.RowHeadersVisible = false;
            dgvRentalReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            lblTotalRentals.Text = "0";
            lblTotalRevenue.Text = "₱0.00";
            lblAveragePerRental.Text = "₱0.00";
            lblTotal.Text = "Total: 0";

            if (cmbReportType.Items.Count > 0 &&
                cmbReportType.SelectedIndex < 0)
            {
                cmbReportType.SelectedIndex = 0;
            }
        }

        // GENERATE REPORT
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbReportType.Text))
            {
                MessageBox.Show("Please select a report type.",
                    "Report Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFromDate.Value.Date > dateTimePicker1.Value.Date)
            {
                MessageBox.Show("From Date cannot be later than To Date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query;
                string reportType = cmbReportType.Text.Trim();

                switch (reportType)
                {
                    case "Rental History":
                        query = @"
                            SELECT
                                r.rental_id AS RentalID,
                                c.full_name AS Customer,
                                CONCAT(v.brand, ' ', v.model,
                                    ' (', v.plate_number, ')') AS VehicleModel,
                                r.rental_date AS RentalDate,
                                r.expected_return AS ReturnDate,
                                r.total_amount AS TotalAmount,
                                r.status AS Status
                            FROM rentals r
                            INNER JOIN customers c
                                ON r.customer_id = c.customer_id
                            INNER JOIN vehicles v
                                ON r.vehicle_id = v.vehicle_id
                            WHERE r.rental_date >= @fromDate
                              AND r.rental_date < DATE_ADD(@toDate, INTERVAL 1 DAY)
                            ORDER BY r.rental_date DESC;";
                        break;

                    case "Vehicle Status":
                        query = @"
                            SELECT
                                v.vehicle_id AS VehicleID,
                                v.plate_number AS PlateNumber,
                                v.vehicle_type AS VehicleType,
                                v.brand AS Brand,
                                v.model AS Model,
                                v.year_model AS YearModel,
                                v.daily_rate AS DailyRate,
                                v.status AS Status
                            FROM vehicles v
                            ORDER BY v.vehicle_id DESC;";
                        break;

                    case "Customer Records":
                        query = @"
                            SELECT
                                c.customer_id AS CustomerID,
                                c.full_name AS CustomerName,
                                c.contact_number AS ContactNumber,
                                c.email AS Email,
                                c.license_no AS LicenseNumber,
                                c.address AS Address,
                                c.status AS Status
                            FROM customers c
                            ORDER BY c.customer_id DESC;";
                        break;

                    case "Returned Vehicles":
                        query = @"
                            SELECT
                                r.rental_id AS RentalID,
                                c.full_name AS Customer,
                                CONCAT(v.brand, ' ', v.model,
                                    ' (', v.plate_number, ')') AS VehicleModel,
                                r.rental_date AS RentalDate,
                                r.expected_return AS ExpectedReturnDate,
                                r.total_amount AS TotalAmount,
                                r.status AS Status
                            FROM rentals r
                            INNER JOIN customers c
                                ON r.customer_id = c.customer_id
                            INNER JOIN vehicles v
                                ON r.vehicle_id = v.vehicle_id
                            WHERE r.status = 'Completed'
                              AND r.rental_date >= @fromDate
                              AND r.rental_date < DATE_ADD(@toDate, INTERVAL 1 DAY)
                            ORDER BY r.rental_date DESC;";
                        break;

                    default:
                        MessageBox.Show("Invalid report type selected.");
                        return;
                }

                DataTable result = new DataTable();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Date range applies to rental reports.
                        if (reportType == "Rental History" ||
                            reportType == "Returned Vehicles")
                        {
                            cmd.Parameters.AddWithValue(
                                "@fromDate", dtpFromDate.Value.Date);

                            cmd.Parameters.AddWithValue(
                                "@toDate", dateTimePicker1.Value.Date);
                        }

                        using (MySqlDataAdapter adapter =
                            new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(result);
                        }
                    }
                }

                reportData = result;
                //tbSearch.Clear();

                DisplayReport(reportData);
                UpdateSummary(reportData);

                if (result.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No records found for this report.",
                        "No Records",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to generate report.\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // DISPLAY REPORT IN DATAGRIDVIEW
        private void DisplayReport(DataTable data)
        {
            dgvRentalReport.DataSource = null;
            dgvRentalReport.Columns.Clear();
            dgvRentalReport.AutoGenerateColumns = true;
            dgvRentalReport.DataSource = data;

            foreach (DataGridViewColumn column in dgvRentalReport.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;

                string name = column.Name.ToLowerInvariant();

                if (name.Contains("date") || name.Contains("return"))
                    column.DefaultCellStyle.Format = "MM/dd/yyyy";

                if (name.Contains("amount") || name.Contains("rate"))
                    column.DefaultCellStyle.Format = "₱#,##0.00";
            }

            lblTotal.Text = "Total: " + data.Rows.Count;
        }

        // UPDATE SUMMARY CARDS
        private void UpdateSummary(DataTable data)
        {
            int count = data.Rows.Count;
            decimal revenue = 0m;
            bool hasAmount = data.Columns.Contains("TotalAmount");

            if (hasAmount)
            {
                foreach (DataRow row in data.Rows)
                {
                    if (row["TotalAmount"] != DBNull.Value)
                    {
                        decimal amount;

                        if (decimal.TryParse(
                            row["TotalAmount"].ToString(), out amount))
                        {
                            revenue += amount;
                        }
                    }
                }

                lblTotalRevenue.Text = revenue.ToString("₱#,##0.00");

                decimal average = count > 0 ? revenue / count : 0m;
                lblAveragePerRental.Text = average.ToString("₱#,##0.00");
            }
            else
            {
                lblTotalRevenue.Text = "N/A";
                lblAveragePerRental.Text = "N/A";
            }

            lblTotalRentals.Text = count.ToString();
        }

        // SEARCH REPORT
        

        // EXPORT TO CSV
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvRentalReport.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to export.",
                    "Nothing to Export",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.Title = "Export Report";
                dialog.FileName =
                    cmbReportType.Text.Replace(" ", "_") + "_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    StringBuilder csv = new StringBuilder();

                    for (int col = 0; col < dgvRentalReport.Columns.Count; col++)
                    {
                        if (col > 0) csv.Append(",");

                        csv.Append(EscapeCsv(
                            dgvRentalReport.Columns[col].HeaderText));
                    }

                    csv.AppendLine();

                    foreach (DataGridViewRow row in dgvRentalReport.Rows)
                    {
                        if (row.IsNewRow)
                            continue;

                        for (int col = 0; col < dgvRentalReport.Columns.Count; col++)
                        {
                            if (col > 0) csv.Append(",");

                            object value = row.Cells[col].Value;

                            csv.Append(EscapeCsv(
                                value == null ? "" : value.ToString()));
                        }

                        csv.AppendLine();
                    }

                    File.WriteAllText(
                        dialog.FileName,
                        csv.ToString(),
                        new UTF8Encoding(true));

                    MessageBox.Show("Report exported successfully.",
                        "Export Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed.\n\n" + ex.Message,
                        "Export Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string EscapeCsv(string value)
        {
            if (value == null)
                return "";

            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        // PRINT PREVIEW
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvRentalReport.Rows.Count == 0)
            {
                MessageBox.Show("Generate a report before printing.",
                    "Nothing to Print",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (PrintPreviewDialog preview = new PrintPreviewDialog())
                {
                    preview.Document = printDocument;
                    preview.Width = 1000;
                    preview.Height = 700;
                    preview.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print preview failed.\n\n" + ex.Message,
                    "Print Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            printRowIndex = 0;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float left = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            using (Font titleFont = new Font("Arial", 15, FontStyle.Bold))
            using (Font headerFont = new Font("Arial", 8, FontStyle.Bold))
            using (Font rowFont = new Font("Arial", 8))
            using (Pen pen = new Pen(Color.Gray))
            {
                g.DrawString("Vehicle Rental Fleet Management System",
                    titleFont, Brushes.Black, left, y);
                y += 30;

                g.DrawString("Report: " + cmbReportType.Text,
                    rowFont, Brushes.Black, left, y);
                y += 20;

                g.DrawString("Printed: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"),
                    rowFont, Brushes.Black, left, y);
                y += 25;

                int count = dgvRentalReport.Columns.Count;

                if (count == 0)
                {
                    e.HasMorePages = false;
                    return;
                }

                float width = (float)e.MarginBounds.Width / count;

                for (int col = 0; col < count; col++)
                {
                    RectangleF rect = new RectangleF(
                        left + col * width, y, width, 32);

                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
                    g.DrawString(dgvRentalReport.Columns[col].HeaderText,
                        headerFont, Brushes.Black, rect);
                }

                y += 32;

                while (printRowIndex < dgvRentalReport.Rows.Count)
                {
                    if (y + 28 > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    DataGridViewRow row = dgvRentalReport.Rows[printRowIndex];

                    if (!row.IsNewRow)
                    {
                        for (int col = 0; col < count; col++)
                        {
                            RectangleF rect = new RectangleF(
                                left + col * width, y, width, 28);

                            g.DrawRectangle(pen, rect.X, rect.Y,
                                rect.Width, rect.Height);

                            string value = row.Cells[col].FormattedValue == null
                                ? ""
                                : row.Cells[col].FormattedValue.ToString();

                            g.DrawString(value, rowFont, Brushes.Black, rect);
                        }

                        y += 28;
                    }

                    printRowIndex++;
                }

                e.HasMorePages = false;
            }
        }

        // BACK TO DASHBOARD
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Size = this.Size;
            form.WindowState = this.WindowState;
            form.Show();
            this.Hide();
        }


        // Keep existing Designer event handlers.
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void pnlReturnSidebar_Paint(object sender, PaintEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void lblFromDate_Click(object sender, EventArgs e) { }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
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

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2Vehicles());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
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

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
