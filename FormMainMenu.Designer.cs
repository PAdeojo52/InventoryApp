namespace InventoryApp
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.Account_Information = new FontAwesome.Sharp.IconButton();
            this.Check_In = new FontAwesome.Sharp.IconButton();
            this.Check_Out = new FontAwesome.Sharp.IconButton();
            this.Stock = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.Settings);
            this.panelMenu.Controls.Add(this.Account_Information);
            this.panelMenu.Controls.Add(this.Check_In);
            this.panelMenu.Controls.Add(this.Check_Out);
            this.panelMenu.Controls.Add(this.Stock);
            this.panelMenu.Controls.Add(this.Dashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 620);
            this.panelMenu.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.Settings.IconColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconSize = 32;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 440);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Settings.Rotation = 0D;
            this.Settings.Size = new System.Drawing.Size(220, 60);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Account_Information
            // 
            this.Account_Information.Dock = System.Windows.Forms.DockStyle.Top;
            this.Account_Information.FlatAppearance.BorderSize = 0;
            this.Account_Information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_Information.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Account_Information.ForeColor = System.Drawing.Color.Gainsboro;
            this.Account_Information.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.Account_Information.IconColor = System.Drawing.Color.Gainsboro;
            this.Account_Information.IconSize = 32;
            this.Account_Information.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account_Information.Location = new System.Drawing.Point(0, 380);
            this.Account_Information.Name = "Account_Information";
            this.Account_Information.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Account_Information.Rotation = 0D;
            this.Account_Information.Size = new System.Drawing.Size(220, 60);
            this.Account_Information.TabIndex = 5;
            this.Account_Information.Text = "Account Information";
            this.Account_Information.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account_Information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Account_Information.UseVisualStyleBackColor = true;
            this.Account_Information.Click += new System.EventHandler(this.AccountInfo_Click);
            // 
            // Check_In
            // 
            this.Check_In.Dock = System.Windows.Forms.DockStyle.Top;
            this.Check_In.FlatAppearance.BorderSize = 0;
            this.Check_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_In.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Check_In.ForeColor = System.Drawing.Color.Gainsboro;
            this.Check_In.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.Check_In.IconColor = System.Drawing.Color.Gainsboro;
            this.Check_In.IconSize = 32;
            this.Check_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Check_In.Location = new System.Drawing.Point(0, 320);
            this.Check_In.Name = "Check_In";
            this.Check_In.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Check_In.Rotation = 0D;
            this.Check_In.Size = new System.Drawing.Size(220, 60);
            this.Check_In.TabIndex = 4;
            this.Check_In.Text = "Check In";
            this.Check_In.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Check_In.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Check_In.UseVisualStyleBackColor = true;
            this.Check_In.Click += new System.EventHandler(this.Checkin_Click);
            // 
            // Check_Out
            // 
            this.Check_Out.Dock = System.Windows.Forms.DockStyle.Top;
            this.Check_Out.FlatAppearance.BorderSize = 0;
            this.Check_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_Out.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Check_Out.ForeColor = System.Drawing.Color.Gainsboro;
            this.Check_Out.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.Check_Out.IconColor = System.Drawing.Color.Gainsboro;
            this.Check_Out.IconSize = 32;
            this.Check_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Check_Out.Location = new System.Drawing.Point(0, 260);
            this.Check_Out.Name = "Check_Out";
            this.Check_Out.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Check_Out.Rotation = 0D;
            this.Check_Out.Size = new System.Drawing.Size(220, 60);
            this.Check_Out.TabIndex = 3;
            this.Check_Out.Text = "Check Out";
            this.Check_Out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Check_Out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Check_Out.UseVisualStyleBackColor = true;
            this.Check_Out.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Stock
            // 
            this.Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stock.FlatAppearance.BorderSize = 0;
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Stock.ForeColor = System.Drawing.Color.Gainsboro;
            this.Stock.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.Stock.IconColor = System.Drawing.Color.Gainsboro;
            this.Stock.IconSize = 32;
            this.Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stock.Location = new System.Drawing.Point(0, 200);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Stock.Rotation = 0D;
            this.Stock.Size = new System.Drawing.Size(220, 60);
            this.Stock.TabIndex = 2;
            this.Stock.Text = "Stock";
            this.Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Dashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.Dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.IconSize = 32;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 140);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Dashboard.Rotation = 0D;
            this.Dashboard.Size = new System.Drawing.Size(220, 60);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::InventoryApp.Properties.Resources.Eclipsa_Logo_Raw;
            this.btnHome.Location = new System.Drawing.Point(12, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(169, 82);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTitleBar.Controls.Add(this.BtnMin);
            this.panelTitleBar.Controls.Add(this.BtnExit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(901, 90);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.BtnMin.IconColor = System.Drawing.Color.Black;
            this.BtnMin.IconSize = 56;
            this.BtnMin.Location = new System.Drawing.Point(732, 3);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(74, 60);
            this.BtnMin.TabIndex = 3;
            this.BtnMin.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnExit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Sith;
            this.BtnExit.IconColor = System.Drawing.Color.Black;
            this.BtnExit.IconSize = 56;
            this.BtnExit.Location = new System.Drawing.Point(824, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0D;
            this.BtnExit.Size = new System.Drawing.Size(74, 60);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(69, 46);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DarkMagenta;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkMagenta;
            this.iconCurrentChildForm.IconSize = 44;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 31);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(45, 44);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 90);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(901, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 99);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(901, 521);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 620);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Dashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton Settings;
        private FontAwesome.Sharp.IconButton Account_Information;
        private FontAwesome.Sharp.IconButton Check_In;
        private FontAwesome.Sharp.IconButton Check_Out;
        private FontAwesome.Sharp.IconButton Stock;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnMin;
    }
}

