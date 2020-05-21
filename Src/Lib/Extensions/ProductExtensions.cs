using software_craftsmanship.Lib.Cache;

namespace software_craftsmanship.Lib.Extensions
{
    public static class ProductExtensions
    {
        public static string ToProductString(this Product product)
        {
            return $"ProductId: {product.Id}, Department: {product.Department}, Title: {product.ProductTitle}, Price: {product.Price}";
        }
    }
}