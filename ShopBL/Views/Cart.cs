using ShopBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBL.Views
{
    public class Cart
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OdrerDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public int AmountQuantity
        {
            get
            {
                if (OrderDetails.Count != 0)
                {
                    return OrderDetails.Select(p => p.Quantity.Value).Sum();
                }
                else
                {
                    return 0;
                }
            }
        }
        public decimal? AmountPrice
        {
            get
            {
                if (OrderDetails.Count != 0)
                {
                    return OrderDetails.Select(p => p.Price.Value * p.Quantity.Value).Sum();
                }
                else
                {
                    return 0;
                }
            }
        }
        public Cart()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}
