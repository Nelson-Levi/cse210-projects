using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        Product laptop = new Product("HP Laptop", 1, 300, 1);
        Product apples = new Product("Honeycrisp Apples", 2, 1.55, 5);
        Product table = new Product("Folding Table", 3, 50, 1);
        List<Product> leviProducts = new List<Product> { laptop, apples, table};
        Address leviAddress = new Address("3811 Seltice Way", "Kilgore", "ID", "USA");
        Customer leviNelson = new Customer("Levi Nelson", leviAddress);
        Order leviOrder = new Order(leviProducts, leviNelson);

        Console.WriteLine($"\nPacking Label: {leviOrder.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {leviOrder.ShippingLabel()}");
        Console.WriteLine($"\nTotal Price: ${leviOrder.TotalPrice()}");

        Product whiteboard = new Product("Classroom Whiteboard", 20, 159.99, 1);
        Product markers = new Product("Expo Markers", 36, 3.59, 5);
        Product erasers = new Product("Whiteboard Erasers", 99, 0.99, 11);
        List<Product> taoProducts = new List<Product> { whiteboard, markers, erasers };
        Address taoAddress = new Address("Jiu 569 Hao", "Tianhe", "Guangdong", "CN");
        Customer taoZhang = new Customer("Tao Zhang", taoAddress);
        Order taoOrder = new Order(taoProducts, taoZhang);

        Console.WriteLine($"\nPacking Label: {taoOrder.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {taoOrder.ShippingLabel()}");
        Console.WriteLine($"\nTotal Price: ${taoOrder.TotalPrice()}");

        Product microphone = new Product("Blue Yeti Microphone", 15, 50, 1);
        Product webcam = new Product("Logitech Webcam", 81, 18.98, 2);
        Product keyboard = new Product("Dell Wired Keyboard", 33, 12.75, 5);
        List<Product> coryProducts = new List<Product> { microphone, webcam, keyboard };
        Address coryAddress = new Address("1350 Valley Ln", "Austin", "TX", "USA");
        Customer coryHerbert = new Customer("Cory Herbert", coryAddress);
        Order coryOrder = new Order(coryProducts, coryHerbert);

        Console.WriteLine($"\nPacking Label: {coryOrder.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {coryOrder.ShippingLabel()}");
        Console.WriteLine($"\nTotal Price: ${coryOrder.TotalPrice()}");
    }
}