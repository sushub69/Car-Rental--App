namespace WeAreCars.Forms
{
    partial class BookingForm
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
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            pnlCarType = new Panel();
            rdoSuv = new RadioButton();
            rdoSports = new RadioButton();
            rdoFamily = new RadioButton();
            rdoCity = new RadioButton();
            pnlFuel = new Panel();
            rdoElectric = new RadioButton();
            rdoHybrid = new RadioButton();
            rdoDiesel = new RadioButton();
            rdoPetrol = new RadioButton();
            label3 = new Label();
            lblCarHeading = new Label();
            btnCancel = new Button();
            btnContinue = new Button();
            chkBreakdownCover = new CheckBox();
            chkUnlimitedMileage = new CheckBox();
            numDays = new NumericUpDown();
            lblDays = new Label();
            lblRentalHeading = new Label();
            toolTip1 = new ToolTip(components);
            pnlLicence = new Panel();
            rdoLicenceNo = new RadioButton();
            rdoLicenceYes = new RadioButton();
            txtAge = new TextBox();
            lblLicence = new Label();
            pnlSummary = new Panel();
            lblAmtBreakdown = new Label();
            lblLineBreakdown = new Label();
            lblAmtMileage = new Label();
            lblLineMileage = new Label();
            lblAmtFuel = new Label();
            lblLineFuel = new Label();
            lblAmtCar = new Label();
            lblLineCar = new Label();
            lblLineDays = new Label();
            lblAmtDays = new Label();
            lblTotal = new Label();
            lblEstimatedCaption = new Label();
            lblBrandSub = new Label();
            lblBrand = new Label();
            txtAddress = new TextBox();
            txtSurname = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            pnlCarType.SuspendLayout();
            pnlFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            pnlLicence.SuspendLayout();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // pnlCarType
            // 
            pnlCarType.Controls.Add(rdoSuv);
            pnlCarType.Controls.Add(rdoSports);
            pnlCarType.Controls.Add(rdoFamily);
            pnlCarType.Controls.Add(rdoCity);
            pnlCarType.Location = new Point(263, 229);
            pnlCarType.Name = "pnlCarType";
            pnlCarType.Size = new Size(645, 70);
            pnlCarType.TabIndex = 24;
            // 
            // rdoSuv
            // 
            rdoSuv.Appearance = Appearance.Button;
            rdoSuv.BackColor = Color.White;
            rdoSuv.Cursor = Cursors.Hand;
            rdoSuv.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoSuv.FlatAppearance.BorderSize = 5;
            rdoSuv.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoSuv.FlatAppearance.MouseOverBackColor = Color.Gray;
            rdoSuv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdoSuv.ForeColor = Color.Black;
            rdoSuv.Location = new Point(510, 12);
            rdoSuv.Name = "rdoSuv";
            rdoSuv.Size = new Size(114, 55);
            rdoSuv.TabIndex = 0;
            rdoSuv.Text = "SUV\r\n+£65";
            rdoSuv.TextAlign = ContentAlignment.MiddleCenter;
            rdoSuv.UseVisualStyleBackColor = false;
            // 
            // rdoSports
            // 
            rdoSports.Appearance = Appearance.Button;
            rdoSports.BackColor = Color.White;
            rdoSports.Cursor = Cursors.Hand;
            rdoSports.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoSports.FlatAppearance.BorderSize = 5;
            rdoSports.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoSports.FlatAppearance.MouseOverBackColor = Color.Gray;
            rdoSports.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdoSports.ForeColor = Color.Black;
            rdoSports.Location = new Point(336, 12);
            rdoSports.Name = "rdoSports";
            rdoSports.Size = new Size(114, 55);
            rdoSports.TabIndex = 0;
            rdoSports.Text = "Sports\r\n+£75";
            rdoSports.TextAlign = ContentAlignment.MiddleCenter;
            rdoSports.UseVisualStyleBackColor = false;
            // 
            // rdoFamily
            // 
            rdoFamily.Appearance = Appearance.Button;
            rdoFamily.BackColor = Color.White;
            rdoFamily.Cursor = Cursors.Hand;
            rdoFamily.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoFamily.FlatAppearance.BorderSize = 5;
            rdoFamily.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoFamily.FlatAppearance.MouseOverBackColor = Color.Gray;
            rdoFamily.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoFamily.ForeColor = Color.Black;
            rdoFamily.Location = new Point(174, 12);
            rdoFamily.Name = "rdoFamily";
            rdoFamily.Size = new Size(114, 55);
            rdoFamily.TabIndex = 0;
            rdoFamily.Text = "Family\r\n+£50";
            rdoFamily.TextAlign = ContentAlignment.MiddleCenter;
            rdoFamily.UseVisualStyleBackColor = false;
            // 
            // rdoCity
            // 
            rdoCity.Appearance = Appearance.Button;
            rdoCity.BackColor = Color.White;
            rdoCity.Checked = true;
            rdoCity.Cursor = Cursors.Hand;
            rdoCity.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoCity.FlatAppearance.BorderSize = 5;
            rdoCity.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoCity.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 38, 36);
            rdoCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoCity.ForeColor = Color.Black;
            rdoCity.Location = new Point(18, 12);
            rdoCity.Name = "rdoCity";
            rdoCity.Size = new Size(114, 55);
            rdoCity.TabIndex = 0;
            rdoCity.TabStop = true;
            rdoCity.Text = "City\r\nIncluded";
            rdoCity.TextAlign = ContentAlignment.MiddleCenter;
            rdoCity.UseVisualStyleBackColor = false;
            // 
            // pnlFuel
            // 
            pnlFuel.Controls.Add(rdoElectric);
            pnlFuel.Controls.Add(rdoHybrid);
            pnlFuel.Controls.Add(rdoDiesel);
            pnlFuel.Controls.Add(rdoPetrol);
            pnlFuel.Location = new Point(263, 336);
            pnlFuel.Name = "pnlFuel";
            pnlFuel.Size = new Size(645, 59);
            pnlFuel.TabIndex = 25;
            // 
            // rdoElectric
            // 
            rdoElectric.Appearance = Appearance.Button;
            rdoElectric.AutoSize = true;
            rdoElectric.BackColor = Color.White;
            rdoElectric.Cursor = Cursors.Hand;
            rdoElectric.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoElectric.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoElectric.FlatAppearance.MouseOverBackColor = Color.DimGray;
            rdoElectric.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            rdoElectric.ForeColor = Color.Black;
            rdoElectric.Location = new Point(397, 13);
            rdoElectric.Name = "rdoElectric";
            rdoElectric.Size = new Size(106, 30);
            rdoElectric.TabIndex = 0;
            rdoElectric.Text = "Electric +£50";
            rdoElectric.UseVisualStyleBackColor = false;
            // 
            // rdoHybrid
            // 
            rdoHybrid.Appearance = Appearance.Button;
            rdoHybrid.AutoSize = true;
            rdoHybrid.BackColor = Color.White;
            rdoHybrid.Cursor = Cursors.Hand;
            rdoHybrid.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoHybrid.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoHybrid.FlatAppearance.MouseOverBackColor = Color.DimGray;
            rdoHybrid.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            rdoHybrid.ForeColor = Color.Black;
            rdoHybrid.Location = new Point(241, 13);
            rdoHybrid.Name = "rdoHybrid";
            rdoHybrid.Size = new Size(104, 30);
            rdoHybrid.TabIndex = 0;
            rdoHybrid.Text = "Hybrid +£30";
            rdoHybrid.UseVisualStyleBackColor = false;
            // 
            // rdoDiesel
            // 
            rdoDiesel.Appearance = Appearance.Button;
            rdoDiesel.AutoSize = true;
            rdoDiesel.BackColor = Color.White;
            rdoDiesel.Cursor = Cursors.Hand;
            rdoDiesel.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoDiesel.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoDiesel.FlatAppearance.MouseOverBackColor = Color.DimGray;
            rdoDiesel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            rdoDiesel.ForeColor = Color.Black;
            rdoDiesel.Location = new Point(128, 13);
            rdoDiesel.Name = "rdoDiesel";
            rdoDiesel.Size = new Size(60, 30);
            rdoDiesel.TabIndex = 0;
            rdoDiesel.Text = "Diesel";
            rdoDiesel.UseVisualStyleBackColor = false;
            // 
            // rdoPetrol
            // 
            rdoPetrol.Appearance = Appearance.Button;
            rdoPetrol.AutoSize = true;
            rdoPetrol.BackColor = Color.White;
            rdoPetrol.Checked = true;
            rdoPetrol.Cursor = Cursors.Hand;
            rdoPetrol.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            rdoPetrol.FlatAppearance.CheckedBackColor = Color.FromArgb(38, 38, 36);
            rdoPetrol.FlatAppearance.MouseOverBackColor = Color.DimGray;
            rdoPetrol.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            rdoPetrol.ForeColor = Color.Black;
            rdoPetrol.Location = new Point(18, 13);
            rdoPetrol.Name = "rdoPetrol";
            rdoPetrol.Size = new Size(59, 30);
            rdoPetrol.TabIndex = 0;
            rdoPetrol.TabStop = true;
            rdoPetrol.Text = "Petrol";
            rdoPetrol.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Nova", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(263, 315);
            label3.Name = "label3";
            label3.Size = new Size(83, 16);
            label3.TabIndex = 19;
            label3.Text = "FUEL TYPE *";
            // 
            // lblCarHeading
            // 
            lblCarHeading.AutoSize = true;
            lblCarHeading.BackColor = Color.White;
            lblCarHeading.Font = new Font("Arial Nova", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarHeading.ForeColor = Color.Black;
            lblCarHeading.Location = new Point(263, 208);
            lblCarHeading.Name = "lblCarHeading";
            lblCarHeading.Size = new Size(78, 16);
            lblCarHeading.TabIndex = 18;
            lblCarHeading.Text = "CAR TYPE *";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            btnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(281, 479);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 31);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Black;
            btnContinue.FlatAppearance.BorderColor = Color.FromArgb(222, 222, 218);
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatAppearance.MouseOverBackColor = Color.White;
            btnContinue.FlatStyle = FlatStyle.System;
            btnContinue.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(581, 479);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(286, 31);
            btnContinue.TabIndex = 29;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // chkBreakdownCover
            // 
            chkBreakdownCover.BackColor = Color.White;
            chkBreakdownCover.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBreakdownCover.ForeColor = Color.Black;
            chkBreakdownCover.Location = new Point(722, 420);
            chkBreakdownCover.Name = "chkBreakdownCover";
            chkBreakdownCover.Size = new Size(145, 36);
            chkBreakdownCover.TabIndex = 28;
            chkBreakdownCover.Text = "Breakdown cover \r\n(+£2/day)";
            toolTip1.SetToolTip(chkBreakdownCover, "Add £2 per day");
            chkBreakdownCover.UseVisualStyleBackColor = false;
            // 
            // chkUnlimitedMileage
            // 
            chkUnlimitedMileage.BackColor = Color.White;
            chkUnlimitedMileage.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkUnlimitedMileage.ForeColor = Color.Black;
            chkUnlimitedMileage.Location = new Point(533, 420);
            chkUnlimitedMileage.Name = "chkUnlimitedMileage";
            chkUnlimitedMileage.Size = new Size(169, 41);
            chkUnlimitedMileage.TabIndex = 27;
            chkUnlimitedMileage.Text = "Unlimited mileage \r\n(+£10/day)";
            toolTip1.SetToolTip(chkUnlimitedMileage, "Add £10 per day");
            chkUnlimitedMileage.UseVisualStyleBackColor = false;
            // 
            // numDays
            // 
            numDays.BackColor = Color.White;
            numDays.BorderStyle = BorderStyle.FixedSingle;
            numDays.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numDays.ForeColor = Color.Black;
            numDays.Location = new Point(405, 425);
            numDays.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            numDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDays.Name = "numDays";
            numDays.Size = new Size(59, 29);
            numDays.TabIndex = 26;
            numDays.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(numDays, "Between 1 and 28 days");
            numDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.BackColor = Color.White;
            lblDays.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDays.ForeColor = Color.Black;
            lblDays.Location = new Point(263, 432);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(136, 15);
            lblDays.TabIndex = 17;
            lblDays.Text = "Days * (£25 per day)";
            // 
            // lblRentalHeading
            // 
            lblRentalHeading.AutoSize = true;
            lblRentalHeading.BackColor = Color.White;
            lblRentalHeading.Font = new Font("Arial Nova", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalHeading.ForeColor = Color.Black;
            lblRentalHeading.Location = new Point(263, 406);
            lblRentalHeading.Name = "lblRentalHeading";
            lblRentalHeading.Size = new Size(116, 16);
            lblRentalHeading.TabIndex = 15;
            lblRentalHeading.Text = "RENTAL OPTIONS";
            // 
            // pnlLicence
            // 
            pnlLicence.BackColor = Color.White;
            pnlLicence.Controls.Add(rdoLicenceNo);
            pnlLicence.Controls.Add(rdoLicenceYes);
            pnlLicence.ForeColor = Color.Black;
            pnlLicence.Location = new Point(575, 147);
            pnlLicence.Name = "pnlLicence";
            pnlLicence.Size = new Size(178, 42);
            pnlLicence.TabIndex = 23;
            toolTip1.SetToolTip(pnlLicence, "The booking cannot proceed without a valid license");
            // 
            // rdoLicenceNo
            // 
            rdoLicenceNo.Appearance = Appearance.Button;
            rdoLicenceNo.BackColor = Color.White;
            rdoLicenceNo.FlatAppearance.MouseOverBackColor = Color.Black;
            rdoLicenceNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoLicenceNo.ForeColor = Color.Black;
            rdoLicenceNo.Location = new Point(98, 4);
            rdoLicenceNo.Name = "rdoLicenceNo";
            rdoLicenceNo.Size = new Size(77, 34);
            rdoLicenceNo.TabIndex = 0;
            rdoLicenceNo.TabStop = true;
            rdoLicenceNo.Text = "No";
            rdoLicenceNo.UseVisualStyleBackColor = false;
            // 
            // rdoLicenceYes
            // 
            rdoLicenceYes.Appearance = Appearance.Button;
            rdoLicenceYes.BackColor = Color.White;
            rdoLicenceYes.FlatAppearance.MouseOverBackColor = Color.Black;
            rdoLicenceYes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoLicenceYes.ForeColor = Color.Black;
            rdoLicenceYes.Location = new Point(14, 4);
            rdoLicenceYes.Name = "rdoLicenceYes";
            rdoLicenceYes.Size = new Size(80, 34);
            rdoLicenceYes.TabIndex = 0;
            rdoLicenceYes.TabStop = true;
            rdoLicenceYes.Text = "Yes";
            rdoLicenceYes.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(310, 156);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age *";
            txtAge.Size = new Size(123, 27);
            txtAge.TabIndex = 21;
            txtAge.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(txtAge, "Customer must be 18 or over");
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // lblLicence
            // 
            lblLicence.AutoSize = true;
            lblLicence.BackColor = Color.White;
            lblLicence.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicence.ForeColor = Color.Black;
            lblLicence.Location = new Point(449, 159);
            lblLicence.Name = "lblLicence";
            lblLicence.Size = new Size(104, 20);
            lblLicence.TabIndex = 22;
            lblLicence.Text = "Valid Licence*";
            toolTip1.SetToolTip(lblLicence, "The booking cannot proceed without a valid licence");
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.Black;
            pnlSummary.Controls.Add(lblAmtBreakdown);
            pnlSummary.Controls.Add(lblLineBreakdown);
            pnlSummary.Controls.Add(lblAmtMileage);
            pnlSummary.Controls.Add(lblLineMileage);
            pnlSummary.Controls.Add(lblAmtFuel);
            pnlSummary.Controls.Add(lblLineFuel);
            pnlSummary.Controls.Add(lblAmtCar);
            pnlSummary.Controls.Add(lblLineCar);
            pnlSummary.Controls.Add(lblLineDays);
            pnlSummary.Controls.Add(lblAmtDays);
            pnlSummary.Controls.Add(lblTotal);
            pnlSummary.Controls.Add(lblEstimatedCaption);
            pnlSummary.Controls.Add(lblBrandSub);
            pnlSummary.Controls.Add(lblBrand);
            pnlSummary.Dock = DockStyle.Left;
            pnlSummary.Font = new Font("Lucida Sans", 8.25F, FontStyle.Bold);
            pnlSummary.ForeColor = SystemColors.ControlText;
            pnlSummary.Location = new Point(0, 0);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(249, 522);
            pnlSummary.TabIndex = 13;
            // 
            // lblAmtBreakdown
            // 
            lblAmtBreakdown.AutoSize = true;
            lblAmtBreakdown.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblAmtBreakdown.ForeColor = Color.FromArgb(224, 224, 224);
            lblAmtBreakdown.Location = new Point(157, 362);
            lblAmtBreakdown.Name = "lblAmtBreakdown";
            lblAmtBreakdown.Size = new Size(44, 16);
            lblAmtBreakdown.TabIndex = 1;
            lblAmtBreakdown.Text = "label2";
            // 
            // lblLineBreakdown
            // 
            lblLineBreakdown.AutoSize = true;
            lblLineBreakdown.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLineBreakdown.ForeColor = Color.FromArgb(224, 224, 224);
            lblLineBreakdown.Location = new Point(25, 362);
            lblLineBreakdown.Name = "lblLineBreakdown";
            lblLineBreakdown.Size = new Size(44, 16);
            lblLineBreakdown.TabIndex = 1;
            lblLineBreakdown.Text = "label2";
            // 
            // lblAmtMileage
            // 
            lblAmtMileage.AutoSize = true;
            lblAmtMileage.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblAmtMileage.ForeColor = Color.FromArgb(224, 224, 224);
            lblAmtMileage.Location = new Point(157, 319);
            lblAmtMileage.Name = "lblAmtMileage";
            lblAmtMileage.Size = new Size(44, 16);
            lblAmtMileage.TabIndex = 1;
            lblAmtMileage.Text = "label2";
            // 
            // lblLineMileage
            // 
            lblLineMileage.AutoSize = true;
            lblLineMileage.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLineMileage.ForeColor = Color.FromArgb(224, 224, 224);
            lblLineMileage.Location = new Point(25, 319);
            lblLineMileage.Name = "lblLineMileage";
            lblLineMileage.Size = new Size(44, 16);
            lblLineMileage.TabIndex = 1;
            lblLineMileage.Text = "label2";
            // 
            // lblAmtFuel
            // 
            lblAmtFuel.AutoSize = true;
            lblAmtFuel.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblAmtFuel.ForeColor = Color.FromArgb(224, 224, 224);
            lblAmtFuel.Location = new Point(157, 276);
            lblAmtFuel.Name = "lblAmtFuel";
            lblAmtFuel.Size = new Size(44, 16);
            lblAmtFuel.TabIndex = 1;
            lblAmtFuel.Text = "label2";
            // 
            // lblLineFuel
            // 
            lblLineFuel.AutoSize = true;
            lblLineFuel.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLineFuel.ForeColor = Color.FromArgb(224, 224, 224);
            lblLineFuel.Location = new Point(25, 276);
            lblLineFuel.Name = "lblLineFuel";
            lblLineFuel.Size = new Size(44, 16);
            lblLineFuel.TabIndex = 1;
            lblLineFuel.Text = "label2";
            // 
            // lblAmtCar
            // 
            lblAmtCar.AutoSize = true;
            lblAmtCar.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblAmtCar.ForeColor = Color.FromArgb(224, 224, 224);
            lblAmtCar.Location = new Point(157, 234);
            lblAmtCar.Name = "lblAmtCar";
            lblAmtCar.Size = new Size(44, 16);
            lblAmtCar.TabIndex = 1;
            lblAmtCar.Text = "label2";
            // 
            // lblLineCar
            // 
            lblLineCar.AutoSize = true;
            lblLineCar.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLineCar.ForeColor = Color.FromArgb(224, 224, 224);
            lblLineCar.Location = new Point(25, 234);
            lblLineCar.Name = "lblLineCar";
            lblLineCar.Size = new Size(44, 16);
            lblLineCar.TabIndex = 1;
            lblLineCar.Text = "label2";
            // 
            // lblLineDays
            // 
            lblLineDays.AutoSize = true;
            lblLineDays.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLineDays.ForeColor = Color.FromArgb(224, 224, 224);
            lblLineDays.Location = new Point(25, 191);
            lblLineDays.Name = "lblLineDays";
            lblLineDays.Size = new Size(44, 16);
            lblLineDays.TabIndex = 1;
            lblLineDays.Text = "label2";
            // 
            // lblAmtDays
            // 
            lblAmtDays.AutoSize = true;
            lblAmtDays.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblAmtDays.ForeColor = Color.FromArgb(224, 224, 224);
            lblAmtDays.Location = new Point(157, 191);
            lblAmtDays.Name = "lblAmtDays";
            lblAmtDays.Size = new Size(44, 16);
            lblAmtDays.TabIndex = 1;
            lblAmtDays.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Black;
            lblTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(66, 110);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(109, 47);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "£0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Click += lblTotal_Click;
            // 
            // lblEstimatedCaption
            // 
            lblEstimatedCaption.AutoSize = true;
            lblEstimatedCaption.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstimatedCaption.ForeColor = Color.White;
            lblEstimatedCaption.Location = new Point(66, 82);
            lblEstimatedCaption.Name = "lblEstimatedCaption";
            lblEstimatedCaption.Size = new Size(109, 15);
            lblEstimatedCaption.TabIndex = 0;
            lblEstimatedCaption.Text = "ESTIMATED TOTAL";
            lblEstimatedCaption.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.BackColor = Color.Black;
            lblBrandSub.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandSub.ForeColor = Color.FromArgb(224, 224, 224);
            lblBrandSub.Location = new Point(14, 42);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(89, 17);
            lblBrandSub.TabIndex = 0;
            lblBrandSub.Text = "New Booking";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(38, 10);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(120, 21);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "🚗 WeAreCars";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(310, 95);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address *";
            txtAddress.Size = new Size(556, 27);
            txtAddress.TabIndex = 20;
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.White;
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtSurname.ForeColor = Color.Black;
            txtSurname.ImeMode = ImeMode.Disable;
            txtSurname.Location = new Point(641, 36);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Surname *";
            txtSurname.Size = new Size(225, 27);
            txtSurname.TabIndex = 14;
            txtSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(310, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name *";
            txtFirstName.Size = new Size(209, 27);
            txtFirstName.TabIndex = 12;
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Nova", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(263, 10);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 16;
            label2.Text = "CUSTOMER";
            // 
            // BookingForm
            // 
            AcceptButton = btnContinue;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(914, 522);
            Controls.Add(pnlCarType);
            Controls.Add(pnlFuel);
            Controls.Add(label3);
            Controls.Add(lblCarHeading);
            Controls.Add(btnCancel);
            Controls.Add(btnContinue);
            Controls.Add(chkBreakdownCover);
            Controls.Add(chkUnlimitedMileage);
            Controls.Add(numDays);
            Controls.Add(lblDays);
            Controls.Add(lblRentalHeading);
            Controls.Add(pnlSummary);
            Controls.Add(pnlLicence);
            Controls.Add(txtAddress);
            Controls.Add(txtSurname);
            Controls.Add(txtAge);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(lblLicence);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            Name = "BookingForm";
            Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            pnlCarType.ResumeLayout(false);
            pnlFuel.ResumeLayout(false);
            pnlFuel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
            pnlLicence.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private Panel pnlCarType;
        private RadioButton rdoSuv;
        private RadioButton rdoSports;
        private RadioButton rdoFamily;
        private RadioButton rdoCity;
        private Panel pnlFuel;
        private RadioButton rdoElectric;
        private RadioButton rdoHybrid;
        private RadioButton rdoDiesel;
        private RadioButton rdoPetrol;
        private Label label3;
        private Label lblCarHeading;
        private Button btnCancel;
        private Button btnContinue;
        private CheckBox chkBreakdownCover;
        private ToolTip toolTip1;
        private CheckBox chkUnlimitedMileage;
        private NumericUpDown numDays;
        private Label lblDays;
        private Label lblRentalHeading;
        private Panel pnlSummary;
        private Label lblAmtBreakdown;
        private Label lblLineBreakdown;
        private Label lblAmtMileage;
        private Label lblLineMileage;
        private Label lblAmtFuel;
        private Label lblLineFuel;
        private Label lblAmtCar;
        private Label lblLineCar;
        private Label lblAmtDays;
        private Label lblTotal;
        private Label lblEstimatedCaption;
        private Label lblBrandSub;
        private Label lblBrand;
        private Panel pnlLicence;
        private RadioButton rdoLicenceNo;
        private RadioButton rdoLicenceYes;
        private TextBox txtAddress;
        private TextBox txtSurname;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private Label label2;
        private Label lblLicence;
        private Label lblLineDays;
    }
}