using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POSInventoryCreditSystem
{
    public partial class CashierCredit : UserControl
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public CashierCredit()
        {
            InitializeComponent();

            displayAllAvailableProducts();
            displayAllProducts();
            displayOrders();
            displayTotalPrice();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllAvailableProducts();
            displayAllProducts();
            displayOrders();
            displayTotalPrice();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                dataGridView2.DataSource = null;
                refreshData();
            }
        }
        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvailableProducts();

            dataGridView1.DataSource = listData;
        }
        public void displayOrders()
        {
            CreditOrdersData coData = new CreditOrdersData();
            List<CreditOrdersData> listData = coData.allCreditOrdersData();

            dataGridView2.DataSource = listData;
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

        public void displayAllProducts()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierCredit_prodID.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                cashierCredit_prodID.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void cashierCredit_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierCredit_prodID.SelectedItem as string;

            if (checkConnection())
            {
                if (selectedValue != null)
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    string category = reader["category"].ToString();
                                    float prodPrice = Convert.ToSingle(reader["price"]);

                                    cashierCredit_prodName.Text = prodName;
                                    cashierCredit_category.Text = category;
                                    cashierCredit_price.Text = prodPrice.ToString("0.00");

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private float totalPrice = 0;

        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM creditOrders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashierCredit_totalPrice.Text = totalPrice.ToString("0.00");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierCredit_addBtn_Click_1(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierCredit_category.Text == "" || cashierCredit_prodID.SelectedIndex == -1
                || cashierCredit_prodName.Text == "" || cashierCredit_price.Text == "" || cashierCredit_qty.Value == 0)
            {
                MessageBox.Show("Please select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    float getPrice = 0;
                    string selectOrder = "SELECT * FROM products WHERE prod_id =@prodID";

                    using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                    {
                        getOrder.Parameters.AddWithValue("@prodID", cashierCredit_prodID.SelectedItem);

                        using (SqlDataReader reader = getOrder.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                object rawValue = reader["price"];

                                if (rawValue != DBNull.Value)
                                {
                                    getPrice = Convert.ToSingle(rawValue);
                                }
                            }
                        }
                    }

                    string insertData = "INSERT INTO creditOrders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                        "VALUES(@cID, @prodID, @prodName, @cat, @qty, @origPrice, @totalPrice, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);
                        cmd.Parameters.AddWithValue("@prodID", cashierCredit_prodID.SelectedItem);
                        cmd.Parameters.AddWithValue("@prodName", cashierCredit_prodName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", cashierCredit_category.Text.Trim());
                        cmd.Parameters.AddWithValue("qty", cashierCredit_qty.Value);
                        cmd.Parameters.AddWithValue("@origPrice", getPrice);

                        float totalP = (getPrice * (int)cashierCredit_qty.Value);

                        cmd.Parameters.AddWithValue("@totalprice", totalP);

                        DateTime today = DateTime.Today;        
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            displayOrders();
            displayTotalPrice();

        }


        private int idGen;

        public void IDGenerator()
        {
            using (SqlConnection connect
                = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connect.Open();

                string selectData = "SELECT MAX(customer_id) FROM creditCustomer";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                }

            }
        }

        private void cashierCredit_removeBtn_Click_1(object sender, EventArgs e)
        {
            {
                if (prodID == 0)
                {
                    MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Remove ID: " + prodID
                        + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (checkConnection())
                        {
                            try
                            {
                                connect.Open();

                                string deleteData = "DELETE FROM creditOrders WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@id", prodID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Removed successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                connect.Close();
                            }
                        }
                    }
                }

                displayOrders();
                displayTotalPrice();

            }
        }

        private int prodID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            prodID = (int)row.Cells[0].Value;

        }

        public void clearFields()
        {
            cashierCredit_category.Text = "Category";
            cashierCredit_prodID.SelectedIndex = -1;
            cashierCredit_prodName.Text = "Product";
            cashierCredit_price.Text = "0.00";
            cashierCredit_qty.Value = 0;
        }

        private void cashierCredit_clearBtn_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cashierCredit_payOrders_Click_1(object sender, EventArgs e)
        {
            IDGenerator();

            if (MessageBox.Show("Are you sure you want to credit your orders?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string inserData = "INSERT INTO creditCustomer (customer_id, total_price, amount, change, order_date)" +
                            "VALUES(@cID, @totalPrice, @amount, @change, @date)";

                        using (SqlCommand cmd = new SqlCommand(inserData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cID", idGen);
                            cmd.Parameters.AddWithValue("@totalPrice", cashierCredit_totalPrice.Text);
                            cmd.Parameters.AddWithValue("@amount", 0);
                            cmd.Parameters.AddWithValue("@change", 0);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("date", today);

                            cmd.ExecuteNonQuery();

                        }

                        // Insert into creditPayments
                        string insertPaymentData = "INSERT INTO creditPayments (CustomerID, TotalPrice, Amount, Change, PaymentDate) " +
                            "VALUES (@CustomerID, @TotalPrice, @Amount, @Change, @PaymentDate)";

                        using (SqlCommand paymentCmd = new SqlCommand(insertPaymentData, connect))
                        {
                            paymentCmd.Parameters.AddWithValue("@CustomerID", idGen);
                            paymentCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            paymentCmd.Parameters.AddWithValue("@Amount", 0); // Assuming they pay the total
                            paymentCmd.Parameters.AddWithValue("@Change", 0); // Assuming no change
                            paymentCmd.Parameters.AddWithValue("@PaymentDate", DateTime.Today); // Use current date

                            paymentCmd.ExecuteNonQuery();
                        }

                        clearFields();

                        MessageBox.Show("Credit recorded successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            displayTotalPrice();
            cashierCredit_totalPrice.Text = "0.00"; // Reset total price
        }

        private int rowIndex = 0;

        private void cashierCredit_receipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint_1);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                displayTotalPrice();

                float y = 0;
                int count = 0;
                int colWidth = 108;
                int headerMargin = 5;
                int tableMargin = 5;

                Font font = new Font("Tahoma", 12);
                Font bold = new Font("Tahoma", 12, FontStyle.Bold);
                Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
                Font labelFont = new Font("Tahoma", 14, FontStyle.Bold);

                float margin = e.MarginBounds.Top;

                StringFormat alignCenter = new StringFormat();
                alignCenter.Alignment = StringAlignment.Center;
                alignCenter.LineAlignment = StringAlignment.Center;

                string headerText = "Yayang's POS Inventory and Credit System";
                y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                    + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);

                count++;

                y += tableMargin;

                string[] header = { "ID", "CID", "PID", "Category", "OrigPrice", "QTY", "TotalPrice" };

                for (int q = 0; q < header.Length; q++)
                {
                    y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;

                float rSpace = e.MarginBounds.Bottom - y;

                while (rowIndex < dataGridView2.Rows.Count)
                {
                    DataGridViewRow row = dataGridView2.Rows[rowIndex];

                    for (int q = 0; q < dataGridView2.Columns.Count; q++)
                    {
                        object cellValue = row.Cells[q].Value;
                        string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                        y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                        e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                    }
                    count++;
                    rowIndex++;

                    if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                int labelmargin = (int)Math.Min(rSpace, 200);

                DateTime today = DateTime.Now;

                float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("----------------------", labelFont).Width;

                y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price: \t₱" + totalPrice, labelFont, Brushes.Black, labelX, y);

                labelmargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right
                    - e.Graphics.MeasureString("----------------------", labelFont).Width, y);
            }
        }
    }
}
