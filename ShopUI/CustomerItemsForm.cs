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
    public partial class CustomerItemsForm : Form
    {
        ShopDbContext dbContext;
        public bool Button1IsClicked = false;
        public Customer Customer;
        public CustomerItemsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button1IsClicked = true;
            dbContext = new ShopDbContext();
            if (ItemsIsCorected())
            {
                Customer = new Customer();
                Customer.CustomerName = textBoxName.Text;
                Customer.Phone = textBoxPhone.Text;
                Customer.Adress1 = textBoxAdress1.Text;
                Customer.Adress2 = textBoxAdress2.Text;
                Customer.CreditLimit = Convert.ToDecimal(textBoxCredirLimit.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Not correct dates", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }
        private bool ItemsIsCorected()
        {
            decimal n;
            return textBoxName != null
                   && textBoxPhone != null
                   && textBoxAdress1 != null
                   && textBoxAdress2 != null
                   && textBoxCredirLimit != null
                   && decimal.TryParse(textBoxCredirLimit.Text, out n);
        }
    }
}
