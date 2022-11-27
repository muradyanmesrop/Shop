using ShopBL.Models;
using ShopBL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShopUI
{
    public partial class OrderForm : Form
    {
        ShopDbContext dbContext;
        Cart Cart;
        public OrderForm()
        {
            InitializeComponent();
            Cart = new Cart();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SetCustomersForCombobox();
            SetDataForProductsList();
            SetOrderNBr();
        }

        private void SetOrderNBr()
        {
            int orderNbr = dbContext.Orders.OrderByDescending(o => o.OrderId).Select(o=>o.OrderId).FirstOrDefault();
            labelOrderNbr.Text += $"  {orderNbr + 1}";
            Cart.OrderId = orderNbr;
        }

        private void SetDataForProductsList()
        {
            listBoxProducts.Items.AddRange(dbContext.Products
                                                    .Select(p => 
                                                        new ProductListBoxView
                                                        {
                                                         ItemCode = p.ProductId,
                                                         Description = p.Description,
                                                         Price = p.Price.Value
                                                        })
                                                    .ToArray());
        }

        private void SetCustomersForCombobox()
        {
            dbContext = new ShopDbContext();
            List<string> customerNames = dbContext
                                        .Customers
                                        .Select(customerName => customerName.CustomerName)
                                        .ToList();
            comboBox1.Items.AddRange(customerNames.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerView? customerView = dbContext.Customers
                                                    .Where(customer => customer.CustomerName == comboBox1.SelectedItem.ToString())
                                                    .Select(customer => new CustomerView
                                                    {
                                                        CustomerId = customer.CustomerId,
                                                        CustomerName = customer.CustomerName,
                                                        Phone = customer.Phone,
                                                        Adress1 = customer.Adress1,
                                                        Adress2 = customer.Adress2,
                                                        CreditLimit = customer.CreditLimit.Value
                                                    }).FirstOrDefault();
            if (customerView.Status == "Credit Hold")
            {
                MessageBox.Show("Customer status is Credit hold", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            labeCustomerAdress.Text += $":  {customerView.Adress1}";
        }

        private void listBoxProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is ProductListBoxView product)
            {
                CartViewProduct cartViewProduct = new CartViewProduct(product.ItemCode, product.Description, product.Price);
                ProductCountForm productCountForm = new ProductCountForm();
                if (productCountForm.ShowDialog() == DialogResult.OK)
                {
                    cartViewProduct.Quantity = productCountForm.Quantity;
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.ProductId = cartViewProduct.ItemCode;
                    orderDetail.Price = cartViewProduct.Price;
                    orderDetail.Quantity = cartViewProduct.Quantity;
                    decimal orderDetailCost = dbContext.Products.Where(p => p.ProductId == cartViewProduct.ItemCode).Select(p => p.Cost.Value).FirstOrDefault();
                    Cart.OrderDetails.Add(orderDetail);
                    listBoxOrder.Items.Add(cartViewProduct);
                    lableAmount.Text = $"Amount: {Cart.AmountPrice}";
                    listBoxOrder.Update();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: if order don`t entry customer
            int customerId = dbContext.Customers.Where(c => c.CustomerName == comboBox1.SelectedItem.ToString()).Select(c => c.CustomerId).FirstOrDefault();
            Cart.CustomerId = customerId;
            Order order = new Order();
            order.CustomerId = customerId;
            order.OdrerDate = DateTime.Now;
            foreach (var item in Cart.OrderDetails)
            {
                order.OrderDetails.Add(item);
            }
            dbContext.Orders.Add(order);
            //dbContext.OrderDetails.AddRange(Cart.OrderDetails);
            dbContext.SaveChanges();
            dbContext.Dispose();
        }
    }
}
