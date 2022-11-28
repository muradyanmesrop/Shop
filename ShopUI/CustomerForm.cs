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

namespace ShopUI
{
    public partial class CustomerForm : Form
    {
        ShopDbContext dbContext;
        public CustomerForm()
        {
            InitializeComponent();
            dbContext = new ShopDbContext();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ViewData();
        }
        private void ViewData()
        {
            dataGridView1.DataSource = dbContext.Customers
                                            .Select(customer => new CustomerView
                                            {
                                                CustomerId = customer.CustomerId,
                                                CustomerName = customer.CustomerName,
                                                Phone = customer.Phone,
                                                Adress1 = customer.Adress1,
                                                Adress2 = customer.Adress2,
                                                CreditLimit = customer.CreditLimit.Value
                                            })
                                            .Select(customer => new
                                            {
                                                customer.CustomerName,
                                                customer.Phone,
                                                customer.Adress1,
                                                customer.Adress2,
                                                customer.Status,
                                                customer.CreditLimit
                                            }).ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CustomerItemsForm customerItemsForm = new CustomerItemsForm();

        Fagon:
            if (customerItemsForm.ShowDialog() == DialogResult.OK && customerItemsForm.Customer != null)
            {
                dbContext.Customers.Add(customerItemsForm.Customer);
                dbContext.SaveChanges();
            }
            else
            {
                if (customerItemsForm.Button1IsClicked)
                {
                    customerItemsForm.Button1IsClicked = false;
                    goto Fagon;
                }
            }
            ViewData();
            dataGridView1.Update();
        }
    }
}
