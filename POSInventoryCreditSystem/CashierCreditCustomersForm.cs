using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;

namespace POSInventoryCreditSystem
{
    public partial class CashierCreditCustomersForm : UserControl
    {
        SqlConnection
             connect = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public CashierCreditCustomersForm()
        {
            InitializeComponent();

            displaycredCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displaycredCustomers();
        }

        public void displaycredCustomers()
        {
            CreditCustomersData ccData = new CreditCustomersData();

            List<CreditCustomersData> listData = ccData.allcreditCustomers();

            dataGridView1.DataSource = listData;
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

        private float GetTotalAmountForCustomer(int customerId)
        {
            float totalAmount = 0f;

            if (checkConnection()) // Ensure the connection is valid before proceeding
            {
                try
                {
                    connect.Open(); // Open the connection

                    string query = "SELECT SUM(total_price) FROM creditCustomer WHERE customer_id = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalAmount = Convert.ToSingle(result);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close(); // Ensure the connection is closed after use
                }
            }

            return totalAmount;
        }

        private int getCustomerId = 0; // Field to store the selected customer ID

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["CustomerID"].Value != DBNull.Value)
                {
                    if (int.TryParse(row.Cells["CustomerID"].Value.ToString(), out getCustomerId))
                    {
                        // Set the customer ID in the text box
                        credit_ID.Text = getCustomerId.ToString();

                        // Reset the displayed values in the UI
                        ResetUIFields();

                        // Fetch updated payment details for the selected customer
                        var paymentDetails = GetExistingPaymentDetails(getCustomerId);
                        float totalPrice = GetTotalAmountForCustomer(getCustomerId);

                        // Update UI with the new payment details
                        cashierCredCust_totalPrice.Text = $"{totalPrice:F2}";
                        cashierCredCust_amountPaid.Text = $"{paymentDetails.AmountPaid:F2}";
                        cashierCredCust_change.Text = $"{paymentDetails.Change:F2}"; // Display the change
                        cashierCredCust_remainingCred.Text = $"{Math.Max(totalPrice - paymentDetails.AmountPaid, 0):F2}";
                        UpdateCreditStatus(getCustomerId); // Update credit status based on the new details
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer ID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ResetUIFields()
        {
            // Reset all the fields to their default values
            cashierCredCust_totalPrice.Text = "0.00";
            cashierCredCust_amountPaid.Text = "0.00";
            cashierCredCust_change.Text = "0.00";
            cashierCredCust_remainingCred.Text = "0.00";
            credit_status.Text = "";
            cashierCredCust_amount.Text = ""; // Clear the amount input
        }

        private bool PaymentExists(int customerId)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "SELECT COUNT(*) FROM creditPayments WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Return true if a payment exists
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connect.Close();
                }
            }
            return false;
        }
        private (float TotalPrice, float AmountPaid, float Change) GetExistingPaymentDetails(int customerId)
        {
            float existingTotalPrice = 0f;
            float existingAmountPaid = 0f;
            float existingChange = 0f;

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "SELECT TotalPrice, AmountPaid, Change FROM creditPayments WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["TotalPrice"] != DBNull.Value)
                                    existingTotalPrice = Convert.ToSingle(reader["TotalPrice"]);

                                if (reader["AmountPaid"] != DBNull.Value)
                                    existingAmountPaid = Convert.ToSingle(reader["AmountPaid"]);

                                if (reader["Change"] != DBNull.Value)
                                    existingChange = Convert.ToSingle(reader["Change"]);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            return (existingTotalPrice, existingAmountPaid, existingChange);
        }

        private void UpdateCreditStatus(int customerId)
        {
            var existingPaymentDetails = GetExistingPaymentDetails(customerId);

            // Update credit status based on the amount paid
            if (existingPaymentDetails.AmountPaid == 0 || existingPaymentDetails.AmountPaid < existingPaymentDetails.TotalPrice)
            {
                credit_status.Text = "Unpaid";
            }
            else if (existingPaymentDetails.AmountPaid >= existingPaymentDetails.TotalPrice)
            {
                credit_status.Text = "Paid";
            }
        }

