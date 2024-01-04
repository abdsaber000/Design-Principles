namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order("chicken");
            Console.WriteLine(pizza);

        }
    }
}
