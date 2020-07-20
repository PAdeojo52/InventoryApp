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
    public partial class FormCheckin : Form
    {
        List<EquipmentModel> equipment = new List<EquipmentModel>();
        private FormMainMenu formMainMenu;
        public FormCheckin(FormMainMenu fmm)
        {
            InitializeComponent();
            this.formMainMenu = fmm;
            LoadCheckedoutEquipment();
            Text = "Check In";

        }

       public void WireUpCheckedInBox()
        {
            CheckedInBox.DataSource = null;
            CheckedInBox.DataSource = equipment;
            CheckedInBox.DisplayMember = "MakeModel";
        }
        public void LoadCheckedoutEquipment()
        {
            CheckedInBox.DataSource = null;
            CheckedInBox.Items.Clear();
            equipment = EquipmentSetup.LoadCheckedOutEquipment(formMainMenu.id);
            // activeFilter = "All";
            WireUpCheckedInBox();
        }

        private void CheckinBtn_Click(object sender, EventArgs e)
        {
           
            if (CheckedInBox.Items.Count>0)
            {
                int checkedIndex = CheckedInBox.SelectedIndex;
                string macAddress = equipment[checkedIndex].MacAddress;

                EquipmentSetup.CheckIn(macAddress);


                LoadCheckedoutEquipment();
            }
            else
            {
                MessageBox.Show("List Empty", "Eclipsa");
            }
        }

        private void CheckedInBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
