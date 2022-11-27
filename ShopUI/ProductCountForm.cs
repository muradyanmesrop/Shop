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
    public partial class ProductCountForm : Form
    {
        public int Quantity { get; set; }
        public ProductCountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            try
            {
                Quantity = (int)numericUpDown1.Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Not correct dates", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
