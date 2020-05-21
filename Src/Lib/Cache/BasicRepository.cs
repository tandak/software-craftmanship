using System.Collections.Generic;

namespace software_craftsmanship.Lib.Cache
{
    public interface IRepository
    {
        void AddProduct(Product product);
        Product GetProduct(int productId);
    }

    public class BasicRepository: IRepository
    {
        private readonly IDictionary<int, Product> _products;

        public BasicRepository()
        {
            _products = new Dictionary<int, Product>();
        }

        public void AddProduct(Product product)
        {
            _products.TryAdd(product.Id, product);
        }

        public Product GetProduct(int productId)
        {
            return _products.TryGetValue(productId, out _) 
                ? _products[productId] 
                : null;
        }
    }
}