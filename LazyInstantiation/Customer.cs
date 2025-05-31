namespace LazyInstantiation
{
    public class Customer
    {
        public Lazy<List<Order>> Orders { get; private set; }
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new Lazy<List<Order>>(() => 
            {
                Console.WriteLine($"Customer '{Name}' created, and their Orders list is now initialized.");
                return new List<Order>();
            });
            Console.WriteLine($"Customer '{Name}' created, but their Orders list is not loaded yet.");
        }


    }
}
