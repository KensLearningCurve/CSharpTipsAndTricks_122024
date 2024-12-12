string theText = "Hello world";

if (theText.StartsWith("H") && theText.EndsWith("d"))
{
    Console.WriteLine("The string starts with H and ends with d!");
}

if (theText[0] == 'H' && theText[^1] == 'd')
{
    Console.WriteLine("The string starts with H and ends with d!");
}

if (theText is ['H', .., 'd'])
{
    Console.WriteLine("The string starts with H and ends with d!");
}