using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace POSInventoryCreditSystem
{
    internal class CreditCustomersData
    {
        SqlConnection
           connect = new SqlConnection(@"Data Source=LAPTOP-DS3FBCLH\SQLEXPRESS01;Initial Catalog=posinventorycredit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public string CustomerID { set; get; }
        public string TotalPrice { set; get; }
        public string Date { set; get; }

        public List<CreditCustomersData> allcreditCustomers()
        {
            List<CreditCustomersData> listData = new List<CreditCustomersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM creditCustomer";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CreditCustomersData ccData = new CreditCustomersData();

                            ccData.CustomerID = reader["customer_id"].ToString();
                            ccData.TotalPrice = reader["total_price"].ToString();
                            ccData.Date = reader["order_date"].ToString();

                            listData.Add(ccData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed connection" + ex);
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
