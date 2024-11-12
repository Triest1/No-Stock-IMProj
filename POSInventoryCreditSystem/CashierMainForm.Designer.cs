namespace POSInventoryCreditSystem
{
    partial class CashierMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settlecred_Btn = new System.Windows.Forms.Button();
            this.credit_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.user_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminDashboard1 = new POSInventoryCreditSystem.AdminDashboard();
            this.cashierCreditCustomersForm1 = new POSInventoryCreditSystem.CashierCreditCustomersForm();
            this.cashierCredit1 = new POSInventoryCreditSystem.CashierCredit();
            this.adminAddProducts1 = new POSInventoryCreditSystem.AdminAddProducts();
            this.cashierCustomersForm1 = new POSInventoryCreditSystem.CashierCustomersForm();
            this.cashierOrder1 = new POSInventoryCreditSystem.CashierOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 45);
            this.panel1.TabIndex = 1;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Firebrick;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1297, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(46, 20);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS INV CRED | Cashier\'s Portal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.settlecred_Btn);
            this.panel2.Controls.Add(this.credit_btn);
            this.panel2.Controls.Add(this.order_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.addProducts_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.user_username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 756);
            this.panel2.TabIndex = 2;
            // 
            // settlecred_Btn
            // 
            this.settlecred_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlecred_Btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.settlecred_Btn.Location = new System.Drawing.Point(12, 544);
            this.settlecred_Btn.Name = "settlecred_Btn";
            this.settlecred_Btn.Size = new System.Drawing.Size(217, 39);
            this.settlecred_Btn.TabIndex = 18;
            this.settlecred_Btn.Text = "Settle Credit";
            this.settlecred_Btn.UseVisualStyleBackColor = true;
            this.settlecred_Btn.Click += new System.EventHandler(this.settlecred_Btn_Click);
            // 
            // credit_btn
            // 
            this.credit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.credit_btn.Location = new System.Drawing.Point(12, 487);
            this.credit_btn.Name = "credit_btn";
            this.credit_btn.Size = new System.Drawing.Size(217, 39);
            this.credit_btn.TabIndex = 17;
            this.credit_btn.Text = "Credit";
            this.credit_btn.UseVisualStyleBackColor = true;
            this.credit_btn.Click += new System.EventHandler(this.credit_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.order_btn.Location = new System.Drawing.Point(12, 431);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(217, 39);
            this.order_btn.TabIndex = 16;
            this.order_btn.Text = "Pay Order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.logout_btn.Location = new System.Drawing.Point(12, 705);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(217, 39);
            this.logout_btn.TabIndex = 15;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.customers_btn.Location = new System.Drawing.Point(12, 376);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(217, 39);
            this.customers_btn.TabIndex = 14;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addProducts_btn.Location = new System.Drawing.Point(12, 320);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(217, 39);
            this.addProducts_btn.TabIndex = 13;
            this.addProducts_btn.Text = "Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 264);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(217, 39);
            this.dashboard_btn.TabIndex = 10;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // user_username
            // 
            this.user_username.AutoSize = true;
            this.user_username.BackColor = System.Drawing.Color.RoyalBlue;
            this.user_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username.ForeColor = System.Drawing.Color.White;
            this.user_username.Location = new System.Drawing.Point(120, 165);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(49, 18);
            this.user_username.TabIndex = 9;
            this.user_username.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome,";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.cashierCreditCustomersForm1);
            this.panel3.Controls.Add(this.cashierCredit1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.cashierCustomersForm1);
            this.panel3.Controls.Add(this.cashierOrder1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(242, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 756);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSInventoryCreditSystem.Properties.Resources.profile1;
            this.pictureBox1.Location = new System.Drawing.Point(73, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1113, 756);
            this.adminDashboard1.TabIndex = 5;
            // 
            // cashierCreditCustomersForm1
            // 
            this.cashierCreditCustomersForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCreditCustomersForm1.Name = "cashierCreditCustomersForm1";
            this.cashierCreditCustomersForm1.Size = new System.Drawing.Size(1113, 756);
            this.cashierCreditCustomersForm1.TabIndex = 4;
            // 
            // cashierCredit1
            // 
            this.cashierCredit1.Location = new System.Drawing.Point(0, 0);
            this.cashierCredit1.Name = "cashierCredit1";
            this.cashierCredit1.Size = new System.Drawing.Size(1113, 756);
            this.cashierCredit1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1113, 756);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // cashierCustomersForm1
            // 
            this.cashierCustomersForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomersForm1.Name = "cashierCustomersForm1";
            this.cashierCustomersForm1.Size = new System.Drawing.Size(1113, 756);
            this.cashierCustomersForm1.TabIndex = 1;
            // 
            // cashierOrder1
            // 
            this.cashierOrder1.Location = new System.Drawing.Point(0, 0);
            this.cashierOrder1.Name = "cashierOrder1";
            this.cashierOrder1.Size = new System.Drawing.Size(1113, 756);
            this.cashierOrder1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 801);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label user_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Panel panel3;
        private CashierOrder cashierOrder1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
        private System.Windows.Forms.Button credit_btn;
        private CashierCredit cashierCredit1;
        private System.Windows.Forms.Button settlecred_Btn;
        private AdminDashboard adminDashboard1;
        private CashierCreditCustomersForm cashierCreditCustomersForm1;
    }
}