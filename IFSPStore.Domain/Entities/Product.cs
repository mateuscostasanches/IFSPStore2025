
using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{

    public class Product : BaseEntity<int>
    {

        #region Constructors
        public Product()
        {
        }

        public Product(int id, string name, decimal price,
                       DateTime purchaseDate, string salesUnit, Category category) : base(id)
        {
            Name = name;
            Price = price;
            PurchaseDate = purchaseDate;
            SalesUnit = salesUnit;
            Category = category;
        }
        #endregion 

        public string Name { set; get; }
        public decimal Price { set; get; }
        public DateTime PurchaseDate { set; get; }
        public string SalesUnit { set; get; }
        public Category Category { set; get; }

    }

}
