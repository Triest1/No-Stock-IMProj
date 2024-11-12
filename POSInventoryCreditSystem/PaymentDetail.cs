using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSInventoryCreditSystem
{
    internal class PaymentDetail
    {
        public int PaymentID { get; set; }       // Unique identifier for each payment
        public int CustomerID { get; set; }       // Reference to the customer making the payment
        public float TotalPrice { get; set; }     // Total price for the credit transaction
        public float AmountPaid { get; set; }      // Amount paid in this transaction
        public float Amount { get; set; }          // The amount that remains to be paid (if applicable)
        public float Change { get; set; }          // Change returned to the customer
        public DateTime PaymentDate { get; set; }  // Date of the payment
    }
}
