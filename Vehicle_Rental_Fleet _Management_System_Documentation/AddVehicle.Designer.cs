namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    partial class AddVehicle
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
            this.lblVehicleBrand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVehicleBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlateNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVehicleModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYearModel = new System.Windows.Forms.TextBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.tbDailyRate = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Vehicle";
            // 
            // lblVehicleBrand
            // 
            this.lblVehicleBrand.AutoSize = true;
            this.lblVehicleBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleBrand.ForeColor = System.Drawing.Color.Navy;
            this.lblVehicleBrand.Location = new System.Drawing.Point(104, 198);
            this.lblVehicleBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleBrand.Name = "lblVehicleBrand";
            this.lblVehicleBrand.Size = new System.Drawing.Size(210, 36);
            this.lblVehicleBrand.TabIndex = 1;
            this.lblVehicleBrand.Text = "Vehicle Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(104, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Type:";
            // 
            // tbVehicleBrand
            // 
            this.tbVehicleBrand.Location = new System.Drawing.Point(327, 198);
            this.tbVehicleBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVehicleBrand.Multiline = true;
            this.tbVehicleBrand.Name = "tbVehicleBrand";
            this.tbVehicleBrand.Size = new System.Drawing.Size(397, 38);
            this.tbVehicleBrand.TabIndex = 4;
            this.tbVehicleBrand.TextChanged += new System.EventHandler(this.tbVehicleBrand_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(104, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Plate Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(104, 534);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Daily Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(104, 598);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status:";
            // 
            // tbPlateNumber
            // 
            this.tbPlateNumber.Location = new System.Drawing.Point(327, 459);
            this.tbPlateNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlateNumber.Multiline = true;
            this.tbPlateNumber.Name = "tbPlateNumber";
            this.tbPlateNumber.Size = new System.Drawing.Size(397, 46);
            this.tbPlateNumber.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(327, 766);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 65);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(558, 766);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 65);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(101, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vehicle Model:";
            // 
            // tbVehicleModel
            // 
            this.tbVehicleModel.Location = new System.Drawing.Point(327, 259);
            this.tbVehicleModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVehicleModel.Multiline = true;
            this.tbVehicleModel.Name = "tbVehicleModel";
            this.tbVehicleModel.Size = new System.Drawing.Size(397, 38);
            this.tbVehicleModel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(104, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "Year Model:";
            // 
            // tbYearModel
            // 
            this.tbYearModel.Location = new System.Drawing.Point(327, 391);
            this.tbYearModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYearModel.Multiline = true;
            this.tbYearModel.Name = "tbYearModel";
            this.tbYearModel.Size = new System.Drawing.Size(397, 45);
            this.tbYearModel.TabIndex = 16;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.IntegralHeight = false;
            this.cmbVehicleType.ItemHeight = 30;
            this.cmbVehicleType.Location = new System.Drawing.Point(327, 320);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(397, 36);
            this.cmbVehicleType.TabIndex = 17;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.IntegralHeight = false;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Location = new System.Drawing.Point(327, 592);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(397, 36);
            this.cmbStatus.TabIndex = 18;
            // 
            // tbDailyRate
            // 
            this.tbDailyRate.Location = new System.Drawing.Point(327, 534);
            this.tbDailyRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDailyRate.Multiline = true;
            this.tbDailyRate.Name = "tbDailyRate";
            this.tbDailyRate.Size = new System.Drawing.Size(397, 38);
            this.tbDailyRate.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(43, 68);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 949);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbDailyRate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.tbYearModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbVehicleModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPlateNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVehicleBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVehicleBrand);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVehicleBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVehicleBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPlateNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVehicleModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbYearModel;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox tbDailyRate;
        private System.Windows.Forms.Button btnBack;
    }
}