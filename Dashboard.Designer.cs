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
            this.btnAboutme = new Guna.UI2.WinForms.Guna2Button();
            this.btnContact = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Home1 = new CodeCrafters.UC_Control.UC_Home();
            this.uC_Aboutme1 = new CodeCrafters.UC_Control.UC_Aboutme();
            this.uC_Contact1 = new CodeCrafters.UC_Control.UC_Contact();
            this.panel1.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnlMoving);
            this.panel1.Controls.Add(this.btnAboutme);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 128);
            this.panel1.TabIndex = 2;
            // 
            // pnlMoving
            // 
            this.pnlMoving.BackColor = System.Drawing.Color.Cyan;
            this.pnlMoving.BorderRadius = 30;
            this.pnlMoving.Location = new System.Drawing.Point(13, 110);
            this.pnlMoving.Name = "pnlMoving";
            this.pnlMoving.Size = new System.Drawing.Size(376, 5);
            this.pnlMoving.TabIndex = 0;
            // 
            // btnAboutme
            // 
            this.btnAboutme.BorderRadius = 18;
            this.btnAboutme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAboutme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAboutme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAboutme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAboutme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnAboutme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutme.ForeColor = System.Drawing.Color.White;
            this.btnAboutme.Location = new System.Drawing.Point(535, 23);
            this.btnAboutme.Name = "btnAboutme";
            this.btnAboutme.Size = new System.Drawing.Size(376, 81);
            this.btnAboutme.TabIndex = 3;
            this.btnAboutme.Text = "About Me";
            this.btnAboutme.Click += new System.EventHandler(this.btnAboutme_Click);
            // 
            // btnContact
            // 
            this.btnContact.BorderRadius = 18;
            this.btnContact.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnContact.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Location = new System.Drawing.Point(1047, 23);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(376, 81);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact";
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 18;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(205)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(13, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(376, 81);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDashBoard.Controls.Add(this.uC_Home1);
            this.pnlDashBoard.Controls.Add(this.uC_Aboutme1);
            this.pnlDashBoard.Controls.Add(this.uC_Contact1);
            this.pnlDashBoard.Location = new System.Drawing.Point(12, 205);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(1476, 646);
            this.pnlDashBoard.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_Home1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Home1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1476, 646);
            this.uC_Home1.TabIndex = 2;
            // 
            // uC_Aboutme1
            // 
            this.uC_Aboutme1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_Aboutme1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Aboutme1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Aboutme1.Name = "uC_Aboutme1";
            this.uC_Aboutme1.Size = new System.Drawing.Size(1476, 646);
            this.uC_Aboutme1.TabIndex = 1;
            // 
            // uC_Contact1
            // 
            this.uC_Contact1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_Contact1.Location = new System.Drawing.Point(-3, -3);
            this.uC_Contact1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Contact1.Name = "uC_Contact1";
            this.uC_Contact1.Size = new System.Drawing.Size(1476, 646);
            this.uC_Contact1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1500, 863);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Panel pnlDashBoard;
        private Guna.UI2.WinForms.Guna2Button btnAboutme;
        private Guna.UI2.WinForms.Guna2Button btnContact;
        private Guna.UI2.WinForms.Guna2Panel pnlMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_Control.UC_Contact uC_Contact1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_Control.UC_Home uC_Home1;
        private UC_Control.UC_Aboutme uC_Aboutme1;
    }
}