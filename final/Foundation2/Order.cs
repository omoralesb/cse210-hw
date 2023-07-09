class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer newCustomer)
    {
        _customer = newCustomer;
        _products = new List<Product>();
    }

    public double TotalCost()
    { 
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice();
        }
        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += "Product Name: " + product.GetName() + ", Product ID: " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Name: " + _customer.GetName() + "\n" + _customer.GetAddress();
        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}