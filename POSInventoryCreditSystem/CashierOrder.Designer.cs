namespace POSInventoryCreditSystem
{
    partial class CashierOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierOrder_category = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierOrder_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrder_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrder_addBtn = new System.Windows.Forms.Button();
            this.cashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrder_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierOrder_prodName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cashierOrder_receipt = new System.Windows.Forms.Button();
            this.cashierOrder_payOrders = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cashierOrder_change = new System.Windows.Forms.Label();
            this.cashierOrder_amount = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 359);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cashierOrder_category);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cashierOrder_clearBtn);
            this.panel2.Controls.Add(this.cashierOrder_removeBtn);
            this.panel2.Controls.Add(this.cashierOrder_addBtn);
            this.panel2.Controls.Add(this.cashierOrder_qty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cashierOrder_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierOrder_prodName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cashierOrder_prodID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 348);
            this.panel2.TabIndex = 1;
            // 
            // cashierOrder_category
            // 
            this.cashierOrder_category.AutoSize = true;
            this.cashierOrder_category.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_category.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_category.Location = new System.Drawing.Point(170, 148);
            this.cashierOrder_category.Name = "cashierOrder_category";
            this.cashierOrder_category.Size = new System.Drawing.Size(79, 19);
            this.cashierOrder_category.TabIndex = 18;
            this.cashierOrder_category.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(11, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select your orders";
            // 
            // cashierOrder_clearBtn
            // 
            this.cashierOrder_clearBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_clearBtn.Location = new System.Drawing.Point(487, 290);
            this.cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            this.cashierOrder_clearBtn.Size = new System.Drawing.Size(128, 40);
            this.cashierOrder_clearBtn.TabIndex = 17;
            this.cashierOrder_clearBtn.Text = "Clear";
            this.cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_clearBtn.Click += new System.EventHandler(this.cashierOrder_clearBtn_Click);
            // 
            // cashierOrder_removeBtn
            // 
            this.cashierOrder_removeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_removeBtn.Location = new System.Drawing.Point(174, 290);
            this.cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            this.cashierOrder_removeBtn.Size = new System.Drawing.Size(128, 40);
            this.cashierOrder_removeBtn.TabIndex = 16;
            this.cashierOrder_removeBtn.Text = "Remove";
            this.cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_removeBtn.Click += new System.EventHandler(this.cashierOrder_removeBtn_Click);
            // 
            // cashierOrder_addBtn
            // 
            this.cashierOrder_addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_addBtn.Location = new System.Drawing.Point(40, 290);
            this.cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            this.cashierOrder_addBtn.Size = new System.Drawing.Size(128, 40);
            this.cashierOrder_addBtn.TabIndex = 15;
            this.cashierOrder_addBtn.Text = "Add";
            this.cashierOrder_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_addBtn.Click += new System.EventHandler(this.cashierOrder_addBtn_Click);
            // 
            // cashierOrder_qty
            // 
            this.cashierOrder_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_qty.Location = new System.Drawing.Point(437, 148);
            this.cashierOrder_qty.Name = "cashierOrder_qty";
            this.cashierOrder_qty.Size = new System.Drawing.Size(163, 26);
            this.cashierOrder_qty.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(352, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantity:";
            // 
            // cashierOrder_price
            // 
            this.cashierOrder_price.AutoSize = true;
            this.cashierOrder_price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_price.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_price.Location = new System.Drawing.Point(170, 191);
            this.cashierOrder_price.Name = "cashierOrder_price";
            this.cashierOrder_price.Size = new System.Drawing.Size(40, 19);
            this.cashierOrder_price.TabIndex = 9;
            this.cashierOrder_price.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(89, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Price (₱):";
            // 
            // cashierOrder_prodName
            // 
            this.cashierOrder_prodName.AutoSize = true;
            this.cashierOrder_prodName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_prodName.Location = new System.Drawing.Point(170, 102);
            this.cashierOrder_prodName.Name = "cashierOrder_prodName";
            this.cashierOrder_prodName.Size = new System.Drawing.Size(70, 19);
            this.cashierOrder_prodName.TabIndex = 7;
            this.cashierOrder_prodName.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(46, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name:";
            // 
            // cashierOrder_prodID
            // 
            this.cashierOrder_prodID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cashierOrder_prodID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cashierOrder_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodID.FormattingEnabled = true;
            this.cashierOrder_prodID.Location = new System.Drawing.Point(437, 98);
            this.cashierOrder_prodID.Name = "cashierOrder_prodID";
            this.cashierOrder_prodID.Size = new System.Drawing.Size(187, 28);
            this.cashierOrder_prodID.TabIndex = 5;
            this.cashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_prodID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(335, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(83, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cashierOrder_receipt);
            this.panel3.Controls.Add(this.cashierOrder_payOrders);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cashierOrder_change);
            this.panel3.Controls.Add(this.cashierOrder_amount);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cashierOrder_totalPrice);
            this.panel3.Location = new System.Drawing.Point(696, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 713);
            this.panel3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(8, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 22);
            this.label14.TabIndex = 2;
            this.label14.Text = "All Orders";
            // 
            // cashierOrder_receipt
            // 
            this.cashierOrder_receipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_receipt.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_receipt.Location = new System.Drawing.Point(12, 640);
            this.cashierOrder_receipt.Name = "cashierOrder_receipt";
            this.cashierOrder_receipt.Size = new System.Drawing.Size(372, 55);
            this.cashierOrder_receipt.TabIndex = 24;
            this.cashierOrder_receipt.Text = "Receipt";
            this.cashierOrder_receipt.UseVisualStyleBackColor = false;
            this.cashierOrder_receipt.Click += new System.EventHandler(this.cashierOrder_receipt_Click);
            // 
            // cashierOrder_payOrders
            // 
            this.cashierOrder_payOrders.BackColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_payOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrders.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_payOrders.Location = new System.Drawing.Point(12, 579);
            this.cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            this.cashierOrder_payOrders.Size = new System.Drawing.Size(372, 55);
            this.cashierOrder_payOrders.TabIndex = 18;
            this.cashierOrder_payOrders.Text = "Pay Orders";
            this.cashierOrder_payOrders.UseVisualStyleBackColor = false;
            this.cashierOrder_payOrders.Click += new System.EventHandler(this.cashierOrder_payOrders_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(113, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Change (₱):";
            // 
            // cashierOrder_change
            // 
            this.cashierOrder_change.AutoSize = true;
            this.cashierOrder_change.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_change.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_change.Location = new System.Drawing.Point(219, 471);
            this.cashierOrder_change.Name = "cashierOrder_change";
            this.cashierOrder_change.Size = new System.Drawing.Size(40, 19);
            this.cashierOrder_change.TabIndex = 23;
            this.cashierOrder_change.Text = "0.00";
            // 
            // cashierOrder_amount
            // 
            this.cashierOrder_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_amount.Location = new System.Drawing.Point(219, 424);
            this.cashierOrder_amount.Name = "cashierOrder_amount";
            this.cashierOrder_amount.Size = new System.Drawing.Size(159, 26);
            this.cashierOrder_amount.TabIndex = 21;
            this.cashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(372, 277);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(113, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Amount (₱):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(93, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Price (₱):";
            // 
            // cashierOrder_totalPrice
            // 
            this.cashierOrder_totalPrice.AutoSize = true;
            this.cashierOrder_totalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_totalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierOrder_totalPrice.Location = new System.Drawing.Point(219, 380);
            this.cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            this.cashierOrder_totalPrice.Size = new System.Drawing.Size(40, 19);
            this.cashierOrder_totalPrice.TabIndex = 19;
            this.cashierOrder_totalPrice.Text = "0.00";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(1113, 756);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cashierOrder_prodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrder_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cashierOrder_prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cashierOrder_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cashierOrder_clearBtn;
        private System.Windows.Forms.Button cashierOrder_removeBtn;
        private System.Windows.Forms.Button cashierOrder_addBtn;
        private System.Windows.Forms.Button cashierOrder_receipt;
        private System.Windows.Forms.Button cashierOrder_payOrders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cashierOrder_change;
        private System.Windows.Forms.TextBox cashierOrder_amount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cashierOrder_totalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label cashierOrder_category;
    }
}
