namespace LazyInstantiation
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order()
        {
            Console.WriteLine("An order object just created!");
        }
    }
}
