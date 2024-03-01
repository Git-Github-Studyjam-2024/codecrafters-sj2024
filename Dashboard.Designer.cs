namespace CodeCrafters
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCustomerRegister = new Guna.UI2.WinForms.Guna2Button();
            this.btncheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.uC_Home1 = new CodeCrafters.UC_Control.UC_Home();
            this.panel1.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1450, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnlMoving);
            this.panel1.Controls.Add(this.btnCustomerRegister);
            this.panel1.Controls.Add(this.btncheckout);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(11, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 128);
            this.panel1.TabIndex = 2;
            // 
            // pnlMoving
            // 
            this.pnlMoving.BackColor = System.Drawing.Color.White;
            this.pnlMoving.BorderRadius = 30;
            this.pnlMoving.Location = new System.Drawing.Point(13, 110);
            this.pnlMoving.Name = "pnlMoving";
            this.pnlMoving.Size = new System.Drawing.Size(376, 5);
            this.pnlMoving.TabIndex = 0;
            // 
            // btnCustomerRegister
            // 
            this.btnCustomerRegister.BorderRadius = 18;
            this.btnCustomerRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnCustomerRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegister.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegister.Location = new System.Drawing.Point(535, 23);
            this.btnCustomerRegister.Name = "btnCustomerRegister";
            this.btnCustomerRegister.Size = new System.Drawing.Size(376, 81);
            this.btnCustomerRegister.TabIndex = 3;
            this.btnCustomerRegister.Text = "About Me";
            // 
            // btncheckout
            // 
            this.btncheckout.BorderRadius = 18;
            this.btncheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btncheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.Location = new System.Drawing.Point(1047, 23);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(376, 81);
            this.btncheckout.TabIndex = 1;
            this.btncheckout.Text = "Contact";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(13, 23);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(376, 81);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Home";
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDashBoard.Controls.Add(this.uC_Home1);
            this.pnlDashBoard.Location = new System.Drawing.Point(12, 205);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(1476, 646);
            this.pnlDashBoard.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(11, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(225, 50);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackColor = System.Drawing.Color.White;
            this.uC_Home1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Home1.Location = new System.Drawing.Point(-5, -3);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1476, 646);
            this.uC_Home1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1500, 863);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panel1.ResumeLayout(false);
            this.pnlDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel pnlDashBoard;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegister;
        private Guna.UI2.WinForms.Guna2Button btncheckout;
        private Guna.UI2.WinForms.Guna2Panel pnlMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private UC_Control.UC_Home uC_Home1;
    }
}