using InventoryLibrary;
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

namespace InventoryApp.Forms.LoginForm
{
    public partial class FormRegister : Form
    {
        private FormMainMenu formMainMenu;
        public FormRegister()
        {
            InitializeComponent();
        }

        public FormRegister(FormMainMenu formMainMenu)
        {

            InitializeComponent();
            firstNameBox.Focus();
            this.formMainMenu = formMainMenu;
        }

        public void Reset()
        {
            firstNameBox.Clear();
            lastNameBox.Clear();
            emailBox.Clear();
            phoneNumberBox.Clear();
            pwBox.Clear();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(5, 1300);
            UserModel newAccount = new UserModel(id,firstNameBox.Text,lastNameBox.Text,emailBox.Text,phoneNumberBox.Text,
               0.0 , 0 , pwBox.Text);

            UserSetup.CreateUser(newAccount);
        }
    }
}
