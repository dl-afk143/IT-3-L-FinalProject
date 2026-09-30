namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    partial class Form5Reports
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
            this.pnlReturnSidebar = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.grpReportInformation = new System.Windows.Forms.GroupBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpReportResults = new System.Windows.Forms.GroupBox();
            this.dgvReportResults = new System.Windows.Forms.DataGridView();
            this.colRentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReturnSidebar.SuspendLayout();
            this.grpReportInformation.SuspendLayout();
            this.grpReportResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReturnSidebar
            // 
            this.pnlReturnSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.pnlReturnSidebar.Controls.Add(this.btnCustomers);
            this.pnlReturnSidebar.Controls.Add(this.btnLogout);
            this.pnlReturnSidebar.Controls.Add(this.btnDashboard);
            this.pnlReturnSidebar.Controls.Add(this.label11);
            this.pnlReturnSidebar.Controls.Add(this.btnVehicles);
            this.pnlReturnSidebar.Controls.Add(this.btnReturns);
            this.pnlReturnSidebar.Controls.Add(this.btnRentals);
            this.pnlReturnSidebar.Controls.Add(this.btnReports);
            this.pnlReturnSidebar.Location = new System.Drawing.Point(1, -2);
            this.pnlReturnSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReturnSidebar.Name = "pnlReturnSidebar";
            this.pnlReturnSidebar.Size = new System.Drawing.Size(220, 656);
            this.pnlReturnSidebar.TabIndex = 28;
            this.pnlReturnSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReturnSidebar_Paint);
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
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(10, 584);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 52);
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
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 64);
            this.label11.TabIndex = 25;
            this.label11.Text = "Vehicle Rental and Fleet Management";
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
            // 
            // grpReportInformation
            // 
            this.grpReportInformation.BackColor = System.Drawing.Color.Transparent;
            this.grpReportInformation.Controls.Add(this.btnGenerate);
            this.grpReportInformation.Controls.Add(this.dateTimePicker1);
            this.grpReportInformation.Controls.Add(this.lblToDate);
            this.grpReportInformation.Controls.Add(this.dtpFromDate);
            this.grpReportInformation.Controls.Add(this.lblFromDate);
            this.grpReportInformation.Controls.Add(this.cmbReportType);
            this.grpReportInformation.Controls.Add(this.lblReportType);
            this.grpReportInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportInformation.ForeColor = System.Drawing.Color.Navy;
            this.grpReportInformation.Location = new System.Drawing.Point(254, 12);
            this.grpReportInformation.Name = "grpReportInformation";
            this.grpReportInformation.Size = new System.Drawing.Size(534, 308);
            this.grpReportInformation.TabIndex = 29;
            this.grpReportInformation.TabStop = false;
            this.grpReportInformation.Text = "Report Information";
            this.grpReportInformation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblReportType
            // 
            this.lblReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(6, 53);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(135, 30);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Rental History",
            "Vehicle Status",
            "Customer Records",
            "Returned Vehicles"});
            this.cmbReportType.Location = new System.Drawing.Point(126, 53);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(340, 26);
            this.cmbReportType.TabIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(21, 103);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(99, 20);
            this.lblFromDate.TabIndex = 2;
            this.lblFromDate.Text = "From Date:";
            this.lblFromDate.Click += new System.EventHandler(this.lblFromDate_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(126, 103);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(340, 29);
            this.dtpFromDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(42, 164);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(78, 20);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "To Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 29);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(145)))), ((int)(((byte)(225)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(25, 231);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(496, 50);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // grpReportResults
            // 
            this.grpReportResults.Controls.Add(this.dgvReportResults);
            this.grpReportResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportResults.ForeColor = System.Drawing.Color.Navy;
            this.grpReportResults.Location = new System.Drawing.Point(243, 338);
            this.grpReportResults.Name = "grpReportResults";
            this.grpReportResults.Size = new System.Drawing.Size(900, 296);
            this.grpReportResults.TabIndex = 30;
            this.grpReportResults.TabStop = false;
            this.grpReportResults.Text = "Report Results";
            // 
            // dgvReportResults
            // 
            this.dgvReportResults.AllowUserToDeleteRows = false;
            this.dgvReportResults.AllowUserToResizeColumns = false;
            this.dgvReportResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportResults.ColumnHeadersHeight = 35;
            this.dgvReportResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRentalID,
            this.colCustomer,
            this.colVehicle,
            this.colRentalDate,
            this.colReturnDate,
            this.colTotalAmount,
            this.colStatus});
            this.dgvReportResults.Location = new System.Drawing.Point(0, 22);
            this.dgvReportResults.Name = "dgvReportResults";
            this.dgvReportResults.ReadOnly = true;
            this.dgvReportResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportResults.Size = new System.Drawing.Size(900, 268);
            this.dgvReportResults.TabIndex = 0;
            // 
            // colRentalID
            // 
            this.colRentalID.HeaderText = "Rental ID";
            this.colRentalID.Name = "colRentalID";
            this.colRentalID.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colVehicle
            // 
            this.colVehicle.HeaderText = "Vehicle";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.ReadOnly = true;
            // 
            // colRentalDate
            // 
            this.colRentalDate.HeaderText = "Rental Date";
            this.colRentalDate.Name = "colRentalDate";
            this.colRentalDate.ReadOnly = true;
            // 
            // colReturnDate
            // 
            this.colReturnDate.HeaderText = "Return Date";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "Total Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // Form5Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 665);
            this.Controls.Add(this.grpReportResults);
            this.Controls.Add(this.grpReportInformation);
            this.Controls.Add(this.pnlReturnSidebar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5Reports";
            this.pnlReturnSidebar.ResumeLayout(false);
            this.grpReportInformation.ResumeLayout(false);
            this.grpReportInformation.PerformLayout();
            this.grpReportResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlReturnSidebar;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.GroupBox grpReportInformation;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.GroupBox grpReportResults;
        private System.Windows.Forms.DataGridView dgvReportResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}