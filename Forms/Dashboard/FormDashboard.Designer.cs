namespace InventoryApp.Forms
{
    partial class FormDashboard
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
            this.StatusBar = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.EmailLoginLabel = new System.Windows.Forms.Label();
            this.PasswordLoginLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Location = new System.Drawing.Point(263, 56);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(208, 17);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "You are currently not Logged in";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(329, 250);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(290, 295);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(158, 17);
            this.RegisterLabel.TabIndex = 2;
            this.RegisterLabel.Text = "Press Below to Register";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(290, 104);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(140, 17);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Press Below to Login";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(329, 331);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // EmailLoginLabel
            // 
            this.EmailLoginLabel.AutoSize = true;
            this.EmailLoginLabel.Location = new System.Drawing.Point(236, 149);
            this.EmailLoginLabel.Name = "EmailLoginLabel";
            this.EmailLoginLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLoginLabel.TabIndex = 5;
            this.EmailLoginLabel.Text = "Email";
            // 
            // PasswordLoginLabel
            // 
            this.PasswordLoginLabel.AutoSize = true;
            this.PasswordLoginLabel.Location = new System.Drawing.Point(236, 203);
            this.PasswordLoginLabel.Name = "PasswordLoginLabel";
            this.PasswordLoginLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLoginLabel.TabIndex = 6;
            this.PasswordLoginLabel.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(355, 149);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(194, 22);
            this.emailBox.TabIndex = 7;
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(355, 198);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(194, 22);
            this.PWBox.TabIndex = 8;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.PasswordLoginLabel);
            this.Controls.Add(this.EmailLoginLabel);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.StatusBar);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusBar;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label EmailLoginLabel;
        private System.Windows.Forms.Label PasswordLoginLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox PWBox;
    }
}