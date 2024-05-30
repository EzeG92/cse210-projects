using System;
using System.Text;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order (Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCostOrder()
    {
        decimal totalCost = _products.Sum(product => product.GetTotalCost());
        if (_customer.IsinUsa())
        {
            totalCost +=5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine($"Customer: {_customer.NameCustomer}");
        label.AppendLine("Products:");

        foreach (Product product in _products)
        {
            label.AppendLine($"{product.Quantity} - {product.NameProduct} (ID: {product.ProductID}) x ${product.Price}");
        }

        return label.ToString();
    }

    public string ShippingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine($"Customer: {_customer.NameCustomer}");
        label.AppendLine($"Address: {_customer.GetAddress().ToString()}");
        label.AppendLine();

        if (_customer.GetAddress().IsinUsa())
        {
            label.AppendLine($"Shipping: $5");
        }
        else
        {
            label.AppendLine($"Shipping: $35");
        }
        
        return label.ToString();
    }
}