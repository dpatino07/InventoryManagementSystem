using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int PartID, string Name, int InStock, decimal Price, int Max, int Min) : base(PartID, Name, InStock, Price, Max, Min)
        {

        }

        public Outsourced(int partID, string name, int inStock, decimal price, int max, int min, string companyName)
            : base(partID, name, inStock, price, max, min)
        {
            CompanyName = companyName;
        }
    }
}
