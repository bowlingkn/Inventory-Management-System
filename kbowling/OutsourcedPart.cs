using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kbowling
{
    internal class OutsourcedPart : Part
    {
        
        public string CompanyName;

        //constructor
        public OutsourcedPart(string name, decimal price,
                     int inStock, int min, int max, string companyName) :
                     base(name, price, inStock, min, max)
        {
            CompanyName = companyName;
            PartID = Inventory.PartCountID;
        }
        public OutsourcedPart(int partID, string name, decimal price,
                     int inStock, int min, int max, string companyName) :
                     base(name, price, inStock, min, max)
        {
            CompanyName = companyName;
            PartID = partID;
        }
    }
}
