namespace InventoryApp.Forms.Dashboard
{
    partial class FormNotLoggedIn
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
            this.NotLoggedInLabel = new System.Windows.Forms.Label();
            this.GotToDashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotLoggedInLabel
            // 
            this.NotLoggedInLabel.AutoSize = true;
            this.NotLoggedInLabel.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotLoggedInLabel.Location = new System.Drawing.Point(219, 73);
            this.NotLoggedInLabel.Name = "NotLoggedInLabel";
            this.NotLoggedInLabel.Size = new System.Drawing.Size(323, 36);
            this.NotLoggedInLabel.TabIndex = 0;
            this.NotLoggedInLabel.Text = "You Are Not Logged In";
            // 
            // GotToDashLabel
            // 
            this.GotToDashLabel.AutoSize = true;
            this.GotToDashLabel.Location = new System.Drawing.Point(271, 159);
            this.GotToDashLabel.Name = "GotToDashLabel";
            this.GotToDashLabel.Size = new System.Drawing.Size(243, 17);
            this.GotToDashLabel.TabIndex = 1;
            this.GotToDashLabel.Text = "Please Go to the Dashboard to Login";
            // 
            // FormNotLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GotToDashLabel);
            this.Controls.Add(this.NotLoggedInLabel);
            this.Name = "FormNotLoggedIn";
            this.Text = "FormNotLoggedIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotLoggedInLabel;
        private System.Windows.Forms.Label GotToDashLabel;
    }
}