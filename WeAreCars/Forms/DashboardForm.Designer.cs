namespace WeAreCars.Forms
{
    partial class DashboardForm
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
            dgvRentedCars = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblNoCars = new Label();
            btnNewBooking = new Button();
            btnReturnCar = new Button();
            btnCancelBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRentedCars).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRentedCars
            // 
            dgvRentedCars.AllowUserToAddRows = false;
            dgvRentedCars.AllowUserToDeleteRows = false;
            dgvRentedCars.AllowUserToResizeColumns = false;
            dgvRentedCars.AllowUserToResizeRows = false;
            dgvRentedCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRentedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvRentedCars.BackgroundColor = Color.White;
            dgvRentedCars.BorderStyle = BorderStyle.None;
            dgvRentedCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentedCars.Columns.AddRange(new DataGridViewColumn[] { Column1, colName, Column2, Column3 });
            dgvRentedCars.Location = new Point(12, 115);
            dgvRentedCars.Name = "dgvRentedCars";
            dgvRentedCars.ReadOnly = true;
            dgvRentedCars.RowHeadersVisible = false;
            dgvRentedCars.Size = new Size(664, 300);
            dgvRentedCars.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Registration";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 95;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 64;
            // 
            // Column2
            // 
            Column2.HeaderText = "Car Type";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 78;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fuel Type";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 82;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 38, 36);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(704, 76);
            pnlHeader.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = SystemColors.ControlLightLight;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 56);
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(617, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 27);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 30);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gainsboro;
            lblSubtitle.Location = new Point(12, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(141, 17);
            lblSubtitle.TabIndex = 7;
            lblSubtitle.Text = "Currently Rented Cars";
            // 
            // lblNoCars
            // 
            lblNoCars.AutoSize = true;
            lblNoCars.BackColor = SystemColors.ControlLightLight;
            lblNoCars.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoCars.ForeColor = Color.Black;
            lblNoCars.Location = new Point(245, 397);
            lblNoCars.Name = "lblNoCars";
            lblNoCars.Size = new Size(242, 18);
            lblNoCars.TabIndex = 10;
            lblNoCars.Text = "No cars are currently rented";
            lblNoCars.TextAlign = ContentAlignment.MiddleCenter;
            lblNoCars.Visible = false;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewBooking.AutoSize = true;
            btnNewBooking.BackColor = Color.Black;
            btnNewBooking.Cursor = Cursors.Hand;
            btnNewBooking.FlatAppearance.BorderColor = Color.Black;
            btnNewBooking.FlatAppearance.BorderSize = 0;
            btnNewBooking.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 66);
            btnNewBooking.FlatStyle = FlatStyle.Flat;
            btnNewBooking.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewBooking.ForeColor = Color.White;
            btnNewBooking.Location = new Point(120, 436);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(132, 33);
            btnNewBooking.TabIndex = 7;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // btnReturnCar
            // 
            btnReturnCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReturnCar.AutoSize = true;
            btnReturnCar.BackColor = Color.Black;
            btnReturnCar.Cursor = Cursors.Hand;
            btnReturnCar.FlatAppearance.BorderColor = Color.Black;
            btnReturnCar.FlatAppearance.BorderSize = 0;
            btnReturnCar.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 66);
            btnReturnCar.FlatStyle = FlatStyle.Flat;
            btnReturnCar.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnCar.ForeColor = Color.White;
            btnReturnCar.Location = new Point(280, 436);
            btnReturnCar.Name = "btnReturnCar";
            btnReturnCar.Size = new Size(132, 33);
            btnReturnCar.TabIndex = 7;
            btnReturnCar.Text = "Return Car";
            btnReturnCar.UseVisualStyleBackColor = false;
            btnReturnCar.Click += btnReturnCar_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelBooking.AutoSize = true;
            btnCancelBooking.BackColor = Color.Black;
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.FlatAppearance.BorderColor = Color.Black;
            btnCancelBooking.FlatAppearance.BorderSize = 0;
            btnCancelBooking.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 66);
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.Font = new Font("Arial Nova", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.Location = new Point(440, 436);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(132, 33);
            btnCancelBooking.TabIndex = 7;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 481);
            Controls.Add(lblNoCars);
            Controls.Add(btnCancelBooking);
            Controls.Add(btnReturnCar);
            Controls.Add(btnNewBooking);
            Controls.Add(pnlHeader);
            Controls.Add(dgvRentedCars);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentedCars).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvRentedCars;
        private Panel pnlHeader;
        private Label lblNoCars;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnLogout;
        private Button btnNewBooking;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnReturnCar;
        private Button btnCancelBooking;
    }
}