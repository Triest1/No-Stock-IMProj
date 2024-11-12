using System;
using System.Windows.Forms;

namespace POSInventoryCreditSystem
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();

            displayUsername();
        }

        public void displayUsername()
        {
            string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
            user_username.Text = username;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                 "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCredit1.Visible = false;
            cashierCreditCustomersForm1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCredit1.Visible = false;
            cashierCreditCustomersForm1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;
            cashierOrder1.Visible = false;
            cashierCredit1.Visible = false;
            cashierCreditCustomersForm1.Visible = false;

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = true;
            cashierCredit1.Visible = false;
            cashierCreditCustomersForm1.Visible = false;

            CashierOrder coForm = cashierOrder1 as CashierOrder;

            if (coForm != null)
            {
                coForm.refreshData();
            }
        }

        private void credit_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCredit1.Visible = true;
            cashierCreditCustomersForm1.Visible = false;

            CashierCredit ccredForm = cashierCredit1 as CashierCredit;

            if (ccredForm != null)
            {
                ccredForm.refreshData();
            }
        }

        private void settlecred_Btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;
            cashierCredit1.Visible = false;
            cashierCreditCustomersForm1.Visible = true;

            CashierCreditCustomersForm custcredForm = cashierCreditCustomersForm1 as CashierCreditCustomersForm;

            if (custcredForm != null)
            {
                custcredForm.refreshData();
            }
        }
    }
}
