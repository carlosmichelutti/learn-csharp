public class Stock
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Products in stock:");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.DetailedDescription);
        }
    }
}