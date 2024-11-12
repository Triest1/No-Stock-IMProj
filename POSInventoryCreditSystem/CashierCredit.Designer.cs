namespace POSInventoryCreditSystem
{
    partial class CashierCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierCredit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierCredit_category = new System.Windows.Forms.Label();
            this.cashierCredit_prodID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierCredit_clearBtn = new System.Windows.Forms.Button();
            this.cashierCredit_removeBtn = new System.Windows.Forms.Button();
            this.cashierCredit_addBtn = new System.Windows.Forms.Button();
            this.cashierCredit_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierCredit_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierCredit_prodName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cashierCredit_receipt = new System.Windows.Forms.Button();
            this.cashierCredit_payOrders = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cashierCredit_totalPrice = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierCredit_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cashierCredit_category);
            this.panel2.Controls.Add(this.cashierCredit_prodID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cashierCredit_clearBtn);
            this.panel2.Controls.Add(this.cashierCredit_removeBtn);
            this.panel2.Controls.Add(this.cashierCredit_addBtn);
            this.panel2.Controls.Add(this.cashierCredit_qty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cashierCredit_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierCredit_prodName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // cashierCredit_category
            // 
            resources.ApplyResources(this.cashierCredit_category, "cashierCredit_category");
            this.cashierCredit_category.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredit_category.Name = "cashierCredit_category";
            // 
            // cashierCredit_prodID
            // 
            this.cashierCredit_prodID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cashierCredit_prodID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.cashierCredit_prodID, "cashierCredit_prodID");
            this.cashierCredit_prodID.FormattingEnabled = true;
            this.cashierCredit_prodID.Name = "cashierCredit_prodID";
            this.cashierCredit_prodID.SelectedIndexChanged += new System.EventHandler(this.cashierCredit_prodID_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Name = "label5";
            // 
            // cashierCredit_clearBtn
            // 
            this.cashierCredit_clearBtn.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.cashierCredit_clearBtn, "cashierCredit_clearBtn");
            this.cashierCredit_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierCredit_clearBtn.Name = "cashierCredit_clearBtn";
            this.cashierCredit_clearBtn.UseVisualStyleBackColor = false;
            this.cashierCredit_clearBtn.Click += new System.EventHandler(this.cashierCredit_clearBtn_Click_1);
            // 
            // cashierCredit_removeBtn
            // 
            this.cashierCredit_removeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.cashierCredit_removeBtn, "cashierCredit_removeBtn");
            this.cashierCredit_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierCredit_removeBtn.Name = "cashierCredit_removeBtn";
            this.cashierCredit_removeBtn.UseVisualStyleBackColor = false;
            this.cashierCredit_removeBtn.Click += new System.EventHandler(this.cashierCredit_removeBtn_Click_1);
            // 
            // cashierCredit_addBtn
            // 
            this.cashierCredit_addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.cashierCredit_addBtn, "cashierCredit_addBtn");
            this.cashierCredit_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierCredit_addBtn.Name = "cashierCredit_addBtn";
            this.cashierCredit_addBtn.UseVisualStyleBackColor = false;
            this.cashierCredit_addBtn.Click += new System.EventHandler(this.cashierCredit_addBtn_Click_1);
            // 
            // cashierCredit_qty
            // 
            resources.ApplyResources(this.cashierCredit_qty, "cashierCredit_qty");
            this.cashierCredit_qty.Name = "cashierCredit_qty";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Name = "label8";
            // 
            // cashierCredit_price
            // 
            resources.ApplyResources(this.cashierCredit_price, "cashierCredit_price");
            this.cashierCredit_price.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredit_price.Name = "cashierCredit_price";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Name = "label7";
            // 
            // cashierCredit_prodName
            // 
            resources.ApplyResources(this.cashierCredit_prodName, "cashierCredit_prodName");
            this.cashierCredit_prodName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredit_prodName.Name = "cashierCredit_prodName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Name = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cashierCredit_receipt);
            this.panel3.Controls.Add(this.cashierCredit_payOrders);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cashierCredit_totalPrice);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Name = "label14";
            // 
            // cashierCredit_receipt
            // 
            this.cashierCredit_receipt.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.cashierCredit_receipt, "cashierCredit_receipt");
            this.cashierCredit_receipt.ForeColor = System.Drawing.Color.White;
            this.cashierCredit_receipt.Name = "cashierCredit_receipt";
            this.cashierCredit_receipt.UseVisualStyleBackColor = false;
            this.cashierCredit_receipt.Click += new System.EventHandler(this.cashierCredit_receipt_Click);
            // 
            // cashierCredit_payOrders
            // 
            this.cashierCredit_payOrders.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.cashierCredit_payOrders, "cashierCredit_payOrders");
            this.cashierCredit_payOrders.ForeColor = System.Drawing.Color.White;
            this.cashierCredit_payOrders.Name = "cashierCredit_payOrders";
            this.cashierCredit_payOrders.UseVisualStyleBackColor = false;
            this.cashierCredit_payOrders.Click += new System.EventHandler(this.cashierCredit_payOrders_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Name = "label12";
            // 
            // cashierCredit_totalPrice
            // 
            resources.ApplyResources(this.cashierCredit_totalPrice, "cashierCredit_totalPrice");
            this.cashierCredit_totalPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cashierCredit_totalPrice.Name = "cashierCredit_totalPrice";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint_1);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Name = "label6";
            // 
            // CashierCredit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierCredit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierCredit_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cashierCredit_clearBtn;
        private System.Windows.Forms.Button cashierCredit_removeBtn;
        private System.Windows.Forms.Button cashierCredit_addBtn;
        private System.Windows.Forms.NumericUpDown cashierCredit_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cashierCredit_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cashierCredit_prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cashierCredit_receipt;
        private System.Windows.Forms.Button cashierCredit_payOrders;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cashierCredit_totalPrice;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cashierCredit_prodID;
        private System.Windows.Forms.Label cashierCredit_category;
        private System.Windows.Forms.Label label6;
    }
}
