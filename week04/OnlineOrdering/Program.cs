using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        for(int i = 1; i < 3; i++)
        {
            orders.Add(new Order(new Customer($"Customer {i}", new Address($"Street {i}", $"City {i}", $"State/Province {i}", $"Country {i}"))));
            for(int j = 1; j < 4; j++)
            {
                orders[orders.Count - 1].AddProduct($"Product {i}{j}", $"ID: {i}{j}", i, j);
            }
        }

        foreach(Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}