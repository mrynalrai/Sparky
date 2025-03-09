namespace Sparky
{
    public class Product
    {
        private static int idCounter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        private double Price { get; set; }

        public Product(string name, double price )
        {
            Id = idCounter++;
            Name = name;
            Price = price;
        }

        public double GetPrice(Customer customer) 
        {
            if (customer.IsPlatinum)
            {
                return Price * 0.8;
            }
            return Price;
        }
    }
}