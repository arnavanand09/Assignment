namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Pizza> pizzaOrders = new List<Pizza>();

            pizzaOrders.Add(new Pizza("Small", 1, 2, 1));
            pizzaOrders.Add(new Pizza("Medium", 2, 2, 2));
            pizzaOrders.Add(new Pizza("Large", 3, 1, 0));

            Console.WriteLine("Pizza Orders:\n");
            foreach (Pizza pizza in pizzaOrders)
            {
                Console.WriteLine(pizza.GetDescription());
            }
        }
    }
}