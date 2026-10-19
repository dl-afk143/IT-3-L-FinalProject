namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    partial class CustomerManagementForm
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
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDateCreated = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLicenseNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnReports = new System.Windows.Forms.Button();
            this.dgvCustomerManagement = new System.Windows.Forms.DataGridView();
            this.VehicleCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleLicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlDashboardSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.btnClearCustomer);
            this.grbActions.Controls.Add(this.btnDeleteCustomer);
            this.grbActions.Controls.Add(this.btnUpdateCustomer);
            this.grbActions.Controls.Add(this.btnAddCustomer);
            this.grbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbActions.Location = new System.Drawing.Point(1125, 39);
            this.grbActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbActions.Name = "grbActions";
            this.grbActions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbActions.Size = new System.Drawing.Size(339, 435);
            this.grbActions.TabIndex = 29;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Actions";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCustomer.Location = new System.Drawing.Point(35, 302);
            this.btnClearCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(264, 69);
            this.btnClearCustomer.TabIndex = 3;
            this.btnClearCustomer.Text = "Clear";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(35, 224);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(264, 69);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(35, 145);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(264, 69);
            this.btnUpdateCustomer.TabIndex = 1;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(35, 65);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(264, 69);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Customer ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDateCreated);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbLicenseNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbContactNumber);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.tbCustomerID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(371, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(729, 435);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // tbDateCreated
            // 
            this.tbDateCreated.Location = new System.Drawing.Point(252, 374);
            this.tbDateCreated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateCreated.Multiline = true;
            this.tbDateCreated.Name = "tbDateCreated";
            this.tbDateCreated.ReadOnly = true;
            this.tbDateCreated.Size = new System.Drawing.Size(396, 35);
            this.tbDateCreated.TabIndex = 45;
            this.tbDateCreated.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(71, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(71, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(252, 215);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(396, 35);
            this.tbEmail.TabIndex = 42;
            // 
            // tbLicenseNumber
            // 
            this.tbLicenseNumber.Location = new System.Drawing.Point(252, 260);
            this.tbLicenseNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLicenseNumber.Multiline = true;
            this.tbLicenseNumber.Name = "tbLicenseNumber";
            this.tbLicenseNumber.Size = new System.Drawing.Size(396, 35);
            this.tbLicenseNumber.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(70, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "License Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(71, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Last Name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(252, 127);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(396, 35);
            this.tbLastName.TabIndex = 38;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(252, 306);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(396, 54);
            this.tbAddress.TabIndex = 37;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(252, 172);
            this.tbContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContactNumber.Multiline = true;
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(396, 35);
            this.tbContactNumber.TabIndex = 36;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(252, 81);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(396, 35);
            this.tbFirstName.TabIndex = 35;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(252, 38);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerID.Multiline = true;
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.ReadOnly = true;
            this.tbCustomerID.Size = new System.Drawing.Size(396, 35);
            this.tbCustomerID.TabIndex = 34;
            this.tbCustomerID.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(71, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(71, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(71, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "First Name:";
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
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
            this.pnlDashboardSidebar.TabIndex = 33;
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
            // 
            // dgvCustomerManagement
            // 
            this.dgvCustomerManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleCustomerID,
            this.VehicleFirstName,
            this.VehicleLastName,
            this.VehicleContactNumber,
            this.VehicleEmail,
            this.VehicleLicenseNumber,
            this.VehicleAddress,
            this.VehicleDateCreated});
            this.dgvCustomerManagement.Location = new System.Drawing.Point(372, 520);
            this.dgvCustomerManagement.Name = "dgvCustomerManagement";
            this.dgvCustomerManagement.RowHeadersWidth = 51;
            this.dgvCustomerManagement.RowTemplate.Height = 24;
            this.dgvCustomerManagement.Size = new System.Drawing.Size(1092, 285);
            this.dgvCustomerManagement.TabIndex = 34;
            this.dgvCustomerManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerManagement_CellClick);
            // 
            // VehicleCustomerID
            // 
            this.VehicleCustomerID.HeaderText = "Customer ID";
            this.VehicleCustomerID.MinimumWidth = 6;
            this.VehicleCustomerID.Name = "VehicleCustomerID";
            this.VehicleCustomerID.Width = 125;
            // 
            // VehicleFirstName
            // 
            this.VehicleFirstName.HeaderText = "FirstName";
            this.VehicleFirstName.MinimumWidth = 6;
            this.VehicleFirstName.Name = "VehicleFirstName";
            this.VehicleFirstName.Width = 125;
            // 
            // VehicleLastName
            // 
            this.VehicleLastName.HeaderText = "Last Name";
            this.VehicleLastName.MinimumWidth = 6;
            this.VehicleLastName.Name = "VehicleLastName";
            this.VehicleLastName.Width = 125;
            // 
            // VehicleContactNumber
            // 
            this.VehicleContactNumber.HeaderText = "Contact Number";
            this.VehicleContactNumber.MinimumWidth = 6;
            this.VehicleContactNumber.Name = "VehicleContactNumber";
            this.VehicleContactNumber.Width = 125;
            // 
            // VehicleEmail
            // 
            this.VehicleEmail.HeaderText = "Email";
            this.VehicleEmail.MinimumWidth = 6;
            this.VehicleEmail.Name = "VehicleEmail";
            this.VehicleEmail.Width = 125;
            // 
            // VehicleLicenseNumber
            // 
            this.VehicleLicenseNumber.HeaderText = "License Number";
            this.VehicleLicenseNumber.MinimumWidth = 6;
            this.VehicleLicenseNumber.Name = "VehicleLicenseNumber";
            this.VehicleLicenseNumber.Width = 125;
            // 
            // VehicleAddress
            // 
            this.VehicleAddress.HeaderText = "Address";
            this.VehicleAddress.MinimumWidth = 6;
            this.VehicleAddress.Name = "VehicleAddress";
            this.VehicleAddress.Width = 125;
            // 
            // VehicleDateCreated
            // 
            this.VehicleDateCreated.HeaderText = "Date Created";
            this.VehicleDateCreated.MinimumWidth = 6;
            this.VehicleDateCreated.Name = "VehicleDateCreated";
            this.VehicleDateCreated.Width = 125;
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 818);
            this.Controls.Add(this.dgvCustomerManagement);
            this.Controls.Add(this.pnlDashboardSidebar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbActions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagementForm";
            this.Load += new System.EventHandler(this.CustomerManagementForm_Load);
            this.grbActions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDashboardSidebar.ResumeLayout(false);
            this.pnlDashboardSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Panel pnlDashboardSidebar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLicenseNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDateCreated;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCustomerManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleLicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleDateCreated;
    }
}