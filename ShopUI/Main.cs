using ShopBL.Models;

namespace ShopUI
{
    public partial class Main : Form
    {
        ShopDbContext dbContext;
        public Main()
        {
            InitializeComponent();
            dbContext = new ShopDbContext();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            dataGridView1.DataSource = dbContext.Products
                                            .Select(product => new
                                            {
                                                ItemCode = product.ProductId,
                                                product.Quantity,
                                                product.Price
                                            }).ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductItemsForm productItemsForm = new ProductItemsForm();
            do
            {
                if (productItemsForm.ShowDialog() == DialogResult.OK && productItemsForm.Product != null)
                {
                    dbContext.Products.Add(productItemsForm.Product);
                    dbContext.SaveChanges();
                    ViewData();
                    dataGridView1.Update();
                }
            } while (productItemsForm.Product == null && !productItemsForm.IsClosed);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbContext?.Dispose();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void repostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialyTotalsForm dialyTotalsForm = new DialyTotalsForm();
            dialyTotalsForm.Show();
        }
    }
}