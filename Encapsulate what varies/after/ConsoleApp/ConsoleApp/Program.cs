namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaTypes.CheesePizza);
            Console.WriteLine(pizza);

            Pizza pizza2 = Pizza.Order2(PizzaTypes.VegeterianPizza);
            Console.WriteLine(pizza2);

        }
    }
}
