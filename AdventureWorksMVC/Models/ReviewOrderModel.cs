namespace AdventureWorks.Models
{
    public class ReviewOrderModel
    {
        public string PageTitle { get; set; }
        public string Subtotal { get; set; }
        public string Shipping { get; set; }
        public string Feight { get; set; }
        public string TotalDue { get; set; }
        //For bill info
        public string BillFirstName { get; set; }
        public string BillLastName { get; set; }
        public string BillCreditCardType { get; set; }
        public string BillCreditCardNumber { get; set; }
        public string BillCreditCardExpire { get; set; }
        public string BillAddressLine1 { get; set; }
        public string BillAddressLine2 { get; set; }
        public string BillAddress { get; set; }
        //For ship info
        public string ShipFirstName { get; set; }
        public string ShipLastName { get; set; }
        public string ShipAddressLine1 { get; set; }
        public string ShipAddressLine2 { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhone { get; set; }
        public string ShipEmail { get; set; }
    }
}