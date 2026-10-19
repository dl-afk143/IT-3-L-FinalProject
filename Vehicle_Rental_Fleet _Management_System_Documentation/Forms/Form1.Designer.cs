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
            this.Rental_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rental_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlDashboardSidebar = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRentedCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaintenanceCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvailableCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRentals)).BeginInit();
            this.pnlDashboardSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(773, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvRecentRentals
            // 
            this.dgvRecentRentals.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvRecentRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rental_ID,
            this.Customer_name,
            this.Vehicle,
            this.Rental_Date,
            this.Status});
            this.dgvRecentRentals.Location = new System.Drawing.Point(333, 437);
            this.dgvRecentRentals.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecentRentals.Name = "dgvRecentRentals";
            this.dgvRecentRentals.RowHeadersWidth = 51;
            this.dgvRecentRentals.Size = new System.Drawing.Size(1311, 298);
            this.dgvRecentRentals.TabIndex = 12;
            this.dgvRecentRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentRentals_CellContentClick);
            // 
            // Rental_ID
            // 
            this.Rental_ID.HeaderText = "Rental ID";
            this.Rental_ID.MinimumWidth = 6;
            this.Rental_ID.Name = "Rental_ID";
            this.Rental_ID.Width = 125;
            // 
            // Customer_name
            // 
            this.Customer_name.HeaderText = "Customer Name";
            this.Customer_name.MinimumWidth = 6;
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.Width = 125;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Vehicle";
            this.Vehicle.MinimumWidth = 6;
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Width = 125;
            // 
            // Rental_Date
            // 
            this.Rental_Date.HeaderText = "Rental Date";
            this.Rental_Date.MinimumWidth = 6;
            this.Rental_Date.Name = "Rental_Date";
            this.Rental_Date.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(339, 398);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Recent Rentals";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(327, 753);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 29);
            this.label14.TabIndex = 14;
            this.label14.Text = "Total Rental Revenue:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(608, 758);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 26);
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
            this.btnReports.Location = new System.Drawing.Point(91, 650);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(149, 48);
            this.btnReports.TabIndex = 17;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlDashboardSidebar
            // 
            this.pnlDashboardSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox7);
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox6);
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox5);
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox4);
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox3);
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox2);
            this.pnlDashboardSidebar.Controls.Add(this.pictureBox1);
            this.pnlDashboardSidebar.Controls.Add(this.label9);
            this.pnlDashboardSidebar.Controls.Add(this.btnCustomers);
            this.pnlDashboardSidebar.Controls.Add(this.btnLogout);
            this.pnlDashboardSidebar.Controls.Add(this.btnDashboard);
            this.pnlDashboardSidebar.Controls.Add(this.label7);
            this.pnlDashboardSidebar.Controls.Add(this.btnVehicles);
            this.pnlDashboardSidebar.Controls.Add(this.btnReturns);
            this.pnlDashboardSidebar.Controls.Add(this.btnRentals);
            this.pnlDashboardSidebar.Controls.Add(this.btnReports);
            this.pnlDashboardSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDashboardSidebar.Name = "pnlDashboardSidebar";
            this.pnlDashboardSidebar.Size = new System.Drawing.Size(293, 827);
            this.pnlDashboardSidebar.TabIndex = 24;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.streamline_flex__investing_and_banking_white;
            this.pictureBox7.Location = new System.Drawing.Point(27, 650);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(56, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.oui__nav_reports_white;
            this.pictureBox6.Location = new System.Drawing.Point(27, 550);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.guidance__car_rental_white;
            this.pictureBox5.Location = new System.Drawing.Point(27, 448);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.glyphs__users_1_white;
            this.pictureBox4.Location = new System.Drawing.Point(27, 348);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.bi__house_white;
            this.pictureBox3.Location = new System.Drawing.Point(27, 164);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.ant_design__car_filled_white;
            this.pictureBox2.Location = new System.Drawing.Point(27, 251);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Vehicle_Rental_Fleet__Management_System_Documentation.Properties.Resources.logo_navy;
            this.pictureBox1.Location = new System.Drawing.Point(19, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(96, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Vehicles Rental";
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.Location = new System.Drawing.Point(91, 348);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(149, 48);
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
            this.btnLogout.Location = new System.Drawing.Point(16, 805);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(261, 68);
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
            this.btnDashboard.Location = new System.Drawing.Point(91, 164);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(149, 48);
            this.btnDashboard.TabIndex = 30;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 46);
            this.label7.TabIndex = 25;
            this.label7.Text = "Broom";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnVehicles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVehicles.Location = new System.Drawing.Point(91, 251);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(149, 48);
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
            this.btnReturns.Location = new System.Drawing.Point(91, 550);
            this.btnReturns.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(149, 48);
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
            this.btnRentals.Location = new System.Drawing.Point(91, 448);
            this.btnRentals.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(149, 48);
            this.btnRentals.TabIndex = 27;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.UseVisualStyleBackColor = false;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1715, 818);
            this.Controls.Add(this.pnlDashboardSidebar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvRecentRentals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRentals)).EndInit();
            this.pnlDashboardSidebar.ResumeLayout(false);
            this.pnlDashboardSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rental_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rental_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

