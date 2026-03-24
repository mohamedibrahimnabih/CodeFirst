namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new { Id = 1, Name = "Product 1", Price = 1000 };
            Console.WriteLine(product);
        }
    }
}
