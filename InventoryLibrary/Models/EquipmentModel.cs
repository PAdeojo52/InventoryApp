using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models
{
    public class EquipmentModel
    {

        public string MacAddress { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int IsCheckedOut { get; set; }
        public int CheckedOutBy { get; set; }
        public string Type { get; set; }

        public string MakeModel
        {
            get
            {
                return $"{ Make } { Model }";
            }
        }

        public EquipmentModel()
        {

        }
        public EquipmentModel(string macAddress, string make, string model, int isCheckedOut, int checkedOutBy, string type)
        {
            MacAddress = macAddress;
            Make = make;
            Model = model;
            IsCheckedOut = isCheckedOut;
            CheckedOutBy = checkedOutBy;
            Type = type;
        }

        

        
    }
}
