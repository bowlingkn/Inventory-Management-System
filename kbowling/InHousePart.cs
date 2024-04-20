using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kbowling
{
    public class InhousePart : Part
    {
        public int MachineID;

        //constructor
        public InhousePart(string name, decimal price, 
                     int inStock, int min, int max, int machineID) : 
                     base(name, price, inStock, min, max)
        {
            MachineID = machineID;
            PartID = Inventory.PartCountID;
        }
        public InhousePart(int partID, string name, decimal price,
                     int inStock, int min, int max, int machineID) :
                     base(name, price, inStock, min, max)
        {
            MachineID = machineID;
            PartID = partID;

        }
    }
}
