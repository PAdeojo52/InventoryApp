﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using InventoryApp.Forms;
using InventoryApp.Forms.Dashboard;
using InventoryApp.Forms.LoginForm;
using InventoryApp.Forms.Settings;
using InventoryLibrary;
using InventoryLibrary.Models;

namespace InventoryApp
{
    public partial class FormMainMenu : Form
    {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string UserEmail { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string id { get; set; }
        public string phone { get; set; }
        public string fine { get; set; }
        
        public bool isLoggedIn { get; set; }
        public List<EquipmentModel> equipment = new List<EquipmentModel>();
        public List<UserModel> user = new List<UserModel>();
        

        public Form CurrentChildForm { get => currentChildForm; set => currentChildForm = value; }

        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            isLoggedIn = false;


            //form remove the header
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            //set max size of the form 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            LogOutBtn.Hide();

            //Hides the label
            WelcomeLabel.Hide();
            Settings.Hide();


           
        }

        //struct of colors
        private struct RGBColors
        {
            //Fill in later
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon ChildForme
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                   



            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.HotTrack;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

       
        //Change Buttoon colors later

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Cyan);
            if (isLoggedIn == true)
            {

                openChildForm(new LoggedInDashboardForm());

            }
            else
            {
                openChildForm(new FormDashboard(this));
            }
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            FormMainMenu FMM = new FormMainMenu();
            FMM.openChildForm(new FormDashboard());
        }

        private void AccountInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Peru);
            if (isLoggedIn == true)
            {

                openChildForm(new FormAccountSettings(this));
            }
            else
            {
                openChildForm(new FormNotLoggedIn());
            }

        }
       
        private void Settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Purple);
            if (isLoggedIn == true)
            {
                
                openChildForm(new FormSettings());
            }
            else
            {
                openChildForm(new FormNotLoggedIn());
            }
        }

        private void Checkin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            if (isLoggedIn == true)
            {
                openChildForm(new FormCheckin(this));
            }
            else
            {
                openChildForm(new FormNotLoggedIn());
            }
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Yellow);
            openChildForm(new FormCheckout(this));
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Magenta);
            openChildForm(new FormStock(this));
            
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        //Needs some work on the reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        public void btnHomeChild_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;


            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkMagenta;
            lblTitleChildForm.Text = "Home";
            //throw new NotImplementedException();
        }

        public void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        public void LoginWelcomeMessage(string firstname , string lastname)
        {
            WelcomeLabel.Show();
            WelcomeLabel.Text = "Welcome";
            LoginLabel.Text = firstname + " " + lastname;
            LogOutBtn.Show();
            
            
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            id = "";
            fname = "";
            lname = "";
            UserEmail = "";
            phone = "";
            fine = "";
            //  LoginWelcomeMessage(fname.ToString(), lname.ToString());
            WelcomeLabel.Hide();
            LoginLabel.Hide();
            isLoggedIn = false;
            LogOutBtn.Hide();

           openChildForm(new FormDashboard(this));
        }


        //Draggin gitle form form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwind, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

       
    }
}
