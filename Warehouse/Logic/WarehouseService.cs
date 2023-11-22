using Warehouse.Database;
using Warehouse.Models;

namespace Warehouse.Logic
{
    public class WarehouseService
    {
        private readonly WarehouseContext _context;

        public WarehouseService() => 
            _context = new WarehouseContext();

        public List<Product> GetProducts() =>
            _context.Products.ToList();

        public void AddProduct(Product product)
        {
            Category? category = null;

            if (product.CategoryID != 0)
            {
                category = _context.Categories
                    .Find(product.CategoryID);

                if (category == null)
                    throw new ArgumentNullException(nameof(category));
            }

            category = product.Category;

            if(product.ProductId != 0)
            {
                var productDb = _context.Products
                    .Single(x => x.ProductId == product.ProductId);

                productDb.Name = product.Name;
                productDb.Description = product.Description;
                productDb.Price = product.Price;
                productDb.QuantityInStock = product.QuantityInStock;
                productDb.Category = category;
            }
            else
            {
                _context.Add(product);
            }

            _context.SaveChanges();
        }

        public List<Category> GetCategories() =>
            _context.Categories.ToList();

        public List<Product> GetProductsByNameLike(string name) =>
            _context.Products
                .Where(x => x.Name.ToUpper().Contains(name.ToUpper()))
                .ToList();
    }
}
