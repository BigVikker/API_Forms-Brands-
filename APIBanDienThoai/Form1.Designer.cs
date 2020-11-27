namespace APIBanDienThoai
{
    partial class Form1
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
            this.button_Brand = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.button_customer = new System.Windows.Forms.Button();
            this.label_quanLy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Brand
            // 
            this.button_Brand.Location = new System.Drawing.Point(43, 82);
            this.button_Brand.Name = "button_Brand";
            this.button_Brand.Size = new System.Drawing.Size(164, 110);
            this.button_Brand.TabIndex = 4;
            this.button_Brand.Text = "Brand";
            this.button_Brand.UseVisualStyleBackColor = true;
            this.button_Brand.Click += new System.EventHandler(this.button_Brand_Click);
            // 
            // button_product
            // 
            this.button_product.Location = new System.Drawing.Point(43, 198);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(164, 84);
            this.button_product.TabIndex = 5;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_customer
            // 
            this.button_customer.Location = new System.Drawing.Point(43, 288);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(164, 107);
            this.button_customer.TabIndex = 6;
            this.button_customer.Text = "Customer";
            this.button_customer.UseVisualStyleBackColor = true;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // label_quanLy
            // 
            this.label_quanLy.AutoSize = true;
            this.label_quanLy.Location = new System.Drawing.Point(329, 23);
            this.label_quanLy.Name = "label_quanLy";
            this.label_quanLy.Size = new System.Drawing.Size(72, 13);
            this.label_quanLy.TabIndex = 7;
            this.label_quanLy.Text = "label_QuanLy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.label_quanLy);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.button_Brand);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Brand;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Label label_quanLy;
    }
}

