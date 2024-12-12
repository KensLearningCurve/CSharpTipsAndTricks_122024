
using Logic;

string product = ProductList.Products[3].Title; // Meatballs

string outputSubstring = product.Substring(1, 5); // eatba
string outputAsSpan = product.AsSpan(1, 5).ToString(); // eatba

Console.WriteLine(outputSubstring);
Console.WriteLine(outputAsSpan);