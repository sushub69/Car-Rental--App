using System;
using System.Windows.Forms;
using WeAreCars.Services;            

namespace WeAreCars.Forms
{
    public partial class SplashForm : Form
    {
        private readonly RentalManager rentalManager;   

      
       
        public SplashForm(RentalManager rentalManager)
        {
            InitializeComponent();
            this.rentalManager = rentalManager;
        }

       
        private void btnContinue_Click(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm(rentalManager))
            {
                loginForm.ShowDialog();
            }

            this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            lblWelcome = new Label();
            lblSubtitle = new Label();
            picCar = new PictureBox();
            lblDescription = new Label();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.ControlText;
            lblWelcome.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlLightLight;
            lblWelcome.Location = new Point(163, 71);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(295, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to WeAreCars";
            lblWelcome.Click += label1_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = SystemColors.ControlText;
            lblSubtitle.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.ControlLightLight;
            lblSubtitle.Location = new Point(176, 99);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(263, 23);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Rental Management System";
            lblSubtitle.Click += label1_Click;
            // 
            // picCar
            // 
            picCar.BackColor = SystemColors.ControlText;
            picCar.BackgroundImageLayout = ImageLayout.Stretch;
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(262, 12);
            picCar.Name = "picCar";
            picCar.Size = new Size(100, 50);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 1;
            picCar.TabStop = false;
            picCar.Click += pictureBox1_Click;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = SystemColors.ControlText;
            lblDescription.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlLightLight;
            lblDescription.Location = new Point(1, 206);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(608, 93);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "This system lets staff log in, view currently rented cars, and \r\nprocess new car rental \r\nbookings.\r\n";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            lblDescription.Click += label1_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = SystemColors.ControlLightLight;
            btnContinue.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = SystemColors.ControlText;
            btnContinue.Location = new Point(229, 351);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(149, 33);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // SplashForm
            // 
            AcceptButton = btnContinue;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(610, 534);
            Controls.Add(btnContinue);
            Controls.Add(picCar);
            Controls.Add(lblDescription);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SplashForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private Label lblWelcome;
        private Label lblSubtitle;
        private PictureBox picCar;
        private Label lblDescription;
        private Button btnContinue;
    }
}