        private void InsertCreditPayment(int customerId, float totalPrice)
        {
            // Check if the payment already exists
            var existingPaymentDetails = GetExistingPaymentDetails(customerId);
            if (existingPaymentDetails.TotalPrice > 0)
            {
                // Display the existing TotalPrice and AmountPaid in the labels
                cashierCredCust_totalPrice.Text = $"{existingPaymentDetails.TotalPrice}"; 
                cashierCredCust_amountPaid.Text = $"{existingPaymentDetails.AmountPaid}"; 
                UpdateCreditStatus(customerId); // New line added here
                return; // Exit the method if the payment already exists
            }

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "INSERT INTO creditPayments (CustomerID, TotalPrice, Amount, Change, PaymentDate) " +
                                   "VALUES (@CustomerID, @TotalPrice, @Amount, @Change, @PaymentDate)";

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        command.Parameters.AddWithValue("@Amount", 0); // Assuming they pay the total
                        command.Parameters.AddWithValue("@Change", 0); // Assuming no change
                        command.Parameters.AddWithValue("@PaymentDate", DateTime.Today); // Use current date

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Update the credit status after inserting a new payment
                    UpdateCreditStatus(customerId); // New line added here
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void credit_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(credit_ID.Text, out int customerId))
                {
                    // Get the total amount for this customer
                    float totalAmount = GetTotalAmountForCustomer(customerId);

                    if (totalAmount > 0)
                    {
                        // Insert the total amount into creditPayments table
                        InsertCreditPayment(customerId, totalAmount);
                    }
                    else
                    {
                        MessageBox.Show("No total price found for this customer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierCredCust_amount_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(credit_ID.Text, out int customerId))
                {
                    // Retrieve the total price for the customer
                    float totalPrice = GetTotalAmountForCustomer(customerId);

                    // Get existing payment details
                    var paymentDetails = GetExistingPaymentDetails(customerId);
                    float existingAmountPaid = paymentDetails.AmountPaid;

                    // Check if an amount has been entered
                    if (float.TryParse(cashierCredCust_amount.Text, out float newAmountPaid))
                    {
                        // Update the total amount paid
                        float updatedAmountPaid = existingAmountPaid + newAmountPaid;

                        // Calculate the change
                        float change = updatedAmountPaid - totalPrice;

                        // Display the change in the cashierCredCust_change label
                        cashierCredCust_change.Text = $"{Math.Max(change, 0):F2}"; // Format to 2 decimal places

                        // Calculate the remaining credit
                        float remainingCredit = totalPrice - updatedAmountPaid;

                        // Set the remaining credit label
                        if (remainingCredit <= 0)
                        {
                            cashierCredCust_remainingCred.Text = "0.00"; // Set to "0.00" if fully paid
                        }
                        else
                        {
                            cashierCredCust_remainingCred.Text = $"{remainingCredit:F2}"; // Format remaining credit
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RecordPayment(PaymentDetail paymentDetail)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string insertQuery = "INSERT INTO creditPayments (CustomerID, TotalPrice, AmountPaid, Amount, Change, PaymentDate) " +
                                         "VALUES (@CustomerID, @TotalPrice, @AmountPaid, @Amount, @Change, @PaymentDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", paymentDetail.CustomerID);
                        command.Parameters.AddWithValue("@TotalPrice", paymentDetail.TotalPrice);
                        command.Parameters.AddWithValue("@AmountPaid", paymentDetail.AmountPaid);
                        command.Parameters.AddWithValue("@Amount", paymentDetail.Amount); // Remaining amount
                        command.Parameters.AddWithValue("@Change", paymentDetail.Change); // Change
                        command.Parameters.AddWithValue("@PaymentDate", paymentDetail.PaymentDate); // Use current date

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void UpdateCreditPayment(PaymentDetail paymentDetail)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string updateQuery = "UPDATE creditPayments SET TotalPrice = @TotalPrice, AmountPaid = @AmountPaid, " +
                                         "Amount = @Amount, Change = @Change, PaymentDate = @PaymentDate WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", paymentDetail.CustomerID);
                        command.Parameters.AddWithValue("@TotalPrice", paymentDetail.TotalPrice);
                        command.Parameters.AddWithValue("@AmountPaid", paymentDetail.AmountPaid);
                        command.Parameters.AddWithValue("@Amount", paymentDetail.Amount); // Remaining amount
                        command.Parameters.AddWithValue("@Change", paymentDetail.Change); // Store the change
                        command.Parameters.AddWithValue("@PaymentDate", paymentDetail.PaymentDate); // Use current date

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private int AddNewCustomer(float totalPrice, float amountPaid)
        {
            int newCustomerId = 0;

            using (var connection = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();

                // Get the last customer ID
                string idQuery = "SELECT ISNULL(MAX(customer_id), 0) + 1 FROM customers";
                using (var command = new SqlCommand(idQuery, connection))
                {
                    newCustomerId = (int)command.ExecuteScalar();
                }

                // Insert the new customer
                string insertQuery = "INSERT INTO customers (customer_id, total_price, amount, change, order_date) " +
                                     "VALUES (@CustomerID, @TotalPrice, @Amount, @Change, @PaymentDate)";
                using (var command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", newCustomerId);
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    command.Parameters.AddWithValue("@Amount", amountPaid);
                    command.Parameters.AddWithValue("@Change", Math.Max(0, amountPaid - totalPrice));
                    command.Parameters.AddWithValue("@PaymentDate", DateTime.Today);

                    command.ExecuteNonQuery();
                }
            }

            return newCustomerId; // Return the new customer ID
        }

        private void cashierCredCust_payCredit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(credit_ID.Text, out int customerId))
            {
                // Retrieve the total price for the customer
                float totalPrice = GetTotalAmountForCustomer(customerId);

                // Check if an amount has been entered
                if (float.TryParse(cashierCredCust_amount.Text, out float newAmountPaid))
                {
                    // Get existing payment details
                    var existingPaymentDetails = GetExistingPaymentDetails(customerId);
                    float totalAmountPaid = existingPaymentDetails.AmountPaid + newAmountPaid;

                    // Calculate remaining amount and change
                    float remainingAmount = Math.Max(0, totalPrice - totalAmountPaid);
                    float change = Math.Max(0, totalAmountPaid - totalPrice);

                    // Create a PaymentDetail object for updating
                    var paymentDetail = new PaymentDetail
                    {
                        CustomerID = customerId,
                        TotalPrice = totalPrice,
                        AmountPaid = totalAmountPaid,
                        Amount = remainingAmount,
                        Change = change,
                        PaymentDate = DateTime.Today
                    };

                    // Update the payment in the database
                    UpdateCreditPayment(paymentDetail); // Call update method

                    // Check if the payment is sufficient to create a new customer
                    if (totalAmountPaid >= totalPrice)
                    {
                        // Create a new customer in the customers table
                        int newCustomerId = AddNewCustomer(totalPrice, totalAmountPaid);

                        // If customer creation was successful, update payment details
                        if (newCustomerId > 0)
                        {
                            // Update paymentDetail to reflect the new customer ID
                            paymentDetail.CustomerID = newCustomerId;
                            RecordPayment(paymentDetail); // Insert into creditPayments table
                            MessageBox.Show("Payment recorded and new customer created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Update the credit status label based on the remaining amount
                    credit_status.Text = remainingAmount <= 0 ? "Paid" : "Unpaid";

                    // Refresh displayed payment details
                    cashierCredCust_totalPrice.Text = $"{totalPrice:F2}";
                    cashierCredCust_amountPaid.Text = $"{totalAmountPaid:F2}";
                    cashierCredCust_remainingCred.Text = remainingAmount <= 0 ? "0.00" : $"{remainingAmount:F2}";
                    cashierCredCust_change.Text = $"{change:F2}"; // Display change
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int rowIndex = 0;

        private List<PaymentDetail> paymentDetailsList = new List<PaymentDetail>();


        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 108;
            int headerMargin = 5;
            int tableMargin = 5;

            Font font = new Font("Tahoma", 12);
            Font bold = new Font("Tahoma", 12, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font labelFont = new Font("Tahoma", 14, FontStyle.Bold);
            Font separatorFont = new Font("Tahoma", 20, FontStyle.Bold); // Bold font for separator

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            string headerText = "Yayang's POS Inventory and Credit System";
            y = margin + count * headerFont.GetHeight(e.Graphics) + headerMargin;
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (5 * colWidth / 2), y, alignCenter);
            count++;

            y += tableMargin; // Move down for the Customer ID display

            // Display Customer ID at the top of the receipt
            if (int.TryParse(credit_ID.Text, out int customerId))
            {
                y += labelFont.GetHeight(e.Graphics) + tableMargin; // Move down for the header of the table
            }

            // Update the header array to include "Amount"
            string[] header = { "ID", "CID", "TotalPrice", "AmountPaid", "Change", "CreditDate" };

            // Draw the table header
            for (int q = 0; q < header.Length; q++)
            {
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            y += bold.GetHeight(e.Graphics) + tableMargin; // Move down for the first row of data

            // Retrieve data from the creditPayments table for the selected CustomerID
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();
                string query = "SELECT PaymentID, CustomerID, TotalPrice, AmountPaid, Amount, Change, PaymentDate FROM creditPayments WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            e.Graphics.DrawString(reader["PaymentID"].ToString(), font, Brushes.Black, e.MarginBounds.Left + 0 * colWidth, y, alignCenter);
                            e.Graphics.DrawString(reader["CustomerID"].ToString(), font, Brushes.Black, e.MarginBounds.Left + 1 * colWidth, y, alignCenter);
                            e.Graphics.DrawString($"₱{reader["TotalPrice"]:F2}", font, Brushes.Black, e.MarginBounds.Left + 2 * colWidth, y, alignCenter);
                            e.Graphics.DrawString($"₱{reader["AmountPaid"]:F2}", font, Brushes.Black, e.MarginBounds.Left + 3 * colWidth, y, alignCenter);
                            e.Graphics.DrawString($"₱{reader["Change"]:F2}", font, Brushes.Black, e.MarginBounds.Left + 4 * colWidth, y, alignCenter);
                            e.Graphics.DrawString(((DateTime)reader["PaymentDate"]).ToString("yyyy-MM-dd"), font, Brushes.Black, e.MarginBounds.Left + 5 * colWidth, y, alignCenter);
                            count++;
                            y += font.GetHeight(e.Graphics) + tableMargin; // Move down for the next row

                            if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                            {
                                e.HasMorePages = true;
                                return;
                            }
                        }
                    }
                }
            }
            // Calculate the position for the footer
            float rSpace = e.MarginBounds.Bottom - y;
            float labelmargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            // Check if the cashierCredCust_amount is valid; if not, set to "0.00"
            string amountText = string.IsNullOrWhiteSpace(cashierCredCust_amount.Text) ? "0.00" : cashierCredCust_amount.Text.Trim();

            // Prepare the footer text
            string footerText = "Credit Bal: \t₱" + cashierCredCust_remainingCred.Text.Trim() +
                                "\nAmount: \t₱" + amountText +
                                "\n\t\t---------------\nChange: \t₱" + cashierCredCust_change.Text.Trim();

            // Calculate footer X position and draw the footer
            float footerX = e.MarginBounds.Right - e.Graphics.MeasureString(footerText, labelFont).Width;
            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(footerText, labelFont, Brushes.Black, footerX, y);

            labelmargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString(labelText, labelFont).Width, y);

            // Draw string separator inclined towards the right
            string separator = "-----------------";
            float separatorX = e.MarginBounds.Right - e.Graphics.MeasureString(separator, separatorFont).Width - 20; // Move right by 20 pixels
            y -= labelFont.GetHeight(e.Graphics); // Move up before the separator
            e.Graphics.DrawString(separator, separatorFont, Brushes.Black, separatorX, y);
        }

        private (float TotalPrice, float AmountPaid, float Change, DateTime PaymentDate) GetPaymentDetails(int customerId)
        {
            float totalPrice = 0f;
            float amountPaid = 0f;
            float change = 0f;
            DateTime paymentDate = DateTime.Today; // Default value

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string query = "SELECT TotalPrice, AmountPaid, Change, PaymentDate FROM creditPayments WHERE CustomerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToSingle(reader["TotalPrice"]) : 0f;
                                amountPaid = reader["AmountPaid"] != DBNull.Value ? Convert.ToSingle(reader["AmountPaid"]) : 0f;
                                change = reader["Change"] != DBNull.Value ? Convert.ToSingle(reader["Change"]) : 0f;
                                paymentDate = reader["PaymentDate"] != DBNull.Value ? Convert.ToDateTime(reader["PaymentDate"]) : DateTime.Today;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            return (totalPrice, amountPaid, change, paymentDate);
        }

        private void cashierCredCust_receipt_Click(object sender, EventArgs e)
        {
            if (getCustomerId <= 0) // Ensure a customer is selected
            {
                MessageBox.Show("Please select a customer to print the receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}



