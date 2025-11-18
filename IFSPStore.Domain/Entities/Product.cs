using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
        }

        public Product(int id, string name, decimal price, decimal quantity,
                       DateTime purchaseDate, string salesUnity, Category category) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            PurchaseDate = purchaseDate;
            SalesUnity = salesUnity;
            Category = category;
        }

        public string Name { set; get; }
        public decimal Price { set; get; }
        public decimal Quantity { set; get; }
        public DateTime PurchaseDate { set; get; }
        public string SalesUnity { set; get; }
        public Category Category { set; get; }
    }
}
