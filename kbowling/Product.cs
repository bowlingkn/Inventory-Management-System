using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Xml.Linq;

namespace kbowling
{
    public class Product
    {
        public static int selectedProductIndex { get; set; }
        public static BindingList<Part> partList = new BindingList<Part> { };
        //public static BindingList<Part> PartList { get { return partList; } set { partList = value; } }


        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts = new BindingList<Part> { };
        
        // constructors
        public Product() { }
        public Product(string name, decimal price, int inStock, int min, int max)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;

            ProductID = Inventory.ProductCountID;
        }
        public Product (string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;

            ProductID = Inventory.ProductCountID;
        }
        public Product (int productID, string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;
        }

        public void addAssociatedPart(Part part)
           {
            AssociatedParts.Add(part);
           }

        public bool removeAssociatedPart(int partID)
        {
           // var toRemove = AssociatedParts.Single(r=>r.PartID == partID);
            //return AssociatedParts.Remove(toRemove);
            for (int i=0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    Part toRemove = AssociatedParts[i];
                    return AssociatedParts.Remove(toRemove);
                }
            }
            return false;
        }
          
    }
}
