public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        double shipping = _customer.LivesInUSA() ? 5 : 35;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        List<string> labels = new();
        foreach (var product in _products)
        {
            labels.Add(product.GetPackingLabel());
        }
        return string.Join("\n", labels);
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
