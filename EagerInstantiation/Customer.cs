namespace EagerInstantiation
{
    public class Customer
    {
        public List<Order> Orders { get; set; } = new List<Order>();
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
            Console.WriteLine($"Customer '{Name}' created, and their Orders list is ready.");
        }
    }
}
