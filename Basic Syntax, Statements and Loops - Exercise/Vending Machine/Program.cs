double[] coinValues = new double[] { 0.1, 0.2, 0.5, 1, 2 };

var products = new Dictionary<string, double>()
{
    { "Nuts", 2.0 },
    { "Water", 0.7 },
    { "Crisps", 1.5 },
    { "Soda", 0.8 },
    { "Coke", 1.0 }
};

double balance = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "start")
    {
        break;
    }

    double currentCoin = double.Parse(input);

    if (!coinValues.Contains(currentCoin))
    {
        Console.WriteLine($"Cannot accept {currentCoin}");
        continue;
    }
    balance += currentCoin;
}

while (true)
{
    string product = Console.ReadLine();

    if (product == "End")
    {
        Console.WriteLine($"Change: {balance:F2}");
        break;
    }

    if (!products.ContainsKey(product))
    {
        Console.WriteLine("Invalid product");
        continue;
    }

    if (balance < products[product])
    {
        Console.WriteLine("Sorry, not enough money");
        continue;
    }
    else
    {
        balance -= products[product];
        Console.WriteLine($"Purchased {product.ToLower()}");
    }

}