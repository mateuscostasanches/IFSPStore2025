
namespace IFSPStore.App.ViewModel
{

    public class SaleViewModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public string User { get; set; }
        public string Customer { get; set; }

    }

    public class SaleItemViewModel
    {

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Sale { get; set; }
        public string Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

    }

}
