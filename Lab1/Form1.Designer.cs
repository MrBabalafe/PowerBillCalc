
namespace Lab1
{
    partial class frmPowerBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.lblKwhUsed = new System.Windows.Forms.Label();
            this.txtKwhUsed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPeakKwhUsed = new System.Windows.Forms.Label();
            this.txtPeakKwhUsed = new System.Windows.Forms.TextBox();
            this.txtOffPeakKwhUsed = new System.Windows.Forms.TextBox();
            this.lblOffPeakKwhUsed = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblTotalCusts = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.lblTotalCustsCount = new System.Windows.Forms.Label();
            this.lblTotalChargesCount = new System.Windows.Forms.Label();
            this.lblTotalResidential = new System.Windows.Forms.Label();
            this.lblTotalCommercial = new System.Windows.Forms.Label();
            this.lblTotalIndustrial = new System.Windows.Forms.Label();
            this.lblTotalResidentialCount = new System.Windows.Forms.Label();
            this.lblTotalCommercialCount = new System.Windows.Forms.Label();
            this.lblTotalIndustrialCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type:";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(206, 46);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(67, 17);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(105, 46);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(79, 17);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Location = new System.Drawing.Point(6, 46);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(77, 17);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // lblKwhUsed
            // 
            this.lblKwhUsed.AutoSize = true;
            this.lblKwhUsed.Location = new System.Drawing.Point(18, 150);
            this.lblKwhUsed.Name = "lblKwhUsed";
            this.lblKwhUsed.Size = new System.Drawing.Size(61, 13);
            this.lblKwhUsed.TabIndex = 1;
            this.lblKwhUsed.Text = "kWh Used:";
            // 
            // txtKwhUsed
            // 
            this.txtKwhUsed.Location = new System.Drawing.Point(85, 147);
            this.txtKwhUsed.Name = "txtKwhUsed";
            this.txtKwhUsed.Size = new System.Drawing.Size(100, 20);
            this.txtKwhUsed.TabIndex = 2;
            this.txtKwhUsed.Enter += new System.EventHandler(this.txtKwhUsed_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculate.Location = new System.Drawing.Point(21, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(102, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(183, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPeakKwhUsed
            // 
            this.lblPeakKwhUsed.AutoSize = true;
            this.lblPeakKwhUsed.Location = new System.Drawing.Point(18, 150);
            this.lblPeakKwhUsed.Name = "lblPeakKwhUsed";
            this.lblPeakKwhUsed.Size = new System.Drawing.Size(120, 13);
            this.lblPeakKwhUsed.TabIndex = 7;
            this.lblPeakKwhUsed.Text = "Peak Hours kWh Used:";
            // 
            // txtPeakKwhUsed
            // 
            this.txtPeakKwhUsed.Location = new System.Drawing.Point(161, 147);
            this.txtPeakKwhUsed.Name = "txtPeakKwhUsed";
            this.txtPeakKwhUsed.Size = new System.Drawing.Size(100, 20);
            this.txtPeakKwhUsed.TabIndex = 8;
            this.txtPeakKwhUsed.Enter += new System.EventHandler(this.txtPeakKwhUsed_Enter);
            // 
            // txtOffPeakKwhUsed
            // 
            this.txtOffPeakKwhUsed.Location = new System.Drawing.Point(161, 182);
            this.txtOffPeakKwhUsed.Name = "txtOffPeakKwhUsed";
            this.txtOffPeakKwhUsed.Size = new System.Drawing.Size(100, 20);
            this.txtOffPeakKwhUsed.TabIndex = 10;
            this.txtOffPeakKwhUsed.Enter += new System.EventHandler(this.txtOffPeakKwhUsed_Enter);
            // 
            // lblOffPeakKwhUsed
            // 
            this.lblOffPeakKwhUsed.AutoSize = true;
            this.lblOffPeakKwhUsed.Location = new System.Drawing.Point(18, 185);
            this.lblOffPeakKwhUsed.Name = "lblOffPeakKwhUsed";
            this.lblOffPeakKwhUsed.Size = new System.Drawing.Size(137, 13);
            this.lblOffPeakKwhUsed.TabIndex = 9;
            this.lblOffPeakKwhUsed.Text = "Off-Peak Hours kWh Used:";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Location = new System.Drawing.Point(289, 150);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(71, 13);
            this.lblTotalCharge.TabIndex = 11;
            this.lblTotalCharge.Text = "Total Charge:";
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Location = new System.Drawing.Point(385, 147);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.ReadOnly = true;
            this.txtTotalCharge.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCharge.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(370, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(289, 191);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 14;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(289, 217);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(385, 188);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 16;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(385, 214);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 17;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddCustomer.Location = new System.Drawing.Point(399, 243);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 18;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(532, 12);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(376, 121);
            this.lstCustomers.TabIndex = 19;
            // 
            // lblTotalCusts
            // 
            this.lblTotalCusts.AutoSize = true;
            this.lblTotalCusts.Location = new System.Drawing.Point(529, 136);
            this.lblTotalCusts.Name = "lblTotalCusts";
            this.lblTotalCusts.Size = new System.Drawing.Size(138, 13);
            this.lblTotalCusts.TabIndex = 20;
            this.lblTotalCusts.Text = "Total Number of Customers:";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Location = new System.Drawing.Point(529, 208);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(98, 13);
            this.lblTotalCharges.TabIndex = 21;
            this.lblTotalCharges.Text = "Sum of all Charges:";
            // 
            // lblTotalCustsCount
            // 
            this.lblTotalCustsCount.AutoSize = true;
            this.lblTotalCustsCount.Location = new System.Drawing.Point(691, 136);
            this.lblTotalCustsCount.Name = "lblTotalCustsCount";
            this.lblTotalCustsCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCustsCount.TabIndex = 22;
            this.lblTotalCustsCount.Text = "label1";
            // 
            // lblTotalChargesCount
            // 
            this.lblTotalChargesCount.AutoSize = true;
            this.lblTotalChargesCount.Location = new System.Drawing.Point(691, 208);
            this.lblTotalChargesCount.Name = "lblTotalChargesCount";
            this.lblTotalChargesCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalChargesCount.TabIndex = 23;
            this.lblTotalChargesCount.Text = "label1";
            // 
            // lblTotalResidential
            // 
            this.lblTotalResidential.AutoSize = true;
            this.lblTotalResidential.Location = new System.Drawing.Point(529, 154);
            this.lblTotalResidential.Name = "lblTotalResidential";
            this.lblTotalResidential.Size = new System.Drawing.Size(162, 13);
            this.lblTotalResidential.TabIndex = 24;
            this.lblTotalResidential.Text = "Total For Residential Customers: ";
            // 
            // lblTotalCommercial
            // 
            this.lblTotalCommercial.AutoSize = true;
            this.lblTotalCommercial.Location = new System.Drawing.Point(529, 172);
            this.lblTotalCommercial.Name = "lblTotalCommercial";
            this.lblTotalCommercial.Size = new System.Drawing.Size(164, 13);
            this.lblTotalCommercial.TabIndex = 25;
            this.lblTotalCommercial.Text = "Total For Commercial Customers: ";
            // 
            // lblTotalIndustrial
            // 
            this.lblTotalIndustrial.AutoSize = true;
            this.lblTotalIndustrial.Location = new System.Drawing.Point(529, 190);
            this.lblTotalIndustrial.Name = "lblTotalIndustrial";
            this.lblTotalIndustrial.Size = new System.Drawing.Size(152, 13);
            this.lblTotalIndustrial.TabIndex = 26;
            this.lblTotalIndustrial.Text = "Total For Industrial Customers: ";
            // 
            // lblTotalResidentialCount
            // 
            this.lblTotalResidentialCount.AutoSize = true;
            this.lblTotalResidentialCount.Location = new System.Drawing.Point(691, 154);
            this.lblTotalResidentialCount.Name = "lblTotalResidentialCount";
            this.lblTotalResidentialCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalResidentialCount.TabIndex = 27;
            this.lblTotalResidentialCount.Text = "label1";
            // 
            // lblTotalCommercialCount
            // 
            this.lblTotalCommercialCount.AutoSize = true;
            this.lblTotalCommercialCount.Location = new System.Drawing.Point(691, 172);
            this.lblTotalCommercialCount.Name = "lblTotalCommercialCount";
            this.lblTotalCommercialCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCommercialCount.TabIndex = 28;
            this.lblTotalCommercialCount.Text = "label1";
            // 
            // lblTotalIndustrialCount
            // 
            this.lblTotalIndustrialCount.AutoSize = true;
            this.lblTotalIndustrialCount.Location = new System.Drawing.Point(691, 190);
            this.lblTotalIndustrialCount.Name = "lblTotalIndustrialCount";
            this.lblTotalIndustrialCount.Size = new System.Drawing.Size(35, 13);
            this.lblTotalIndustrialCount.TabIndex = 29;
            this.lblTotalIndustrialCount.Text = "label1";
            // 
            // frmPowerBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(920, 278);
            this.Controls.Add(this.lblTotalIndustrialCount);
            this.Controls.Add(this.lblTotalCommercialCount);
            this.Controls.Add(this.lblTotalResidentialCount);
            this.Controls.Add(this.lblTotalIndustrial);
            this.Controls.Add(this.lblTotalCommercial);
            this.Controls.Add(this.lblTotalResidential);
            this.Controls.Add(this.lblTotalChargesCount);
            this.Controls.Add(this.lblTotalCustsCount);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblTotalCusts);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotalCharge);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.txtOffPeakKwhUsed);
            this.Controls.Add(this.lblOffPeakKwhUsed);
            this.Controls.Add(this.txtPeakKwhUsed);
            this.Controls.Add(this.lblPeakKwhUsed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtKwhUsed);
            this.Controls.Add(this.lblKwhUsed);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPowerBill";
            this.Text = "Power Bill Calculator";
            this.Load += new System.EventHandler(this.frmPowerBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label lblKwhUsed;
        private System.Windows.Forms.TextBox txtKwhUsed;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPeakKwhUsed;
        private System.Windows.Forms.TextBox txtPeakKwhUsed;
        private System.Windows.Forms.TextBox txtOffPeakKwhUsed;
        private System.Windows.Forms.Label lblOffPeakKwhUsed;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblTotalCusts;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label lblTotalCustsCount;
        private System.Windows.Forms.Label lblTotalChargesCount;
        private System.Windows.Forms.Label lblTotalResidential;
        private System.Windows.Forms.Label lblTotalCommercial;
        private System.Windows.Forms.Label lblTotalIndustrial;
        private System.Windows.Forms.Label lblTotalResidentialCount;
        private System.Windows.Forms.Label lblTotalCommercialCount;
        private System.Windows.Forms.Label lblTotalIndustrialCount;
    }
}

