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

namespace InventoryApp.Forms.EquipmentManagement
{
    public partial class FormAddEquipment : Form
    {
        private FormMainMenu formMainMenu;
        public EquipmentSetup setup = new EquipmentSetup(); 
        public FormAddEquipment(FormMainMenu fmm)
        {
            InitializeComponent();
            this.formMainMenu = fmm;
        }
        
        private void BackBtn_Click(object sender, EventArgs e)
        {
            formMainMenu.openChildForm(new FormStock(formMainMenu));
        }

        private void SubmitBTn_Click(object sender, EventArgs e)
        {
            if (MakeBox.Text.Trim() == "" || ModelBox.Text.Trim() == "" || TypeBox.Text.Trim() == "" || MacAddressBox.Text.Trim() == "")
            {
                //May Edit this later
                MessageBox.Show("Missing inputs, Please Try Again", "Error");
            }
            else
            {
                EquipmentModel EModel = new EquipmentModel();
                EModel.Make = MakeBox.Text;
                EModel.Model = ModelBox.Text;
                EModel.Type = TypeBox.Text;
                EModel.MacAddress = MacAddressBox.Text;
                EModel.IsCheckedOut = 0;
                //odel.CheckedOutBy = null;

                EquipmentSetup.CreateEquipment(EModel);

                formMainMenu.openChildForm(new FormStock(formMainMenu));
            }

        }
    }
}
