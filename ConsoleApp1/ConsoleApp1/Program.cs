namespace ConsoleApp1
    {
    internal class Program
    {
        public class Invoice
        {
            public int Id { get; set; }

            public string InvoiceNo{ get; set;} 

            public DateTime InvoiceDate { get; set; }

            public DateTime DueTime { get; set; }

            public Customer Customer { get; set; }
            public int CustomerId { get; set; }
        }

        public class InvoiceLine
        {
            public int Id { get; set; }

            public string Description { get; set; }

            public decimal Quantity { get; set; }

            public decimal UnitPrice { get; set; }

            public decimal Unit { get; set; }

            public decimal Price 
            {
            get { return Quantity * UnitPrice; }

            set {}
            }

            public Invoice Invoice { get; set; }
            public int InvoiceId { get; set; }

        }

        public class Customer
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public string Address{ get; set; }


        }


    }
}