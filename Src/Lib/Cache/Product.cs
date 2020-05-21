namespace software_craftsmanship.Lib.Cache
{
    public class Product
    {
        public Product(Department department, int id, string productTitle, double price)
        {
            Department = department;
            Id = id;
            ProductTitle = productTitle;
            Price = price;
        }

        public int Id { get; set; }

        public string ProductTitle { get; set; }

        public Department Department { get; set; }

        public double Price { get; set; }
    }
}