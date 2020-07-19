using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.Forms.Settings
{
    public partial class FormAccountSettings : Form
    {
        private FormMainMenu formMainMenu;
        public FormAccountSettings(FormMainMenu fmm)
        {
            InitializeComponent();
            this.formMainMenu = fmm;
            UserIDLabel.Text = formMainMenu.id;
            FirstNameLabel.Text = formMainMenu.fname;
            LastNameLabel.Text = formMainMenu.lname;
            EmailLabel.Text = formMainMenu.UserEmail;
            PhoneNumberLabel.Text = formMainMenu.phone;
            CurrentFineLabel.Text = "$"+ formMainMenu.fine;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAccountSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
