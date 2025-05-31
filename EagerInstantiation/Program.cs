using System.Runtime.InteropServices;

namespace EagerInstantiation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new("Alice");
            Console.ReadKey();


        }
    }
}
