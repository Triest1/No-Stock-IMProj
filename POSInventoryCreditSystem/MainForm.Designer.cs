namespace POSInventoryCreditSystem
{
    partial class MainForm
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
            this.order_btn = new System.Windows.Forms.Button();
            this.settlecred_Btn = new System.Windows.Forms.Button();
            this.credit_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.user_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.adminDashboard1 = new POSInventoryCreditSystem.AdminDashboard();
            this.cashierOrder1 = new POSInventoryCreditSystem.CashierOrder();
            this.cashierCreditCustomersForm1 = new POSInventoryCreditSystem.CashierCreditCustomersForm();
            this.cashierCredit1 = new POSInventoryCreditSystem.CashierCredit();
            this.adminAddUser1 = new POSInventoryCreditSystem.AdminAddUser();
            this.adminAddCategories1 = new POSInventoryCreditSystem.AdminAddCategories();
            this.adminAddProducts1 = new POSInventoryCreditSystem.AdminAddProducts();
            this.cashierCustomersForm1 = new POSInventoryCreditSystem.CashierCustomersForm();
            this.adminAddCategories2 = new POSInventoryCreditSystem.AdminAddCategories();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS INV CRED | Admin\'s Portal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.order_btn);
            this.panel2.Controls.Add(this.settlecred_Btn);
            this.panel2.Controls.Add(this.credit_btn);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.addProducts_btn);
            this.panel2.Controls.Add(this.addUsers_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.user_username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 756);
            this.panel2.TabIndex = 1;
            // 
            // order_btn
            // 
            this.order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.order_btn.Location = new System.Drawing.Point(12, 450);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(217, 39);
            this.order_btn.TabIndex = 20;
            this.order_btn.Text = "Pay Order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // settlecred_Btn
            // 
            this.settlecred_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlecred_Btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.settlecred_Btn.Location = new System.Drawing.Point(12, 561);
            this.settlecred_Btn.Name = "settlecred_Btn";
            this.settlecred_Btn.Size = new System.Drawing.Size(217, 39);
            this.settlecred_Btn.TabIndex = 19;
            this.settlecred_Btn.Text = "Settle Credit";
            this.settlecred_Btn.UseVisualStyleBackColor = true;
            this.settlecred_Btn.Click += new System.EventHandler(this.settlecred_Btn_Click);
            // 
            // credit_btn
            // 
            this.credit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.credit_btn.Location = new System.Drawing.Point(12, 505);
            this.credit_btn.Name = "credit_btn";
            this.credit_btn.Size = new System.Drawing.Size(217, 39);
            this.credit_btn.TabIndex = 18;
            this.credit_btn.Text = "Credit";
            this.credit_btn.UseVisualStyleBackColor = true;
            this.credit_btn.Click += new System.EventHandler(this.credit_btn_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button6.Location = new System.Drawing.Point(12, 705);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.customers_btn.Location = new System.Drawing.Point(12, 396);
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
            this.addProducts_btn.Location = new System.Drawing.Point(12, 341);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(217, 39);
            this.addProducts_btn.TabIndex = 13;
            this.addProducts_btn.Text = "Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addUsers_btn.Location = new System.Drawing.Point(12, 285);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(217, 39);
            this.addUsers_btn.TabIndex = 11;
            this.addUsers_btn.Text = "Add Users";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.addUsers_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 228);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(217, 39);
            this.dashboard_btn.TabIndex = 10;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.button1_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.adminDashboard1);
            this.flowLayoutPanel1.Controls.Add(this.cashierOrder1);
            this.flowLayoutPanel1.Controls.Add(this.cashierCreditCustomersForm1);
            this.flowLayoutPanel1.Controls.Add(this.cashierCredit1);
            this.flowLayoutPanel1.Controls.Add(this.adminAddUser1);
            this.flowLayoutPanel1.Controls.Add(this.adminAddCategories1);
            this.flowLayoutPanel1.Controls.Add(this.adminAddProducts1);
            this.flowLayoutPanel1.Controls.Add(this.cashierCustomersForm1);
            this.flowLayoutPanel1.Controls.Add(this.adminAddCategories2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(242, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1113, 756);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(3, 3);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1113, 756);
            this.adminDashboard1.TabIndex = 11;
            // 
            // cashierOrder1
            // 
            this.cashierOrder1.Location = new System.Drawing.Point(3, 765);
            this.cashierOrder1.Name = "cashierOrder1";
            this.cashierOrder1.Size = new System.Drawing.Size(1113, 756);
            this.cashierOrder1.TabIndex = 10;
            // 
            // cashierCreditCustomersForm1
            // 
            this.cashierCreditCustomersForm1.Location = new System.Drawing.Point(3, 1527);
            this.cashierCreditCustomersForm1.Name = "cashierCreditCustomersForm1";
            this.cashierCreditCustomersForm1.Size = new System.Drawing.Size(1113, 756);
            this.cashierCreditCustomersForm1.TabIndex = 9;
            // 
            // cashierCredit1
            // 
            this.cashierCredit1.Location = new System.Drawing.Point(3, 2289);
            this.cashierCredit1.Name = "cashierCredit1";
            this.cashierCredit1.Size = new System.Drawing.Size(1113, 756);
            this.cashierCredit1.TabIndex = 8;
            // 
            // adminAddUser1
            // 
            this.adminAddUser1.Location = new System.Drawing.Point(3, 3051);
            this.adminAddUser1.Name = "adminAddUser1";
            this.adminAddUser1.Size = new System.Drawing.Size(1113, 756);
            this.adminAddUser1.TabIndex = 7;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(3, 3813);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1113, 756);
            this.adminAddCategories1.TabIndex = 6;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(3, 4575);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1113, 756);
            this.adminAddProducts1.TabIndex = 5;
            // 
            // cashierCustomersForm1
            // 
            this.cashierCustomersForm1.Location = new System.Drawing.Point(3, 5337);
            this.cashierCustomersForm1.Name = "cashierCustomersForm1";
            this.cashierCustomersForm1.Size = new System.Drawing.Size(1113, 756);
            this.cashierCustomersForm1.TabIndex = 4;
            // 
            // adminAddCategories2
            // 
            this.adminAddCategories2.Location = new System.Drawing.Point(3, 6099);
            this.adminAddCategories2.Name = "adminAddCategories2";
            this.adminAddCategories2.Size = new System.Drawing.Size(387, 25);
            this.adminAddCategories2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 801);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button addUsers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label user_username;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AdminAddCategories adminAddCategories2;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
        private AdminAddUser adminAddUser1;
        private AdminAddCategories adminAddCategories1;
        private System.Windows.Forms.Button credit_btn;
        private CashierCredit cashierCredit1;
        private System.Windows.Forms.Button settlecred_Btn;
        private CashierCreditCustomersForm cashierCreditCustomersForm1;
        private System.Windows.Forms.Button order_btn;
        private AdminDashboard adminDashboard1;
        private CashierOrder cashierOrder1;
    }
}