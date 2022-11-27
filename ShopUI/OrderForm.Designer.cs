namespace ShopUI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.lableAmount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCsutomerName = new System.Windows.Forms.Label();
            this.labeCustomerAdress = new System.Windows.Forms.Label();
            this.labelOrderNbr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(360, 46);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(271, 499);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.DoubleClick += new System.EventHandler(this.listBoxProducts_DoubleClick);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 15;
            this.listBoxOrder.Location = new System.Drawing.Point(686, 46);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(243, 409);
            this.listBoxOrder.TabIndex = 1;
            // 
            // lableAmount
            // 
            this.lableAmount.AutoSize = true;
            this.lableAmount.Location = new System.Drawing.Point(686, 491);
            this.lableAmount.Name = "lableAmount";
            this.lableAmount.Size = new System.Drawing.Size(51, 15);
            this.lableAmount.TabIndex = 2;
            this.lableAmount.Text = "Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Customer";
            // 
            // labelCsutomerName
            // 
            this.labelCsutomerName.AutoSize = true;
            this.labelCsutomerName.Location = new System.Drawing.Point(12, 60);
            this.labelCsutomerName.Name = "labelCsutomerName";
            this.labelCsutomerName.Size = new System.Drawing.Size(39, 15);
            this.labelCsutomerName.TabIndex = 5;
            this.labelCsutomerName.Text = "Name";
            // 
            // labeCustomerAdress
            // 
            this.labeCustomerAdress.AutoSize = true;
            this.labeCustomerAdress.Location = new System.Drawing.Point(12, 117);
            this.labeCustomerAdress.Name = "labeCustomerAdress";
            this.labeCustomerAdress.Size = new System.Drawing.Size(42, 15);
            this.labeCustomerAdress.TabIndex = 6;
            this.labeCustomerAdress.Text = "Adress";
            // 
            // labelOrderNbr
            // 
            this.labelOrderNbr.AutoSize = true;
            this.labelOrderNbr.Location = new System.Drawing.Point(360, 9);
            this.labelOrderNbr.Name = "labelOrderNbr";
            this.labelOrderNbr.Size = new System.Drawing.Size(57, 15);
            this.labelOrderNbr.TabIndex = 7;
            this.labelOrderNbr.Text = "OrderNbr";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(854, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOrderNbr);
            this.Controls.Add(this.labeCustomerAdress);
            this.Controls.Add(this.labelCsutomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lableAmount);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxProducts;
        private ListBox listBoxOrder;
        private Label lableAmount;
        private ComboBox comboBox1;
        private Label label1;
        private Label labelCsutomerName;
        private Label labeCustomerAdress;
        private Label labelOrderNbr;
        private Button button1;
    }
}