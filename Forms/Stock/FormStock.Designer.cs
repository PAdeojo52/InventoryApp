namespace InventoryApp.Forms
{
    partial class FormStock
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
            this.EquipmentListBox = new System.Windows.Forms.ListBox();
            this.DisplayAllBTN = new FontAwesome.Sharp.IconButton();
            this.DisplayDesktopBtn = new FontAwesome.Sharp.IconButton();
            this.DisplayLaptopBtn = new FontAwesome.Sharp.IconButton();
            this.DisplayPhoneBtn = new FontAwesome.Sharp.IconButton();
            this.CheckOutBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // EquipmentListBox
            // 
            this.EquipmentListBox.FormattingEnabled = true;
            this.EquipmentListBox.ItemHeight = 16;
            this.EquipmentListBox.Location = new System.Drawing.Point(483, 22);
            this.EquipmentListBox.Name = "EquipmentListBox";
            this.EquipmentListBox.Size = new System.Drawing.Size(274, 340);
            this.EquipmentListBox.TabIndex = 0;
            this.EquipmentListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DisplayAllBTN
            // 
            this.DisplayAllBTN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DisplayAllBTN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DisplayAllBTN.IconColor = System.Drawing.Color.Black;
            this.DisplayAllBTN.IconSize = 16;
            this.DisplayAllBTN.Location = new System.Drawing.Point(60, 22);
            this.DisplayAllBTN.Name = "DisplayAllBTN";
            this.DisplayAllBTN.Rotation = 0D;
            this.DisplayAllBTN.Size = new System.Drawing.Size(141, 64);
            this.DisplayAllBTN.TabIndex = 1;
            this.DisplayAllBTN.Text = "Display All";
            this.DisplayAllBTN.UseVisualStyleBackColor = true;
            this.DisplayAllBTN.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // DisplayDesktopBtn
            // 
            this.DisplayDesktopBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DisplayDesktopBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DisplayDesktopBtn.IconColor = System.Drawing.Color.Black;
            this.DisplayDesktopBtn.IconSize = 16;
            this.DisplayDesktopBtn.Location = new System.Drawing.Point(60, 110);
            this.DisplayDesktopBtn.Name = "DisplayDesktopBtn";
            this.DisplayDesktopBtn.Rotation = 0D;
            this.DisplayDesktopBtn.Size = new System.Drawing.Size(141, 64);
            this.DisplayDesktopBtn.TabIndex = 2;
            this.DisplayDesktopBtn.Text = "Display Desktop";
            this.DisplayDesktopBtn.UseVisualStyleBackColor = true;
            this.DisplayDesktopBtn.Click += new System.EventHandler(this.DisplayDesktopBtn_Click);
            // 
            // DisplayLaptopBtn
            // 
            this.DisplayLaptopBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DisplayLaptopBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DisplayLaptopBtn.IconColor = System.Drawing.Color.Black;
            this.DisplayLaptopBtn.IconSize = 16;
            this.DisplayLaptopBtn.Location = new System.Drawing.Point(60, 206);
            this.DisplayLaptopBtn.Name = "DisplayLaptopBtn";
            this.DisplayLaptopBtn.Rotation = 0D;
            this.DisplayLaptopBtn.Size = new System.Drawing.Size(141, 64);
            this.DisplayLaptopBtn.TabIndex = 3;
            this.DisplayLaptopBtn.Text = "Display Laptop";
            this.DisplayLaptopBtn.UseVisualStyleBackColor = true;
            this.DisplayLaptopBtn.Click += new System.EventHandler(this.DisplayLaptopBtn_Click);
            // 
            // DisplayPhoneBtn
            // 
            this.DisplayPhoneBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DisplayPhoneBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DisplayPhoneBtn.IconColor = System.Drawing.Color.Black;
            this.DisplayPhoneBtn.IconSize = 16;
            this.DisplayPhoneBtn.Location = new System.Drawing.Point(60, 298);
            this.DisplayPhoneBtn.Name = "DisplayPhoneBtn";
            this.DisplayPhoneBtn.Rotation = 0D;
            this.DisplayPhoneBtn.Size = new System.Drawing.Size(141, 64);
            this.DisplayPhoneBtn.TabIndex = 4;
            this.DisplayPhoneBtn.Text = "Display Phone";
            this.DisplayPhoneBtn.UseVisualStyleBackColor = true;
            this.DisplayPhoneBtn.Click += new System.EventHandler(this.DisplayPhoneBtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CheckOutBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CheckOutBtn.IconColor = System.Drawing.Color.Black;
            this.CheckOutBtn.IconSize = 16;
            this.CheckOutBtn.Location = new System.Drawing.Point(336, 298);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Rotation = 0D;
            this.CheckOutBtn.Size = new System.Drawing.Size(141, 64);
            this.CheckOutBtn.TabIndex = 5;
            this.CheckOutBtn.Text = "Check Out";
            this.CheckOutBtn.UseVisualStyleBackColor = true;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.DisplayPhoneBtn);
            this.Controls.Add(this.DisplayLaptopBtn);
            this.Controls.Add(this.DisplayDesktopBtn);
            this.Controls.Add(this.DisplayAllBTN);
            this.Controls.Add(this.EquipmentListBox);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EquipmentListBox;
        private FontAwesome.Sharp.IconButton DisplayAllBTN;
        private FontAwesome.Sharp.IconButton DisplayDesktopBtn;
        private FontAwesome.Sharp.IconButton DisplayLaptopBtn;
        private FontAwesome.Sharp.IconButton DisplayPhoneBtn;
        private FontAwesome.Sharp.IconButton CheckOutBtn;
    }
}