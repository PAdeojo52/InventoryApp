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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IncorrectEmailLabel = new System.Windows.Forms.Label();
            this.IncorrectPasswordLabel = new System.Windows.Forms.Label();
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
            this.StatusBar.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(329, 245);
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
            this.RegisterLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(290, 104);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(140, 17);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Press Below to Login";
            this.LoginLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(329, 348);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
           // this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 8;
            // 
            // IncorrectEmailLabel
            // 
            this.IncorrectEmailLabel.AutoSize = true;
            this.IncorrectEmailLabel.Location = new System.Drawing.Point(622, 149);
            this.IncorrectEmailLabel.Name = "IncorrectEmailLabel";
            this.IncorrectEmailLabel.Size = new System.Drawing.Size(0, 17);
            this.IncorrectEmailLabel.TabIndex = 9;
            // 
            // IncorrectPasswordLabel
            // 
            this.IncorrectPasswordLabel.AutoSize = true;
            this.IncorrectPasswordLabel.Location = new System.Drawing.Point(622, 201);
            this.IncorrectPasswordLabel.Name = "IncorrectPasswordLabel";
            this.IncorrectPasswordLabel.Size = new System.Drawing.Size(0, 17);
            this.IncorrectPasswordLabel.TabIndex = 10;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IncorrectPasswordLabel);
            this.Controls.Add(this.IncorrectEmailLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PasswordLoginLabel);
            this.Controls.Add(this.EmailLoginLabel);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.StatusBar);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label IncorrectEmailLabel;
        private System.Windows.Forms.Label IncorrectPasswordLabel;
    }
}