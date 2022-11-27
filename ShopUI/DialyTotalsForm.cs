using Microsoft.EntityFrameworkCore;
using ShopBL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI
{
    public partial class DialyTotalsForm : Form
    {
        ShopDbContext dbContext;
        private BindingList<Product> productsList = new BindingList<Product>();

        public DialyTotalsForm()
        {
            InitializeComponent();
            dbContext = new ShopDbContext();
        }

        private void DialyTotals_Load()
        {
            SetTotalAmountToday();
            SetTotalQunatitybyItemCodeToDay();
            SetMostSoldToday();
        }

        private void SetMostSoldToday()
        {
            var mostSoldtItem = (from order in dbContext.Orders
                                        join orderDetail in dbContext.OrderDetails
                                        on order.OrderId equals orderDetail.OrderId
                                        where order.OdrerDate.Value.Year == DateTime.Today.Year
                                              && order.OdrerDate.Value.Month == DateTime.Today.Month
                                              && order.OdrerDate.Value.Day == DateTime.Today.Day
                                        group orderDetail by orderDetail.ProductId into od
                                        select new { ItemCode = od.Key, Count = od.Select(o => o.Quantity).Sum()})
                                        .ToList()
                                        .OrderByDescending(i => i.Count)
                                        .FirstOrDefault();
            if (mostSoldtItem != null)
            {
                var mostSoldPrductDescription = (from product in productsList
                                                 where product.ProductId == mostSoldtItem.ItemCode
                                                 select new { product.Description }).FirstOrDefault();

                if(mostSoldPrductDescription != null)
                    labelMostSoldProduct.Text += $": Item Code: {mostSoldtItem.ItemCode}, Description: {mostSoldPrductDescription.Description}";
            }
        }

        private void SetTotalQunatitybyItemCodeToDay()
        {
            dataGridView1.DataSource = (from order in dbContext.Orders
                                       join orderDetail in dbContext.OrderDetails
                                       on order.OrderId equals orderDetail.OrderId
                                       where order.OdrerDate.Value.Year == DateTime.Today.Year
                                             && order.OdrerDate.Value.Month == DateTime.Today.Month
                                             && order.OdrerDate.Value.Day == DateTime.Today.Day
                                       group orderDetail by orderDetail.ProductId into od
                                       select new { od.Key, Count = od.Select(o => o.Quantity).Sum() }).ToList();
        }

       
        private void SetTotalAmountToday()
        {
            decimal totalAmountToday = (from order in dbContext.Orders
                                        join orderDetail in dbContext.OrderDetails
                                        on order.OrderId equals orderDetail.OrderId
                                        where order.OdrerDate.Value.Year == DateTime.Today.Year
                                              && order.OdrerDate.Value.Month == DateTime.Today.Month
                                              && order.OdrerDate.Value.Day == DateTime.Today.Day
                                        select orderDetail.Price.Value * orderDetail.Quantity.Value).Sum();
            labelTotalAmount.Text += $": {totalAmountToday}";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dbContext.Products.Load();

           productsList = dbContext.Products.Local.ToBindingList();
           DialyTotals_Load();
        }
    }
}
