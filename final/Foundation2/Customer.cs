using System;

class Customer
{
    private string _nameCustomer;
    private Address _address;

    public Customer(string name, Address address)
    {
        _nameCustomer = name;
        _address = address;
    }

    public string NameCustomer
    {
        get { return _nameCustomer; }
        set { _nameCustomer = value; }
    }

    public bool IsinUsa()
    {
        return _address.IsinUsa();
    }

    public Address GetAddress()
    {
        return _address;
    }

}