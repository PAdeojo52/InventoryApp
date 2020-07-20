using InventoryApp.Forms.LoginForm;
using InventoryLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Text = "Dashboard";
        }

        public FormDashboard(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            emailBox.Focus();
            this.formMainMenu = formMainMenu;
            Text = "Dashboard";
        }
        /* cutting input validations for time
         * public  bool ValidateEmail(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
*/
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if(emailBox.Text.Trim() == "" || PWBox.Text.Trim() == "")
            {
                //May Edit this later
                MessageBox.Show("Incorrect Email or Password, Please Try Again", "Error");
            }
            else
            {

                /*
                 * table.rows[rowindex][columnname]
                 * table.rows[rowindex][columnindex]
                 *  foreach(DataRow row in YourDataTable.Rows)
 { 
                 * 
                 * */
                //UserSetup LoginConnector = new UserSetup();
               var loginGrab =  UserSetup.Login(emailBox.Text,PWBox.Text);

                if (!loginGrab.Equals("_failedLogin")) 
                {
                    formMainMenu.UserEmail = loginGrab;
                    var dt = UserSetup.GetAccount(loginGrab);

                    var id = dt.Rows[0][0];
                    var fname = dt.Rows[0][1];
                    var lname = dt.Rows[0][2];
                    var email = dt.Rows[0][3];
                    var phone = dt.Rows[0][4];
                    var fine = dt.Rows[0][5];
                    formMainMenu.id = id.ToString();
                    formMainMenu.fname = fname.ToString();
                    formMainMenu.lname = lname.ToString();
                    formMainMenu.UserEmail = email.ToString();
                    formMainMenu.phone = phone.ToString();
                    formMainMenu.fine = fine.ToString();
                    formMainMenu.LoginWelcomeMessage(fname.ToString(), lname.ToString());
                    formMainMenu.isLoggedIn = true;
                   
                    formMainMenu.openChildForm(new LoggedInDashboardForm());
                }
                //MessageBox.Show("Login Failed");
                //.
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
