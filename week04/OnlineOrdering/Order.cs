using System.Numerics;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.GetCost();
        }
        if(_customer.InUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string text = "";
        foreach(Product product in _products)
        {
            text += $"{product.GetName()} | {product.GetId()}\n";
        }
        return text;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} | {_customer.GetAddress().GetDisplayText()}";
    }
    public void AddProduct(string name, string id, double price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }
}