namespace WeAreCars.Forms
{
    partial class SummaryForm
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
            pnlHeader = new Panel();
            lblBookingId = new Label();
            lblHeaderTitle = new Label();
            lblCustomer = new Label();
            lblValName = new Label();
            lblValAddress = new Label();
            lblValAge = new Label();
            lblValLicence = new Label();
            lblLineDays = new Label();
            lblValFuelType = new Label();
            lblValDays = new Label();
            lblRental = new Label();
            lblValExtras = new Label();
            lblPrice = new Label();
            lblLineCar = new Label();
            lblLineFuel = new Label();
            lblLineMileage = new Label();
            lblLineBreakdown = new Label();
            lblAmtDays = new Label();
            lblAmtCar = new Label();
            lblAmtFuel = new Label();
            lblAmtMileage = new Label();
            lblAmtBreakdown = new Label();
            pnlDivider = new Panel();
            btnConfirm = new Button();
            btnBack = new Button();
            lblTotalValue = new Label();
            lblTotalCaption = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblValCarType = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            any = new Label();
            lblValReturnDate = new Label();
            pnlHeader.SuspendLayout();
            pnlDivider.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Black;
            pnlHeader.Controls.Add(lblBookingId);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(504, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingId.ForeColor = Color.Gainsboro;
            lblBookingId.Location = new Point(12, 39);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(63, 20);
            lblBookingId.TabIndex = 0;
            lblBookingId.Text = "BK-0001";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(12, 9);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(191, 30);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Booking Summary";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Arial Nova", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.ForeColor = Color.Black;
            lblCustomer.Location = new Point(12, 103);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(99, 23);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // lblValName
            // 
            lblValName.AutoSize = true;
            lblValName.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValName.ForeColor = Color.Black;
            lblValName.Location = new Point(372, 135);
            lblValName.Name = "lblValName";
            lblValName.Size = new Size(43, 18);
            lblValName.TabIndex = 0;
            lblValName.Text = "Name";
            lblValName.Click += lblValName_Click;
            // 
            // lblValAddress
            // 
            lblValAddress.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValAddress.ForeColor = Color.Black;
            lblValAddress.Location = new Point(372, 155);
            lblValAddress.Name = "lblValAddress";
            lblValAddress.Size = new Size(120, 37);
            lblValAddress.TabIndex = 0;
            lblValAddress.Text = "Address";
            // 
            // lblValAge
            // 
            lblValAge.AutoSize = true;
            lblValAge.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValAge.ForeColor = Color.Black;
            lblValAge.Location = new Point(372, 192);
            lblValAge.Name = "lblValAge";
            lblValAge.Size = new Size(32, 18);
            lblValAge.TabIndex = 0;
            lblValAge.Text = "Age";
            // 
            // lblValLicence
            // 
            lblValLicence.AutoSize = true;
            lblValLicence.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValLicence.ForeColor = Color.Black;
            lblValLicence.Location = new Point(372, 212);
            lblValLicence.Name = "lblValLicence";
            lblValLicence.Size = new Size(92, 18);
            lblValLicence.TabIndex = 0;
            lblValLicence.Text = "Valid License";
            // 
            // lblLineDays
            // 
            lblLineDays.AutoSize = true;
            lblLineDays.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblLineDays.ForeColor = Color.FromArgb(38, 38, 36);
            lblLineDays.Location = new Point(12, 444);
            lblLineDays.Name = "lblLineDays";
            lblLineDays.Size = new Size(62, 18);
            lblLineDays.TabIndex = 0;
            lblLineDays.Text = "Car Type";
            lblLineDays.Click += lblValCarType_Click;
            // 
            // lblValFuelType
            // 
            lblValFuelType.AutoSize = true;
            lblValFuelType.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValFuelType.ForeColor = Color.Black;
            lblValFuelType.Location = new Point(372, 304);
            lblValFuelType.Name = "lblValFuelType";
            lblValFuelType.Size = new Size(69, 18);
            lblValFuelType.TabIndex = 0;
            lblValFuelType.Text = "Fuel Type";
            // 
            // lblValDays
            // 
            lblValDays.AutoSize = true;
            lblValDays.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValDays.ForeColor = Color.Black;
            lblValDays.Location = new Point(372, 322);
            lblValDays.Name = "lblValDays";
            lblValDays.Size = new Size(38, 18);
            lblValDays.TabIndex = 0;
            lblValDays.Text = "Days";
            // 
            // lblRental
            // 
            lblRental.AutoSize = true;
            lblRental.Font = new Font("Arial Nova", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRental.ForeColor = Color.Black;
            lblRental.Location = new Point(12, 252);
            lblRental.Name = "lblRental";
            lblRental.Size = new Size(67, 23);
            lblRental.TabIndex = 0;
            lblRental.Text = "Rental";
            // 
            // lblValExtras
            // 
            lblValExtras.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValExtras.ForeColor = Color.Black;
            lblValExtras.Location = new Point(372, 340);
            lblValExtras.Name = "lblValExtras";
            lblValExtras.Size = new Size(120, 43);
            lblValExtras.TabIndex = 0;
            lblValExtras.Text = "Extras";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Nova", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(12, 414);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 23);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            // 
            // lblLineCar
            // 
            lblLineCar.AutoSize = true;
            lblLineCar.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblLineCar.ForeColor = Color.FromArgb(38, 38, 36);
            lblLineCar.Location = new Point(12, 464);
            lblLineCar.Name = "lblLineCar";
            lblLineCar.Size = new Size(62, 18);
            lblLineCar.TabIndex = 0;
            lblLineCar.Text = "Car Type";
            lblLineCar.Click += lblValCarType_Click;
            // 
            // lblLineFuel
            // 
            lblLineFuel.AutoSize = true;
            lblLineFuel.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblLineFuel.ForeColor = Color.FromArgb(38, 38, 36);
            lblLineFuel.Location = new Point(12, 484);
            lblLineFuel.Name = "lblLineFuel";
            lblLineFuel.Size = new Size(62, 18);
            lblLineFuel.TabIndex = 0;
            lblLineFuel.Text = "Car Type";
            lblLineFuel.Click += lblValCarType_Click;
            // 
            // lblLineMileage
            // 
            lblLineMileage.AutoSize = true;
            lblLineMileage.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblLineMileage.ForeColor = Color.FromArgb(38, 38, 36);
            lblLineMileage.Location = new Point(12, 504);
            lblLineMileage.Name = "lblLineMileage";
            lblLineMileage.Size = new Size(62, 18);
            lblLineMileage.TabIndex = 0;
            lblLineMileage.Text = "Car Type";
            lblLineMileage.Click += lblValCarType_Click;
            // 
            // lblLineBreakdown
            // 
            lblLineBreakdown.AutoSize = true;
            lblLineBreakdown.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblLineBreakdown.ForeColor = Color.FromArgb(38, 38, 36);
            lblLineBreakdown.Location = new Point(12, 524);
            lblLineBreakdown.Name = "lblLineBreakdown";
            lblLineBreakdown.Size = new Size(62, 18);
            lblLineBreakdown.TabIndex = 0;
            lblLineBreakdown.Text = "Car Type";
            lblLineBreakdown.Click += lblValCarType_Click;
            // 
            // lblAmtDays
            // 
            lblAmtDays.AutoSize = true;
            lblAmtDays.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblAmtDays.ForeColor = Color.Black;
            lblAmtDays.Location = new Point(372, 444);
            lblAmtDays.Name = "lblAmtDays";
            lblAmtDays.Size = new Size(62, 18);
            lblAmtDays.TabIndex = 0;
            lblAmtDays.Text = "Car Type";
            lblAmtDays.Click += lblValCarType_Click;
            // 
            // lblAmtCar
            // 
            lblAmtCar.AutoSize = true;
            lblAmtCar.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblAmtCar.ForeColor = Color.Black;
            lblAmtCar.Location = new Point(372, 464);
            lblAmtCar.Name = "lblAmtCar";
            lblAmtCar.Size = new Size(62, 18);
            lblAmtCar.TabIndex = 0;
            lblAmtCar.Text = "Car Type";
            lblAmtCar.Click += lblValCarType_Click;
            // 
            // lblAmtFuel
            // 
            lblAmtFuel.AutoSize = true;
            lblAmtFuel.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblAmtFuel.ForeColor = Color.Black;
            lblAmtFuel.Location = new Point(372, 484);
            lblAmtFuel.Name = "lblAmtFuel";
            lblAmtFuel.Size = new Size(62, 18);
            lblAmtFuel.TabIndex = 0;
            lblAmtFuel.Text = "Car Type";
            lblAmtFuel.Click += lblValCarType_Click;
            // 
            // lblAmtMileage
            // 
            lblAmtMileage.AutoSize = true;
            lblAmtMileage.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblAmtMileage.ForeColor = Color.Black;
            lblAmtMileage.Location = new Point(372, 504);
            lblAmtMileage.Name = "lblAmtMileage";
            lblAmtMileage.Size = new Size(62, 18);
            lblAmtMileage.TabIndex = 0;
            lblAmtMileage.Text = "Car Type";
            lblAmtMileage.Click += lblValCarType_Click;
            // 
            // lblAmtBreakdown
            // 
            lblAmtBreakdown.AutoSize = true;
            lblAmtBreakdown.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblAmtBreakdown.ForeColor = Color.Black;
            lblAmtBreakdown.Location = new Point(372, 524);
            lblAmtBreakdown.Name = "lblAmtBreakdown";
            lblAmtBreakdown.Size = new Size(62, 18);
            lblAmtBreakdown.TabIndex = 0;
            lblAmtBreakdown.Text = "Car Type";
            lblAmtBreakdown.Click += lblValCarType_Click;
            // 
            // pnlDivider
            // 
            pnlDivider.BorderStyle = BorderStyle.FixedSingle;
            pnlDivider.Controls.Add(btnConfirm);
            pnlDivider.Controls.Add(btnBack);
            pnlDivider.Controls.Add(lblTotalValue);
            pnlDivider.Controls.Add(lblTotalCaption);
            pnlDivider.Dock = DockStyle.Bottom;
            pnlDivider.Location = new Point(0, 545);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(504, 107);
            pnlDivider.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(291, 53);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(200, 40);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm Booking";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(11, 54);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back to edit";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = Color.Black;
            lblTotalValue.Location = new Point(358, 18);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(105, 32);
            lblTotalValue.TabIndex = 0;
            lblTotalValue.Text = "label1";
            lblTotalValue.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalValue.Click += lblTotalValue_Click;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCaption.ForeColor = Color.Black;
            lblTotalCaption.Location = new Point(11, 18);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(55, 25);
            lblTotalCaption.TabIndex = 0;
            lblTotalCaption.Text = "Total";
            lblTotalCaption.Click += lblTotalCaption_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 38, 36);
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(43, 18);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(38, 38, 36);
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 0;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(38, 38, 36);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 0;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(38, 38, 36);
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 0;
            label4.Text = "Valid License";
            // 
            // lblValCarType
            // 
            lblValCarType.AutoSize = true;
            lblValCarType.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValCarType.ForeColor = Color.Black;
            lblValCarType.Location = new Point(372, 284);
            lblValCarType.Name = "lblValCarType";
            lblValCarType.Size = new Size(62, 18);
            lblValCarType.TabIndex = 0;
            lblValCarType.Text = "Car Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(38, 38, 36);
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 0;
            label5.Text = "Fuel Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(38, 38, 36);
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 0;
            label6.Text = "Car Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(38, 38, 36);
            label7.Location = new Point(12, 322);
            label7.Name = "label7";
            label7.Size = new Size(38, 18);
            label7.TabIndex = 0;
            label7.Text = "Days";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(38, 38, 36);
            label8.Location = new Point(12, 340);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 0;
            label8.Text = "Extras";
            // 
            // any
            // 
            any.AutoSize = true;
            any.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            any.ForeColor = Color.FromArgb(38, 38, 36);
            any.Location = new Point(12, 383);
            any.Name = "any";
            any.Size = new Size(69, 18);
            any.TabIndex = 0;
            any.Text = "Return by";
            // 
            // lblValReturnDate
            // 
            lblValReturnDate.Font = new Font("Arial Nova Cond", 11.25F, FontStyle.Bold);
            lblValReturnDate.ForeColor = Color.Black;
            lblValReturnDate.Location = new Point(372, 383);
            lblValReturnDate.Name = "lblValReturnDate";
            lblValReturnDate.Size = new Size(129, 45);
            lblValReturnDate.TabIndex = 0;
            lblValReturnDate.Text = "Return";
            // 
            // SummaryForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 652);
            Controls.Add(pnlDivider);
            Controls.Add(any);
            Controls.Add(label8);
            Controls.Add(lblValReturnDate);
            Controls.Add(lblValExtras);
            Controls.Add(label7);
            Controls.Add(lblValDays);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblValCarType);
            Controls.Add(lblValFuelType);
            Controls.Add(lblAmtBreakdown);
            Controls.Add(lblLineBreakdown);
            Controls.Add(lblAmtMileage);
            Controls.Add(lblLineMileage);
            Controls.Add(lblAmtFuel);
            Controls.Add(lblAmtCar);
            Controls.Add(lblLineFuel);
            Controls.Add(lblAmtDays);
            Controls.Add(lblLineCar);
            Controls.Add(lblLineDays);
            Controls.Add(label4);
            Controls.Add(lblValLicence);
            Controls.Add(label3);
            Controls.Add(lblValAge);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValAddress);
            Controls.Add(lblValName);
            Controls.Add(lblPrice);
            Controls.Add(lblRental);
            Controls.Add(lblCustomer);
            Controls.Add(pnlHeader);
            DoubleBuffered = true;
            ForeColor = SystemColors.ButtonHighlight;
            MaximizeBox = false;
            Name = "SummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Summary";
            Load += SummaryForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlDivider.ResumeLayout(false);
            pnlDivider.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblBookingId;
        private Label lblHeaderTitle;
        private Label lblCustomer;
        private Label lblValName;
        private Label lblValAddress;
        private Label lblValAge;
        private Label lblValLicence;
        private Label lblLineDays;
        private Label lblValFuelType;
        private Label lblValDays;
        private Label lblRental;
        private Label lblValExtras;
        private Label lblPrice;
        private Label lblLineCar;
        private Label lblLineFuel;
        private Label lblLineMileage;
        private Label lblLineBreakdown;
        private Label lblAmtDays;
        private Label lblAmtCar;
        private Label lblAmtFuel;
        private Label lblAmtMileage;
        private Label lblAmtBreakdown;
        private Panel pnlDivider;
        private Label lblTotalValue;
        private Label lblTotalCaption;
        private Button btnConfirm;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblValCarType;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label any;
        private Label lblValReturnDate;
    }
}