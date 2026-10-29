        using System;
        using System.Data;
        using System.Drawing;
        using System.Drawing.Drawing2D;
        using System.Windows.Forms;
        using MySql.Data.MySqlClient;
        using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

        namespace Vehicle_Rental_Fleet__Management_System_Documentation
        {
            public partial class CustomerManagementForm : Form
            {
                
                private readonly string connectionString =
                    "Server=localhost;Port=3306;" + 
                    "Database=vehiclerentaldb;" +
                    "Uid=rental_app;Pwd=dl4321;";

                public CustomerManagementForm()
                {
                    InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;


            // SIDEBAR BUTTON EVENTS
            btnDashboard.Click -= btnDashboard_Click;
                    btnDashboard.Click += btnDashboard_Click;

                    btnVehicles.Click -= btnVehicles_Click;
                    btnVehicles.Click += btnVehicles_Click;

                    btnRentals.Click -= btnRentals_Click;
                    btnRentals.Click += btnRentals_Click;

                    button1.Click -= button1_Click;
                    button1.Click += button1_Click;
            //btnReturns.Click -= btnReturns_Click;
            //btnReturns.Click += btnReturns_Click;

            btnReports.Click -= btnReports_Click;
                    btnReports.Click += btnReports_Click;

                    btnCustomers.Click -= btnCustomers_Click;
                    btnCustomers.Click += btnCustomers_Click;

                    // CUSTOMER ACTION BUTTON EVENTS
                    // Assumes the Add button's control name is btnCustomer.
                    btnAddCustomer.Click -= btnAddCustomer_Click;
                    btnAddCustomer.Click += btnAddCustomer_Click;

                    btnUpdateCustomer.Click -= btnUpdateCustomer_Click;
                    btnUpdateCustomer.Click += btnUpdateCustomer_Click;

                    btnDeactivateCustomer.Click -= btnDeleteCustomer_Click;
                    btnDeactivateCustomer.Click += btnDeleteCustomer_Click;

                    btnClearCustomer.Click -= btnClear_Click;
                    btnClearCustomer.Click += btnClear_Click;
                }

                // =========================
                // DATAGRIDVIEW DESIGN
                // =========================
                private void StyleCustomerDataGridView()
                {
                    dgvCustomerList.SuspendLayout();

                    dgvCustomerList.BorderStyle = BorderStyle.None;
                    dgvCustomerList.BackgroundColor = Color.White;
                    dgvCustomerList.GridColor = Color.FromArgb(225, 232, 242);
                    dgvCustomerList.EnableHeadersVisualStyles = false;
                    dgvCustomerList.RowHeadersVisible = false;
                    dgvCustomerList.AllowUserToAddRows = false;
                    dgvCustomerList.AllowUserToResizeRows = false;
                    dgvCustomerList.ReadOnly = true;
                    dgvCustomerList.MultiSelect = false;
                    dgvCustomerList.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dgvCustomerList.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCustomerList.AutoSizeRowsMode =
                        DataGridViewAutoSizeRowsMode.None;
                    dgvCustomerList.ScrollBars = ScrollBars.Both;

                    dgvCustomerList.ColumnHeadersHeight = 42;
                    dgvCustomerList.ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                    dgvCustomerList.ColumnHeadersDefaultCellStyle.BackColor =
                        Color.FromArgb(239, 243, 249);
                    dgvCustomerList.ColumnHeadersDefaultCellStyle.ForeColor =
                        Color.FromArgb(51, 67, 93);
                    dgvCustomerList.ColumnHeadersDefaultCellStyle.Font =
                        new Font("Segoe UI", 9F, FontStyle.Bold);
                    dgvCustomerList.ColumnHeadersDefaultCellStyle.Padding =
                        new Padding(10, 0, 5, 0);
                    dgvCustomerList.ColumnHeadersDefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleLeft;
                    dgvCustomerList.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                        Color.FromArgb(239, 243, 249);
                    dgvCustomerList.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                        Color.FromArgb(51, 67, 93);

                    dgvCustomerList.DefaultCellStyle.BackColor = Color.White;
                    dgvCustomerList.DefaultCellStyle.ForeColor =
                        Color.FromArgb(31, 48, 75);
                    dgvCustomerList.DefaultCellStyle.Font =
                        new Font("Segoe UI", 9.5F, FontStyle.Regular);
                    dgvCustomerList.DefaultCellStyle.Padding =
                        new Padding(10, 3, 5, 3);
                    dgvCustomerList.DefaultCellStyle.SelectionBackColor =
                        Color.FromArgb(228, 238, 251);
                    dgvCustomerList.DefaultCellStyle.SelectionForeColor =
                        Color.FromArgb(31, 48, 75);

                    dgvCustomerList.AlternatingRowsDefaultCellStyle.BackColor =
                        Color.FromArgb(228, 238, 251);
                    dgvCustomerList.AlternatingRowsDefaultCellStyle.ForeColor =
                        Color.FromArgb(31, 48, 75);
                    dgvCustomerList.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                        Color.FromArgb(215, 229, 248);
                    dgvCustomerList.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                        Color.FromArgb(31, 48, 75);

                    dgvCustomerList.RowTemplate.Height = 44;
                    dgvCustomerList.CellBorderStyle =
                        DataGridViewCellBorderStyle.SingleHorizontal;
                    dgvCustomerList.ColumnHeadersBorderStyle =
                        DataGridViewHeaderBorderStyle.Single;

                    SetCustomerColumnWidth("ID", 6);
                    SetCustomerColumnWidth("Full Name", 17);
                    SetCustomerColumnWidth("Contact", 13);
                    SetCustomerColumnWidth("License No.", 14);
                    SetCustomerColumnWidth("Address", 21);
                    SetCustomerColumnWidth("Status", 10);
                    SetCustomerColumnWidth("Registered", 14);

                    dgvCustomerList.CellPainting -= dgvRecentRentals_CellPainting;
                    dgvCustomerList.CellPainting += dgvRecentRentals_CellPainting;

                    dgvCustomerList.ResumeLayout();
                }

                private void SetCustomerColumnWidth(string headerName, float fillWeight)
                {
                    foreach (DataGridViewColumn column in dgvCustomerList.Columns)
                    {
                        if (string.Equals(
                            column.HeaderText.Trim(),
                            headerName,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            column.FillWeight = fillWeight;
                            break;
                        }
                    }
                }

                // =========================
                // STATUS BADGES
                // =========================
                private void dgvRecentRentals_CellPainting(
                    object sender, DataGridViewCellPaintingEventArgs e)
                {
                    if (e.RowIndex < 0 || e.ColumnIndex < 0)
                        return;

                    DataGridViewColumn column =
                        dgvCustomerList.Columns[e.ColumnIndex];

                    if (!column.HeaderText.Trim().Equals(
                        "Status", StringComparison.OrdinalIgnoreCase))
                        return;

                    if (e.Value == null)
                        return;

                    string status = e.Value.ToString().Trim();

                    Color backColor;
                    Color foreColor;

                    if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        backColor = Color.FromArgb(220, 243, 227);
                        foreColor = Color.FromArgb(28, 119, 61);
                    }
                    else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        backColor = Color.FromArgb(230, 234, 241);
                        foreColor = Color.FromArgb(78, 88, 105);
                    }
                    else
                    {
                        return;
                    }

                    e.PaintBackground(e.CellBounds, true);

                    using (Font font = new Font("Segoe UI", 8F, FontStyle.Bold))
                    using (SolidBrush backBrush = new SolidBrush(backColor))
                    using (SolidBrush foreBrush = new SolidBrush(foreColor))
                    using (GraphicsPath path = new GraphicsPath())
                    using (StringFormat format = new StringFormat())
                    {
                        Graphics g = e.Graphics;
                        g.SmoothingMode = SmoothingMode.AntiAlias;

                        SizeF textSize = g.MeasureString(status, font);
                        int badgeWidth = (int)Math.Ceiling(textSize.Width) + 18;
                        int badgeHeight = 20;

                        badgeWidth = Math.Min(
                            badgeWidth,
                            Math.Max(1, e.CellBounds.Width - 8));

                        Rectangle badge = new Rectangle(
                            e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2,
                            e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2,
                            badgeWidth,
                            badgeHeight);

                        int radius = Math.Min(badgeHeight / 2, badgeWidth / 2);

                        path.AddArc(
                            badge.X, badge.Y, radius * 2, badge.Height, 90, 180);
                        path.AddArc(
                            badge.Right - radius * 2, badge.Y,
                            radius * 2, badge.Height, 270, 180);
                        path.CloseFigure();

                        g.FillPath(backBrush, path);

                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        g.DrawString(status, font, foreBrush, badge, format);
                    }

                    e.Handled = true;
                }

                // =========================
                // FORM NAVIGATION
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

                private void btnDashboard_Click(object sender, EventArgs e)
                {
                    OpenForm(new Form1());
                }

                private void btnVehicles_Click(object sender, EventArgs e)
                {
                    OpenForm(new Form2Vehicles());
                }

                private void btnCustomers_Click(object sender, EventArgs e)
                {
                    this.Show();
                    this.Activate();
                }

                private void btnRentals_Click(object sender, EventArgs e)
                {
                    OpenForm(new Form3RentalManagement());
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
        


        private void btnReports_Click(object sender, EventArgs e)
                {
                    OpenForm(new Form5Reports());
                }

                // =========================
                // ADD CUSTOMER
                // =========================
                private void btnAddCustomer_Click(object sender, EventArgs e)
                {
                    string customerID = tbCustomerID.Text.Trim();
                    string fullName = tbFullName.Text.Trim();
                    string contactNumber = tbContactNumber.Text.Trim();
                    string address = tbAddress.Text.Trim();

                    if (string.IsNullOrWhiteSpace(customerID) ||
                        string.IsNullOrWhiteSpace(fullName) ||
                        string.IsNullOrWhiteSpace(contactNumber) ||
                        string.IsNullOrWhiteSpace(address))
                    {
                        MessageBox.Show(
                            "Please fill in Customer ID, Full Name, Contact Number, and Address.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        using (MySqlConnection conn =
                            new MySqlConnection(connectionString))
                        {
                            string query = @"
                                INSERT INTO customers
                                    (customer_id, full_name, contact_number,
                                     license_no, address, created_at, status)
                                VALUES
                                    (@id, @name, @contact, @address, @license_no,
                                     NOW(), 'Active');";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", customerID);
                                cmd.Parameters.AddWithValue("@name", fullName);
                                cmd.Parameters.AddWithValue("@contact", contactNumber);
                                cmd.Parameters.AddWithValue("@license_no", tbDriverLicense.Text.Trim());
                                cmd.Parameters.AddWithValue("@address", address);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        LoadCustomers();

                        MessageBox.Show(
                            "Customer added successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        ClearCustomerFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Failed to add customer:\n" + ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // =========================
                // UPDATE CUSTOMER
                // =========================
                private void btnUpdateCustomer_Click(object sender, EventArgs e)
                {
                    string customerID = tbCustomerID.Text.Trim();
                    string fullName = tbFullName.Text.Trim();
                    string contactNumber = tbContactNumber.Text.Trim();
                    string address = tbAddress.Text.Trim();

                    if (string.IsNullOrWhiteSpace(customerID) ||
                        string.IsNullOrWhiteSpace(fullName) ||
                        string.IsNullOrWhiteSpace(contactNumber) ||
                        string.IsNullOrWhiteSpace(address))
                    {
                        MessageBox.Show(
                            "Please fill in all customer fields.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        using (MySqlConnection conn =
                            new MySqlConnection(connectionString))
                        {
                            string query = @"
                                UPDATE customers
                                SET full_name = @name,
                                    contact_number = @contact,
                                    address = @address
                                WHERE customer_id = @id
                                  AND status = 'Active';";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", customerID);
                                cmd.Parameters.AddWithValue("@name", fullName);
                                cmd.Parameters.AddWithValue("@contact", contactNumber);
                                cmd.Parameters.AddWithValue("@address", address);

                                conn.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer updated successfully!");
                                    LoadCustomers();
                                    ClearCustomerFields();
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "No active customer found with that Customer ID.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Failed to update customer:\n" + ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // =========================
                // DEACTIVATE CUSTOMER
                // =========================
                private void btnDeleteCustomer_Click(object sender, EventArgs e)
                {
                    string customerID = tbCustomerID.Text.Trim();

                    if (string.IsNullOrWhiteSpace(customerID))
                    {
                        MessageBox.Show("Please enter a Customer ID.");
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to deactivate this customer?",
                        "Deactivate Customer",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                        return;

                    try
                    {
                        using (MySqlConnection conn =
                            new MySqlConnection(connectionString))
                        {
                            string query = @"
                                UPDATE customers
                                SET status = 'Inactive'
                                WHERE customer_id = @id
                                  AND status = 'Active';";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", customerID);

                                conn.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer deactivated successfully!");
                                    LoadCustomers();
                                    ClearCustomerFields();
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "No active customer found with that Customer ID.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Failed to deactivate customer:\n" + ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // =========================
                // CLEAR CUSTOMER FIELDS
                // =========================
                private void btnClear_Click(object sender, EventArgs e)
                {
                    ClearCustomerFields();
                }

                private void ClearCustomerFields()
                {
                    tbCustomerID.Clear();
                    tbFullName.Clear();
                    tbContactNumber.Clear();
                    tbAddress.Clear();
                    tbEmail.Clear();
                }

                // =========================
                // LOAD CUSTOMERS
                // =========================
                private void CustomerManagementForm_Load(object sender, EventArgs e)
                {
                    LoadCustomers();
                }

                private void LoadCustomers()
                {
                    try
                    {
                        using (MySqlConnection conn =
                            new MySqlConnection(connectionString))
                        {
                            string query = @"
                                SELECT
                                    customer_id AS 'ID',
                                    full_name AS 'Full Name',
                                    contact_number AS 'Contact',
                                    license_no AS 'License No.',
                                    address AS 'Address',
                                    status AS 'Status',
                                    created_at AS 'Registered'
                                FROM customers
                                ORDER BY customer_id;";

                            using (MySqlDataAdapter adapter =
                                new MySqlDataAdapter(query, conn))
                            {
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                                dgvCustomerList.DataSource = null;
                                dgvCustomerList.Columns.Clear();
                                dgvCustomerList.AutoGenerateColumns = true;
                                dgvCustomerList.DataSource = table;
                    }
                        }

                        StyleCustomerDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error loading customers:\n" + ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // Keep these methods if your Designer references them.
                private void label3_Click(object sender, EventArgs e)
                {
                }

                private void dgvRecentRentals_CellContentClick(
                    object sender, DataGridViewCellEventArgs e)
                {
                }
            }
        }