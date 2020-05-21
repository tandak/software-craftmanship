namespace software_craftsmanship.Lib.Cache
{
    public interface ICache
    {
        bool AddToCache(Product product);

        Product ReadFromCache(int productId);

    }
}