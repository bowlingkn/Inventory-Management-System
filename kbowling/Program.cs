using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kbowling
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
     //   [STAThread]
        static void Main()
        {
          


            //  base parts and products for testing -------------------------------------
            Inventory.AddProduct(new Product("bicycle", 3.56M, 3, 2, 15));
            Inventory.AddProduct(new Product("tricycle", 4.95M, 7, 2, 15));
            Inventory.AddProduct(new Product("motorcycle", 2000.99m, 1, 1, 5));

            Inventory.AddPart(new InhousePart("wheel", 5.67m, 6, 4, 10, 42));
            Inventory.AddPart(new InhousePart("frame", 3.45m, 3, 2, 8, 576));
            Inventory.AddPart(new InhousePart("handelbar", 3.45m, 8, 2, 8, 560));
            Inventory.AddPart(new OutsourcedPart("bell", 3.45m, 8, 3, 15, "abc"));
            Inventory.AddPart(new OutsourcedPart("engine", 3.45m, 1, 1, 5, "abc"));

            Inventory.Products[0].addAssociatedPart(Inventory.AllParts[0]);
            Inventory.Products[0].addAssociatedPart(Inventory.AllParts[0]);
            Inventory.Products[1].addAssociatedPart(Inventory.AllParts[1]);
            Inventory.Products[2].addAssociatedPart(Inventory.AllParts[3]);

            Application.Run(new Form1());
            
        }
    }
}
