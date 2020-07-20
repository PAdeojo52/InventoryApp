namespace InventoryApp.Forms
{
    partial class FormCheckin
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
            this.CheckedInBox = new System.Windows.Forms.ListBox();
            this.CheckinBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // CheckedInBox
            // 
            this.CheckedInBox.FormattingEnabled = true;
            this.CheckedInBox.ItemHeight = 16;
            this.CheckedInBox.Location = new System.Drawing.Point(552, 22);
            this.CheckedInBox.Name = "CheckedInBox";
            this.CheckedInBox.Size = new System.Drawing.Size(271, 356);
            this.CheckedInBox.TabIndex = 1;
            this.CheckedInBox.SelectedIndexChanged += new System.EventHandler(this.CheckedInBox_SelectedIndexChanged);
            // 
            // CheckinBtn
            // 
            this.CheckinBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CheckinBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CheckinBtn.IconColor = System.Drawing.Color.Black;
            this.CheckinBtn.IconSize = 16;
            this.CheckinBtn.Location = new System.Drawing.Point(396, 314);
            this.CheckinBtn.Name = "CheckinBtn";
            this.CheckinBtn.Rotation = 0D;
            this.CheckinBtn.Size = new System.Drawing.Size(141, 64);
            this.CheckinBtn.TabIndex = 5;
            this.CheckinBtn.Text = "Check In";
            this.CheckinBtn.UseVisualStyleBackColor = true;
            this.CheckinBtn.Click += new System.EventHandler(this.CheckinBtn_Click);
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.CheckinBtn);
            this.Controls.Add(this.CheckedInBox);
            this.Name = "FormCheckin";
            this.Text = "FormCheckin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox CheckedInBox;
        private FontAwesome.Sharp.IconButton CheckinBtn;
    }
}