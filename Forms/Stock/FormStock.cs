using InventoryApp.Forms.EquipmentManagement;
using InventoryLibrary.DataAccess;
using InventoryLibrary.Models;
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
    public partial class FormStock : Form
    {
        List<EquipmentModel> equipment = new List<EquipmentModel>();
        private FormMainMenu formMainMenu;
        public string activeFilter { get; set; }
        public FormStock(FormMainMenu fmm)
        {
            InitializeComponent();
            LoadEquipmentList();
            this.formMainMenu = fmm;
            activeFilter = "All";

            if (formMainMenu.isLoggedIn == false)
            {
                CheckOutBtn.Hide();
            }
            else
            {
                CheckOutBtn.Show();
            }
        }


        public void LoadEquipmentList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadEquipment();
            activeFilter = "All";
            WireUpEquipmentList();
        }

        public void LoadDesktopList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadDesktop();
            activeFilter = "Desktop";
            WireUpEquipmentList();
        }

        public void LoadLaptopList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadLaptop();
            activeFilter = "Laptop";
            WireUpEquipmentList();
        }

        public void LoadPhoneList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadPhone();
            activeFilter = "Phone";
            WireUpEquipmentList(); ;
        }

        public void WireUpEquipmentList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.DataSource = equipment;
            EquipmentListBox.DisplayMember = "MakeModel";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadEquipmentList();
        }

        private void DisplayDesktopBtn_Click(object sender, EventArgs e)
        {
            LoadDesktopList();
        }

        private void DisplayLaptopBtn_Click(object sender, EventArgs e)
        {
            LoadLaptopList();
        }

        private void DisplayPhoneBtn_Click(object sender, EventArgs e)
        {
            LoadPhoneList();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            if (EquipmentListBox.Items.Count > 0)
            {
                int checkedIndex = EquipmentListBox.SelectedIndex;
                string macAddress = equipment[checkedIndex].MacAddress;

                EquipmentSetup.CheckOut(formMainMenu.id, macAddress);

                if (activeFilter.Equals("Desktop"))
                {
                    LoadDesktopList();
                }
                else if (activeFilter.Equals("Laptop"))
                {
                    LoadLaptopList();
                }
                else if (activeFilter.Equals("Phone"))
                {
                    LoadPhoneList();
                }
                else
                {
                    LoadEquipmentList();
                }
            }
            else
            {
                MessageBox.Show("List Empty", "Eclipsa");
            }
        }

        private void AddEqupmentButton_Click(object sender, EventArgs e)
        {
            formMainMenu.openChildForm(new FormAddEquipment(formMainMenu));
        }
    }
}
