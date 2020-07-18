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
        public FormStock()
        {
            InitializeComponent();
            LoadEquipmentList();
        }


        public void LoadEquipmentList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadEquipment();
            WireUpEquipmentList();
        }

        public void LoadDesktopList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadDesktop();
            WireUpEquipmentList();
        }

        public void LoadLaptopList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadLaptop();
            WireUpEquipmentList();
        }

        public void LoadPhoneList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.Items.Clear();
            equipment = EquipmentSetup.LoadPhone();
            WireUpEquipmentList();
        }

        public void WireUpEquipmentList()
        {
            EquipmentListBox.DataSource = null;
            EquipmentListBox.DataSource = equipment;
            EquipmentListBox.DisplayMember = "MakeModel" ;
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
    }
}
