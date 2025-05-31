namespace LazyInstantiation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating the lazy customer...");
            Customer lazyCustomer = new Customer("Jane Smith");

            Console.WriteLine("\n...doing other work...");

            Console.WriteLine("\nAccessing orders for the first time:");
            List<Order> orders = lazyCustomer.Orders.Value;

            Console.WriteLine($"\nNumber of orders: {orders.Count}");

            Console.WriteLine("\nAccessing orders for the second time:");
            List<Order> sameOrders = lazyCustomer.Orders.Value;
        }
    }
}
