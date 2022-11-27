using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBL.Views
{
    public class ProductListBoxView
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{ItemCode} {Description} {Price}";
        }
    }
}
