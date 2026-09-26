namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    partial class Form3RentalManagement
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
            this.pnlRentalDetails = new System.Windows.Forms.Panel();
            this.btnCreateRental = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvActiveRentals = new System.Windows.Forms.DataGridView();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRentalInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pnlRentalInformation = new System.Windows.Forms.Panel();
            this.pnlRentalManagementSidebar = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlRentalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveRentals)).BeginInit();
            this.pnlRentalInformation.SuspendLayout();
            this.pnlRentalManagementSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRentalDetails
            // 
            this.pnlRentalDetails.Controls.Add(this.btnCreateRental);
            this.pnlRentalDetails.Controls.Add(this.textBox2);
            this.pnlRentalDetails.Controls.Add(this.textBox1);
            this.pnlRentalDetails.Controls.Add(this.label7);
            this.pnlRentalDetails.Controls.Add(this.label6);
            this.pnlRentalDetails.Controls.Add(this.label1);
            this.pnlRentalDetails.Location = new System.Drawing.Point(1228, 36);
            this.pnlRentalDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRentalDetails.Name = "pnlRentalDetails";
            this.pnlRentalDetails.Size = new System.Drawing.Size(470, 410);
            this.pnlRentalDetails.TabIndex = 8;
            // 
            // btnCreateRental
            // 
            this.btnCreateRental.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRental.ForeColor = System.Drawing.Color.White;
            this.btnCreateRental.Location = new System.Drawing.Point(40, 304);
            this.btnCreateRental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateRental.Name = "btnCreateRental";
            this.btnCreateRental.Size = new System.Drawing.Size(395, 69);
            this.btnCreateRental.TabIndex = 15;
            this.btnCreateRental.Text = "Create Rental";
            this.btnCreateRental.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 211);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 55);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 55);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(28, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(33, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Daily Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rental Details";
            // 
            // dgvActiveRentals
            // 
            this.dgvActiveRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalID,
            this.CustomerName,
            this.Vehicle,
            this.RentalDate,
            this.ReturnDate,
            this.TotalAmount,
            this.Status});
            this.dgvActiveRentals.Location = new System.Drawing.Point(368, 544);
            this.dgvActiveRentals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvActiveRentals.Name = "dgvActiveRentals";
            this.dgvActiveRentals.RowHeadersWidth = 51;
            this.dgvActiveRentals.RowTemplate.Height = 24;
            this.dgvActiveRentals.Size = new System.Drawing.Size(1331, 360);
            this.dgvActiveRentals.TabIndex = 9;
            // 
            // RentalID
            // 
            this.RentalID.HeaderText = "Rental ID";
            this.RentalID.MinimumWidth = 6;
            this.RentalID.Name = "RentalID";
            this.RentalID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Vehicle";
            this.Vehicle.MinimumWidth = 6;
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Width = 125;
            // 
            // RentalDate
            // 
            this.RentalDate.HeaderText = "Rental Date";
            this.RentalDate.MinimumWidth = 6;
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.Width = 125;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(375, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Active Rentals";
            // 
            // lblRentalInfo
            // 
            this.lblRentalInfo.AutoSize = true;
            this.lblRentalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblRentalInfo.Location = new System.Drawing.Point(20, 44);
            this.lblRentalInfo.Name = "lblRentalInfo";
            this.lblRentalInfo.Size = new System.Drawing.Size(275, 36);
            this.lblRentalInfo.TabIndex = 0;
            this.lblRentalInfo.Text = "Rental Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(62, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(62, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rental Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(62, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vehicle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(62, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Return Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 260);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(520, 37);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2026, 9, 20, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Location = new System.Drawing.Point(237, 129);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(520, 36);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 30;
            this.comboBox2.Location = new System.Drawing.Point(237, 194);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(520, 36);
            this.comboBox2.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(237, 319);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(520, 37);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2026, 9, 20, 0, 0, 0, 0);
            // 
            // pnlRentalInformation
            // 
            this.pnlRentalInformation.Controls.Add(this.dateTimePicker2);
            this.pnlRentalInformation.Controls.Add(this.comboBox2);
            this.pnlRentalInformation.Controls.Add(this.comboBox1);
            this.pnlRentalInformation.Controls.Add(this.dateTimePicker1);
            this.pnlRentalInformation.Controls.Add(this.label5);
            this.pnlRentalInformation.Controls.Add(this.label4);
            this.pnlRentalInformation.Controls.Add(this.label3);
            this.pnlRentalInformation.Controls.Add(this.label2);
            this.pnlRentalInformation.Controls.Add(this.lblRentalInfo);
            this.pnlRentalInformation.Location = new System.Drawing.Point(368, 36);
            this.pnlRentalInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRentalInformation.Name = "pnlRentalInformation";
            this.pnlRentalInformation.Size = new System.Drawing.Size(794, 410);
            this.pnlRentalInformation.TabIndex = 7;
            this.pnlRentalInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRentalInformation_Paint);
            // 
            // pnlRentalManagementSidebar
            // 
            this.pnlRentalManagementSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.pnlRentalManagementSidebar.Controls.Add(this.btnCustomers);
            this.pnlRentalManagementSidebar.Controls.Add(this.btnLogout);
            this.pnlRentalManagementSidebar.Controls.Add(this.btnDashboard);
            this.pnlRentalManagementSidebar.Controls.Add(this.label9);
            this.pnlRentalManagementSidebar.Controls.Add(this.btnVehicles);
            this.pnlRentalManagementSidebar.Controls.Add(this.btnReturns);
            this.pnlRentalManagementSidebar.Controls.Add(this.btnRentals);
            this.pnlRentalManagementSidebar.Controls.Add(this.btnReports);
            this.pnlRentalManagementSidebar.Location = new System.Drawing.Point(1, -1);
            this.pnlRentalManagementSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRentalManagementSidebar.Name = "pnlRentalManagementSidebar";
            this.pnlRentalManagementSidebar.Size = new System.Drawing.Size(330, 1010);
            this.pnlRentalManagementSidebar.TabIndex = 26;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.Location = new System.Drawing.Point(18, 328);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(294, 80);
            this.btnCustomers.TabIndex = 31;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(15, 899);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(294, 80);
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
            this.btnDashboard.Location = new System.Drawing.Point(15, 121);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(294, 80);
            this.btnDashboard.TabIndex = 30;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 99);
            this.label9.TabIndex = 25;
            this.label9.Text = "Vehicle Rental and Fleet Management";
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnVehicles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVehicles.Location = new System.Drawing.Point(18, 225);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(294, 80);
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
            this.btnReturns.Location = new System.Drawing.Point(15, 541);
            this.btnReturns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(294, 80);
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
            this.btnRentals.Location = new System.Drawing.Point(15, 434);
            this.btnRentals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(294, 80);
            this.btnRentals.TabIndex = 27;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.UseVisualStyleBackColor = false;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReports.Location = new System.Drawing.Point(18, 642);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(294, 80);
            this.btnReports.TabIndex = 17;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // Form3RentalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 1022);
            this.Controls.Add(this.pnlRentalManagementSidebar);
            this.Controls.Add(this.pnlRentalInformation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvActiveRentals);
            this.Controls.Add(this.pnlRentalDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3RentalManagement";
            this.Text = "Form3RentalManagement";
            this.Load += new System.EventHandler(this.Form3RentalManagement_Load);
            this.pnlRentalDetails.ResumeLayout(false);
            this.pnlRentalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveRentals)).EndInit();
            this.pnlRentalInformation.ResumeLayout(false);
            this.pnlRentalInformation.PerformLayout();
            this.pnlRentalManagementSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlRentalDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateRental;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvActiveRentals;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRentalInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel pnlRentalInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel pnlRentalManagementSidebar;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnReports;
    }
}