using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace POSInventoryCreditSystem
{
    internal class CreditOrdersData
    {
        SqlConnection 
            connect = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public int ID { get; set; }
        public string CID { get; set; }  // Customer ID
        public string PID { get; set; }  // Product ID
       // public string PName { get; set; }  // Product Name
        public string Category { get; set; }
        public string OrigPrice { get; set; }
        public string QTY { get; set; }
        public string TotalPrice { get; set; }
        //public DateTime OrderDate { get; set; } // For the order date

        public List<CreditOrdersData> allCreditOrdersData()
        {
            List<CreditOrdersData> listData = new List<CreditOrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM creditOrders";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectData = "SELECT * FROM creditOrders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CreditOrdersData coData = new CreditOrdersData();

                            coData.ID = (int)reader["id"];
                            coData.CID = reader["customer_id"].ToString();
                            coData.PID = reader["prod_id"].ToString();
                            //oData.PName = reader["prod_name"].ToString();
                            coData.Category = reader["category"].ToString();
                            coData.OrigPrice = reader["orig_price"].ToString();
                            coData.QTY = reader["qty"].ToString();
                            coData.TotalPrice = reader["total_price"].ToString();


                            listData.Add(coData);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
