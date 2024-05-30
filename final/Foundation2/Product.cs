using System;

class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string nameProduct, string productID, decimal price, int quantity)
    {
        _name = nameProduct;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string NameProduct
    {
        get { return _name; }
        set { _name = value; }
    }

    public string ProductID
    {
        get { return _productID; }
        set { _productID = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public int GetTotalCost()
    {
        return (int)(_price * _quantity);
    }
}