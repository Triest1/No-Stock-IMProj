namespace POSInventoryCreditSystem
{
    partial class AdminAddProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProducts_clearBtn = new System.Windows.Forms.Button();
            this.addProducts_removeBtn = new System.Windows.Forms.Button();
            this.addProducts_updateBtn = new System.Windows.Forms.Button();
            this.addProducts_addBtn = new System.Windows.Forms.Button();
            this.addProducts_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addProducts_imageView = new System.Windows.Forms.PictureBox();
            this.addProducts_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addProducts_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProducts_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addProducts_prodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProducts_prodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addProducts_category = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 388);
            this.panel1.TabIndex = 0;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(69, 49);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(944, 319);
            this.DataGridView1.TabIndex = 14;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addProducts_category);
            this.panel2.Controls.Add(this.addProducts_clearBtn);
            this.panel2.Controls.Add(this.addProducts_removeBtn);
            this.panel2.Controls.Add(this.addProducts_updateBtn);
            this.panel2.Controls.Add(this.addProducts_addBtn);
            this.panel2.Controls.Add(this.addProducts_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.addProducts_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addProducts_stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addProducts_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addProducts_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addProducts_prodID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 313);
            this.panel2.TabIndex = 1;
            // 
            // addProducts_clearBtn
            // 
            this.addProducts_clearBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProducts_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_clearBtn.Location = new System.Drawing.Point(640, 253);
            this.addProducts_clearBtn.Name = "addProducts_clearBtn";
            this.addProducts_clearBtn.Size = new System.Drawing.Size(128, 40);
            this.addProducts_clearBtn.TabIndex = 17;
            this.addProducts_clearBtn.Text = "Clear";
            this.addProducts_clearBtn.UseVisualStyleBackColor = false;
            this.addProducts_clearBtn.Click += new System.EventHandler(this.addProducts_clearBtn_Click);
            // 
            // addProducts_removeBtn
            // 
            this.addProducts_removeBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProducts_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_removeBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_removeBtn.Location = new System.Drawing.Point(468, 253);
            this.addProducts_removeBtn.Name = "addProducts_removeBtn";
            this.addProducts_removeBtn.Size = new System.Drawing.Size(128, 40);
            this.addProducts_removeBtn.TabIndex = 16;
            this.addProducts_removeBtn.Text = "Remove";
            this.addProducts_removeBtn.UseVisualStyleBackColor = false;
            this.addProducts_removeBtn.Click += new System.EventHandler(this.addProducts_removeBtn_Click);
            // 
            // addProducts_updateBtn
            // 
            this.addProducts_updateBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProducts_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_updateBtn.Location = new System.Drawing.Point(273, 253);
            this.addProducts_updateBtn.Name = "addProducts_updateBtn";
            this.addProducts_updateBtn.Size = new System.Drawing.Size(128, 40);
            this.addProducts_updateBtn.TabIndex = 15;
            this.addProducts_updateBtn.Text = "Update";
            this.addProducts_updateBtn.UseVisualStyleBackColor = false;
            this.addProducts_updateBtn.Click += new System.EventHandler(this.addProducts_updateBtn_Click);
            // 
            // addProducts_addBtn
            // 
            this.addProducts_addBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProducts_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_addBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_addBtn.Location = new System.Drawing.Point(92, 253);
            this.addProducts_addBtn.Name = "addProducts_addBtn";
            this.addProducts_addBtn.Size = new System.Drawing.Size(128, 40);
            this.addProducts_addBtn.TabIndex = 14;
            this.addProducts_addBtn.Text = "Add";
            this.addProducts_addBtn.UseVisualStyleBackColor = false;
            this.addProducts_addBtn.Click += new System.EventHandler(this.addProducts_addBtn_Click);
            // 
            // addProducts_importBtn
            // 
            this.addProducts_importBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProducts_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_importBtn.ForeColor = System.Drawing.Color.White;
            this.addProducts_importBtn.Location = new System.Drawing.Point(926, 158);
            this.addProducts_importBtn.Name = "addProducts_importBtn";
            this.addProducts_importBtn.Size = new System.Drawing.Size(105, 31);
            this.addProducts_importBtn.TabIndex = 13;
            this.addProducts_importBtn.Text = "Import";
            this.addProducts_importBtn.UseVisualStyleBackColor = false;
            this.addProducts_importBtn.Click += new System.EventHandler(this.addProducts_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.addProducts_imageView);
            this.panel3.Location = new System.Drawing.Point(926, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 112);
            this.panel3.TabIndex = 12;
            // 
            // addProducts_imageView
            // 
            this.addProducts_imageView.Location = new System.Drawing.Point(0, 0);
            this.addProducts_imageView.Name = "addProducts_imageView";
            this.addProducts_imageView.Size = new System.Drawing.Size(105, 112);
            this.addProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addProducts_imageView.TabIndex = 0;
            this.addProducts_imageView.TabStop = false;
            // 
            // addProducts_status
            // 
            this.addProducts_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_status.FormattingEnabled = true;
            this.addProducts_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addProducts_status.Location = new System.Drawing.Point(568, 124);
            this.addProducts_status.Name = "addProducts_status";
            this.addProducts_status.Size = new System.Drawing.Size(200, 28);
            this.addProducts_status.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(508, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status:";
            // 
            // addProducts_stock
            // 
            this.addProducts_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_stock.Location = new System.Drawing.Point(568, 77);
            this.addProducts_stock.Name = "addProducts_stock";
            this.addProducts_stock.Size = new System.Drawing.Size(200, 26);
            this.addProducts_stock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(511, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock:";
            // 
            // addProducts_price
            // 
            this.addProducts_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_price.Location = new System.Drawing.Point(568, 33);
            this.addProducts_price.Name = "addProducts_price";
            this.addProducts_price.Size = new System.Drawing.Size(200, 26);
            this.addProducts_price.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(492, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price (₱):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(89, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // addProducts_prodName
            // 
            this.addProducts_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_prodName.Location = new System.Drawing.Point(167, 77);
            this.addProducts_prodName.Name = "addProducts_prodName";
            this.addProducts_prodName.Size = new System.Drawing.Size(200, 26);
            this.addProducts_prodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(53, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            // 
            // addProducts_prodID
            // 
            this.addProducts_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_prodID.Location = new System.Drawing.Point(168, 33);
            this.addProducts_prodID.Name = "addProducts_prodID";
            this.addProducts_prodID.Size = new System.Drawing.Size(121, 26);
            this.addProducts_prodID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(80, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product ID:";
            // 
            // addProducts_category
            // 
            this.addProducts_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_category.Location = new System.Drawing.Point(168, 128);
            this.addProducts_category.Name = "addProducts_category";
            this.addProducts_category.Size = new System.Drawing.Size(200, 26);
            this.addProducts_category.TabIndex = 18;
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1113, 756);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addProducts_prodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProducts_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox addProducts_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addProducts_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addProducts_price;
        private System.Windows.Forms.Button addProducts_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox addProducts_imageView;
        private System.Windows.Forms.Button addProducts_clearBtn;
        private System.Windows.Forms.Button addProducts_removeBtn;
        private System.Windows.Forms.Button addProducts_updateBtn;
        private System.Windows.Forms.Button addProducts_addBtn;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox addProducts_category;
    }
}
