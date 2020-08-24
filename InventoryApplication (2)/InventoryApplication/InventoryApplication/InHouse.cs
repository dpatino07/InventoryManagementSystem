using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication
{
    public class InHouse : Part
    {

        // Prop for MachineId
        public int MachineID { get; set; }

        public InHouse(int PartID, string Name, int InStock, decimal Price, int Max, int Min)
            : base(PartID, Name, InStock, Price, Max, Min)
        {

        }
        public InHouse(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
            : base(partID, name, inStock, price, max, min)
        {
            MachineID = machineID;
        }
    }
}
