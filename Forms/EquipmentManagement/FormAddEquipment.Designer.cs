namespace InventoryApp.Forms.EquipmentManagement
{
    partial class FormAddEquipment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.MacAddressBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SubmitBTn = new System.Windows.Forms.Button();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.warningLAbel = new System.Windows.Forms.Label();
            this.WarningLAbel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MacAddress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(244, 239);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(213, 22);
            this.ModelBox.TabIndex = 6;
            // 
            // MacAddressBox
            // 
            this.MacAddressBox.Location = new System.Drawing.Point(244, 328);
            this.MacAddressBox.Name = "MacAddressBox";
            this.MacAddressBox.Size = new System.Drawing.Size(213, 22);
            this.MacAddressBox.TabIndex = 7;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(211, 393);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SubmitBTn
            // 
            this.SubmitBTn.Location = new System.Drawing.Point(418, 393);
            this.SubmitBTn.Name = "SubmitBTn";
            this.SubmitBTn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBTn.TabIndex = 9;
            this.SubmitBTn.Text = "Submit";
            this.SubmitBTn.UseVisualStyleBackColor = true;
            this.SubmitBTn.Click += new System.EventHandler(this.SubmitBTn_Click);
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(244, 155);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(213, 22);
            this.MakeBox.TabIndex = 10;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(244, 81);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(213, 22);
            this.TypeBox.TabIndex = 11;
            // 
            // warningLAbel
            // 
            this.warningLAbel.AutoSize = true;
            this.warningLAbel.Location = new System.Drawing.Point(157, 106);
            this.warningLAbel.Name = "warningLAbel";
            this.warningLAbel.Size = new System.Drawing.Size(409, 17);
            this.warningLAbel.TabIndex = 12;
            this.warningLAbel.Text = "Currently only\' Desktop\' , \'Laptops\' and \'Phones\' are supported.";
            // 
            // WarningLAbel2
            // 
            this.WarningLAbel2.AutoSize = true;
            this.WarningLAbel2.Location = new System.Drawing.Point(157, 123);
            this.WarningLAbel2.Name = "WarningLAbel2";
            this.WarningLAbel2.Size = new System.Drawing.Size(424, 17);
            this.WarningLAbel2.TabIndex = 13;
            this.WarningLAbel2.Text = " Anything other than these will not be shown on the equipment list ";
            // 
            // FormAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WarningLAbel2);
            this.Controls.Add(this.warningLAbel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.SubmitBTn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.MacAddressBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAddEquipment";
            this.Text = "FormAddEquipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox MacAddressBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SubmitBTn;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label warningLAbel;
        private System.Windows.Forms.Label WarningLAbel2;
    }
}