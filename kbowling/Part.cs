using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kbowling
{
    public abstract class Part
    {
        public static int selectedPartIndex { get; set; }


        public int PartID { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }  
        public int InStock { get; set; }
        public int Min { get; set; }    
        public int Max { get; set; }
        

        //constructors
        public Part() { }
        public Part(string name, decimal price, int inStock, int min, int max)
        {
            Name = name; 
            Price = price; 
            InStock = inStock; 
            Min = min;
            Max = max;

//            PartID = Inventory.PartCountID;
            
        }

    }
}
