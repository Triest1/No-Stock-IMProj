using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSInventoryCreditSystem
{
    public partial class Form1 : Form
    {
        public static string username;

        SqlConnection
            connect = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            // Set the username here
                            username = login_username.Text.Trim();

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", username);
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (userRole == "Admin")
                                {
                                    MainForm mForm = new MainForm();
                                    mForm.Show();
                                    this.Hide();
                                }
                                else if (userRole == "Cashier")
                                {
                                    CashierMainForm cmForm = new CashierMainForm();
                                    cmForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password or there's no Admin's approval"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
