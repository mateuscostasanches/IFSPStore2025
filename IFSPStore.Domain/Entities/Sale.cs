
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{

    public class Sale : BaseEntity<int>
    {

        #region Constructors
        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }

        public Sale(int id, DateTime date, decimal saletotal, User salesman, Customer customer) : base(id)
        {
            SaleDate = date;
            SaleTotal = saletotal;
            Salesman = salesman;
            Customer = customer;
            SaleItems = new List<SaleItem>();
        }
        #endregion 

        public DateTime SaleDate { set; get; }
        public decimal SaleTotal { set; get; }
        public User Salesman { set; get; }
        public Customer Customer { set; get; }
        public List<SaleItem> SaleItems { get; set; }

    }

    public class SaleItem : BaseEntity<int>
    {

        #region Constructors
        public SaleItem()
        {

        }

        public SaleItem(int id, Sale sale, Product product, decimal quantity, 
                        decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
        #endregion 

        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

    }

}
