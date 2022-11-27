using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBL.Views
{
    public class CartViewProduct
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public CartViewProduct()
        {

        }
        public CartViewProduct(string itemCode, string description, decimal price)
        {
            ItemCode = itemCode;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ItemCode} {Description} {Price} {Quantity}";
        }
    }
}
