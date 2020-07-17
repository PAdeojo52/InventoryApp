using InventoryApp.Forms.LoginForm;
using InventoryLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.Forms
{
    public partial class FormDashboard : Form
    {
        private FormMainMenu formMainMenu;

        public FormDashboard()
        {
            InitializeComponent();
            emailBox.Focus();
        }

        public FormDashboard(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            emailBox.Focus();
            this.formMainMenu = formMainMenu;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if(emailBox.Text.Trim() == "" || PWBox.Text.Trim() == "")
            {
                //May Edit this later
                MessageBox.Show("Incorrect Email or Password, Please Try Again", "Error");
            }
            else
            {
                //UserSetup LoginConnector = new UserSetup();
                UserSetup.Login(emailBox.Text,PWBox.Text);
            }
            //check lofin info

           // this.formMainMenu.btnHomeChild_Click(sender,e);

            
            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //clears up the boxs on the page
            emailBox.Clear();
            PWBox.Clear();
            //moves cursor to the box
            emailBox.Focus();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.formMainMenu.openChildForm(new FormRegister(formMainMenu));
        }
    }
}
