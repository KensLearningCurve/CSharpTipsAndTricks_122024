

using Logic;

var availableProducts = GetAvailableProducts();

IEnumerable<Product> GetAvailableProducts()
{
    List<Product> currentProducts = ProductList.Products.Where(x => x.Available).ToList();

    foreach (var product in ProductList.Products)
    {
        yield return product;
    }
}