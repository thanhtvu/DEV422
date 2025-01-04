//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StoreConsole;

class Program
{
    static async Task Main(string[] args)
    {
        Order orderOne = OrderFactory.CreateOrder("Online", 1, "Oscar", "654 First Ave NE"); // Polymorphism

        //Order orderTwo = OrderFactory.CreateOrder("Instore", 1, "Kyle", "Kirkland, WA Store"); // Polymorphism

        //orderOne.setShippingStrategy(new GroundShipping());
        orderOne.ProcessOrder();
        orderOne.ShipOrder();


        // Single Responsibility Principle (SRP) - Each class has a single responsibility
        // Open-Closed Priciple (OCP) -
        // Liskov Substitution Principle (LSP) -
        // Interface Segregation Principle (ISP) - 
        // Dependency Inversion Principle (DIP) - 
    } 
}
