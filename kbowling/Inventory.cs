using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kbowling
{
    public static class Inventory
    {
        public static int PartCountID = 100;
        public static int ProductCountID = 1200;

        public static BindingList<Product> Products = new BindingList<Product> { };
        public static BindingList<Part> AllParts = new BindingList<Part> { }; 


        //  Product Methods -----------------------------------------------------
        public static void AddProduct(Product newProduct)
        {
            Products.Add(newProduct);
            ProductCountID++;
        } 
        public static bool RemoveProduct(int productID)
        {
           for (int i=0; i<Products.Count; i++)
            {
               if  (Products[i].ProductID == productID)
                {
                    Product toRemove = Products[i];
                    return Products.Remove(toRemove);
                }
            }

           return false;    //if loop does not find a product
        }        
        public static void UpdateProduct(int productID, Product product)
        {
            for (int i=0; i<Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == productID)
                {
                    Inventory.Products[i] = product;
                }
            }
        }
        public static Product LookupProduct(int productID)
        {
            for (int i=0; i<Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == productID)
                {
                    return Inventory.Products[i];
                }
            }

            return null;    //if no match found
        }

        // Part Methods ---------------------------------------------------------
        public static void AddPart(Part newPart)
        {
            AllParts.Add(newPart);
            PartCountID++;
        }
        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }
        public static void UpdatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
               if (Inventory.AllParts[i].PartID == partID)
               {
                   Inventory.AllParts[i] = part;
               }
            }
        }
        public static Part LookupPart(int partID)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID == partID)
                {
                    return Inventory.AllParts[i];
                }
            }
            return null;    // if no match found
        }
        

    }
}
