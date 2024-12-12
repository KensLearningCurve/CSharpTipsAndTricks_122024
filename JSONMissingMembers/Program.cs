using Logic;
using System.Text.Json;

// Uncomment the attribute on the Product.cs to make this example work!

string jsonFile = File.ReadAllText("Products.json");
List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonFile)!;

foreach (var product in products)
{
    Console.WriteLine($"Product {product.Title}");
}