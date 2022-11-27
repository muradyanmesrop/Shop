using ShopBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBL.Views
{
    public class CustomerView
    {
        private ShopDbContext dbContext;
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public string Adress1 { get; set; }

        public string Adress2 { get; set; }
        public string Status
        {
            get
            {
                dbContext = new ShopDbContext();
                decimal statusSells = (from customer in dbContext.Customers
                                           join order in dbContext.Orders
                                              on customer.CustomerId equals order.CustomerId
                                           join orderDetail in dbContext.OrderDetails
                                              on order.OrderId equals orderDetail.OrderId
                                           where customer.CustomerId == CustomerId
                                           select orderDetail.Price.Value * orderDetail.Quantity.Value).Sum();

                if (statusSells >= CreditLimit)
                {
                    return "Credit Hold";
                }
                else
                {
                    return "Active";
                }
            }
        }

        public decimal? CreditLimit { get; set; }
    }
}
