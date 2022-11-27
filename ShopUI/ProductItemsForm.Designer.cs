namespace ShopUI
{
    partial class ProductItemsForm
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
            this.textBoxItemCode = new System.Windows.Forms.TextBox();
            this.textBox2Descrtiption = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.ItemCode = new System.Windows.Forms.Label();
            this.textboxDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxItemCode
            // 
            this.textBoxItemCode.Location = new System.Drawing.Point(143, 29);
            this.textBoxItemCode.Name = "textBoxItemCode";
            this.textBoxItemCode.Size = new System.Drawing.Size(282, 23);
            this.textBoxItemCode.TabIndex = 0;
            // 
            // textBox2Descrtiption
            // 
            this.textBox2Descrtiption.Location = new System.Drawing.Point(143, 77);
            this.textBox2Descrtiption.Name = "textBox2Descrtiption";
            this.textBox2Descrtiption.Size = new System.Drawing.Size(282, 23);
            this.textBox2Descrtiption.TabIndex = 1;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(143, 178);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(282, 23);
            this.textBoxCost.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(143, 237);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(282, 23);
            this.textBoxPrice.TabIndex = 4;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSize = true;
            this.ItemCode.Location = new System.Drawing.Point(29, 32);
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Size = new System.Drawing.Size(62, 15);
            this.ItemCode.TabIndex = 5;
            this.ItemCode.Text = "Item Code";
            // 
            // textboxDescription
            // 
            this.textboxDescription.AutoSize = true;
            this.textboxDescription.Location = new System.Drawing.Point(29, 80);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(67, 15);
            this.textboxDescription.TabIndex = 6;
            this.textboxDescription.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Type";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(143, 293);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(282, 23);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantity";
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(143, 132);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(282, 23);
            this.comboBoxItemType.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(350, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.ItemCode);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBox2Descrtiption);
            this.Controls.Add(this.textBoxItemCode);
            this.Name = "ProductItemsForm";
            this.Text = "ProductItemsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductItemsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxItemCode;
        private TextBox textBox2Descrtiption;
        private TextBox textBoxCost;
        private TextBox textBoxPrice;
        private Label ItemCode;
        private Label textboxDescription;
        private Label label3;
        private TextBox textBoxQuantity;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxItemType;
        private Button button1;
    }
}