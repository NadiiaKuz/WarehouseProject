namespace Warehouse.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int QuantityInStock { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
