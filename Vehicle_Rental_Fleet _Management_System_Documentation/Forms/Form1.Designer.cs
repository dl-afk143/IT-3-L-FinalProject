namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRecentRentals = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlDashboardSidebar = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.roundedPanel9 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.roundedPanel10 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel7 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.roundedPanel8 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundedPanel5 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.roundedPanel6 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.roundedPanel4 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.roundedPanel2 = new Vehicle_Rental_Fleet__Management_System_Documentation.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblAvailableCount = new System.Windows.Forms.Label();
            this.lblMaintenanceCount = new System.Windows.Forms.Label();
            this.lblRentedCount = new System.Windows.Forms.Label();
            this.lblActiveCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRentals)).BeginInit();
            this.pnlDashboardSidebar.SuspendLayout();
            this.roundedPanel9.SuspendLayout();
            this.roundedPanel10.SuspendLayout();
            this.roundedPanel7.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel6.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvRecentRentals
            // 
            this.dgvRecentRentals.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvRecentRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentRentals.Location = new System.Drawing.Point(250, 355);
            this.dgvRecentRentals.Name = "dgvRecentRentals";
            this.dgvRecentRentals.RowHeadersWidth = 51;
            this.dgvRecentRentals.Size = new System.Drawing.Size(888, 242);
            this.dgvRecentRentals.TabIndex = 12;
            this.dgvRecentRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentRentals_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(254, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Recent Rentals";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(237, 600);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Total Rental Revenue:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(441, 603);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 22);
            this.label15.TabIndex = 15;
            this.label15.Text = "₱125,000.00  ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Location = new System.Drawing.Point(12, 418);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(196, 52);
            this.btnReports.TabIndex = 17;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlDashboardSidebar
            // 
            this.pnlDashboardSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.pnlDashboardSidebar.Controls.Add(this.btnCustomers);
            this.pnlDashboardSidebar.Controls.Add(this.btnLogout);
            this.pnlDashboardSidebar.Controls.Add(this.btnDashboard);
            this.pnlDashboardSidebar.Controls.Add(this.label7);
            this.pnlDashboardSidebar.Controls.Add(this.btnVehicles);
            this.pnlDashboardSidebar.Controls.Add(this.btnReturns);
            this.pnlDashboardSidebar.Controls.Add(this.btnRentals);
            this.pnlDashboardSidebar.Controls.Add(this.btnReports);
            this.pnlDashboardSidebar.Location = new System.Drawing.Point(0, 2);
            this.pnlDashboardSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDashboardSidebar.Name = "pnlDashboardSidebar";
            this.pnlDashboardSidebar.Size = new System.Drawing.Size(220, 672);
            this.pnlDashboardSidebar.TabIndex = 24;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.Location = new System.Drawing.Point(12, 213);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(196, 52);
            this.btnCustomers.TabIndex = 31;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(10, 597);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 55);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Location = new System.Drawing.Point(10, 79);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(196, 52);
            this.btnDashboard.TabIndex = 30;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 64);
            this.label7.TabIndex = 25;
            this.label7.Text = "Vehicle Rental and Fleet Management";
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnVehicles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVehicles.Location = new System.Drawing.Point(12, 146);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(196, 52);
            this.btnVehicles.TabIndex = 29;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnReturns
            // 
            this.btnReturns.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnReturns.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturns.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturns.Location = new System.Drawing.Point(10, 352);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(196, 52);
            this.btnReturns.TabIndex = 28;
            this.btnReturns.Text = "Returns";
            this.btnReturns.UseVisualStyleBackColor = false;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnRentals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentals.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRentals.Location = new System.Drawing.Point(10, 282);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(196, 52);
            this.btnRentals.TabIndex = 27;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.UseVisualStyleBackColor = false;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // roundedPanel9
            // 
            this.roundedPanel9.BackColor = System.Drawing.Color.Pink;
            this.roundedPanel9.BorderRadius = 20;
            this.roundedPanel9.Controls.Add(this.roundedPanel10);
            this.roundedPanel9.Location = new System.Drawing.Point(1058, 115);
            this.roundedPanel9.Name = "roundedPanel9";
            this.roundedPanel9.Size = new System.Drawing.Size(200, 152);
            this.roundedPanel9.TabIndex = 30;
            // 
            // roundedPanel10
            // 
            this.roundedPanel10.BackColor = System.Drawing.SystemColors.Window;
            this.roundedPanel10.BorderRadius = 20;
            this.roundedPanel10.Controls.Add(this.lblActiveCount);
            this.roundedPanel10.Controls.Add(this.label8);
            this.roundedPanel10.Location = new System.Drawing.Point(0, 9);
            this.roundedPanel10.Name = "roundedPanel10";
            this.roundedPanel10.Size = new System.Drawing.Size(200, 143);
            this.roundedPanel10.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Active Vehicle";
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.BackColor = System.Drawing.Color.Red;
            this.roundedPanel7.BorderRadius = 20;
            this.roundedPanel7.Controls.Add(this.roundedPanel8);
            this.roundedPanel7.Location = new System.Drawing.Point(852, 115);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(200, 152);
            this.roundedPanel7.TabIndex = 29;
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.SystemColors.Window;
            this.roundedPanel8.BorderRadius = 20;
            this.roundedPanel8.Controls.Add(this.lblRentedCount);
            this.roundedPanel8.Controls.Add(this.label5);
            this.roundedPanel8.Location = new System.Drawing.Point(0, 9);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(200, 143);
            this.roundedPanel8.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rented Vehicle";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.Yellow;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Controls.Add(this.roundedPanel6);
            this.roundedPanel5.Location = new System.Drawing.Point(637, 115);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(209, 152);
            this.roundedPanel5.TabIndex = 28;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.SystemColors.Window;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.Controls.Add(this.lblMaintenanceCount);
            this.roundedPanel6.Controls.Add(this.label6);
            this.roundedPanel6.Location = new System.Drawing.Point(0, 9);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(209, 143);
            this.roundedPanel6.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(7, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 48);
            this.label6.TabIndex = 31;
            this.label6.Text = "Under Maintenance \r\n           Vehicle";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Green;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Controls.Add(this.roundedPanel4);
            this.roundedPanel3.Location = new System.Drawing.Point(431, 115);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(200, 152);
            this.roundedPanel3.TabIndex = 27;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Controls.Add(this.lblAvailableCount);
            this.roundedPanel4.Controls.Add(this.label4);
            this.roundedPanel4.Location = new System.Drawing.Point(0, 9);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(200, 143);
            this.roundedPanel4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Available Vehicle";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Blue;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Location = new System.Drawing.Point(225, 115);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(200, 152);
            this.roundedPanel1.TabIndex = 25;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.lblTotalCount);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Location = new System.Drawing.Point(0, 9);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(200, 143);
            this.roundedPanel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Vehicle";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(79, 101);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(32, 24);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "24";
            // 
            // lblAvailableCount
            // 
            this.lblAvailableCount.AutoSize = true;
            this.lblAvailableCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCount.Location = new System.Drawing.Point(84, 101);
            this.lblAvailableCount.Name = "lblAvailableCount";
            this.lblAvailableCount.Size = new System.Drawing.Size(32, 24);
            this.lblAvailableCount.TabIndex = 2;
            this.lblAvailableCount.Text = "13";
            // 
            // lblMaintenanceCount
            // 
            this.lblMaintenanceCount.AutoSize = true;
            this.lblMaintenanceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceCount.Location = new System.Drawing.Point(93, 101);
            this.lblMaintenanceCount.Name = "lblMaintenanceCount";
            this.lblMaintenanceCount.Size = new System.Drawing.Size(21, 24);
            this.lblMaintenanceCount.TabIndex = 3;
            this.lblMaintenanceCount.Text = "3";
            // 
            // lblRentedCount
            // 
            this.lblRentedCount.AutoSize = true;
            this.lblRentedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedCount.Location = new System.Drawing.Point(84, 101);
            this.lblRentedCount.Name = "lblRentedCount";
            this.lblRentedCount.Size = new System.Drawing.Size(21, 24);
            this.lblRentedCount.TabIndex = 32;
            this.lblRentedCount.Text = "8";
            // 
            // lblActiveCount
            // 
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCount.Location = new System.Drawing.Point(102, 101);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(21, 24);
            this.lblActiveCount.TabIndex = 33;
            this.lblActiveCount.Text = "8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1286, 665);
            this.Controls.Add(this.roundedPanel9);
            this.Controls.Add(this.roundedPanel7);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pnlDashboardSidebar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvRecentRentals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRentals)).EndInit();
            this.pnlDashboardSidebar.ResumeLayout(false);
            this.roundedPanel9.ResumeLayout(false);
            this.roundedPanel10.ResumeLayout(false);
            this.roundedPanel10.PerformLayout();
            this.roundedPanel7.ResumeLayout(false);
            this.roundedPanel8.ResumeLayout(false);
            this.roundedPanel8.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRecentRentals;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlDashboardSidebar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnRentals;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label3;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel6;
        private RoundedPanel roundedPanel7;
        private RoundedPanel roundedPanel8;
        private RoundedPanel roundedPanel9;
        private RoundedPanel roundedPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.Label lblRentedCount;
        private System.Windows.Forms.Label lblMaintenanceCount;
        private System.Windows.Forms.Label lblAvailableCount;
    }
}

