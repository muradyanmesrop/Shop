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
    public partial class ProductItemsForm : Form
    {
        ShopDbContext? dbContext;
        public Product Product;
        public bool IsClosed = false;
        public ProductItemsForm()
        {
            InitializeComponent();
            dbContext = new ShopDbContext();
            List<string> productTypesNames = dbContext.
                                             ProductTypes.
                                             Select(p => p.ProductTypeName).
                                             ToList();
            comboBoxItemType.Items.AddRange(productTypesNames.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemsIsCorected())
            {
                if (Convert.ToDecimal(textBoxCost.Text) > Convert.ToDecimal(textBoxPrice.Text))
                {
                    MessageBox.Show("Cost shoul be less than Price", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                string selectedProductType = comboBoxItemType.SelectedItem.ToString();
                int productTypeId = dbContext
                                    .ProductTypes
                                    .Where(p => p.ProductTypeName == selectedProductType)
                                    .Select(p => p.ProductTypeId)
                                    .First();

                Product = new Product();
                Product.ProductId = textBoxItemCode.Text;
                Product.Description = textBox2Descrtiption.Text;
                Product.Cost = Convert.ToDecimal(textBoxCost.Text);
                Product.ProductTypeId = productTypeId;
                Product.Price = Convert.ToDecimal(textBoxPrice.Text);
                Product.Quantity = Convert.ToInt32(textBoxQuantity.Text);
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
            int m;
            return textBoxItemCode != null
                   && textBox2Descrtiption != null
                   && textBoxCost != null
                   && comboBoxItemType != null
                   && textBoxPrice != null
                   && textBoxQuantity != null
                   && decimal.TryParse(textBoxCost.Text, out n)
                   && decimal.TryParse(textBoxPrice.Text, out n)
                   &&int.TryParse(textBoxQuantity.Text, out m);
        }

        private void ProductItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsClosed = true;
        }
    }
}
