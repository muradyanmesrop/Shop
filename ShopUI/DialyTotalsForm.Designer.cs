namespace ShopUI
{
    partial class DialyTotalsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMostSoldProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(353, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(12, 23);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(110, 15);
            this.labelTotalAmount.TabIndex = 1;
            this.labelTotalAmount.Text = "Today total amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total quantity by Item";
            // 
            // labelMostSoldProduct
            // 
            this.labelMostSoldProduct.AutoSize = true;
            this.labelMostSoldProduct.Location = new System.Drawing.Point(11, 289);
            this.labelMostSoldProduct.Name = "labelMostSoldProduct";
            this.labelMostSoldProduct.Size = new System.Drawing.Size(59, 15);
            this.labelMostSoldProduct.TabIndex = 3;
            this.labelMostSoldProduct.Text = "Most sold";
            // 
            // DialyTotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.labelMostSoldProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DialyTotalsForm";
            this.Text = "DialyTotals";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelTotalAmount;
        private Label label1;
        private Label labelMostSoldProduct;
    }
}