using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    // Allow other classes to access and write these private attributes
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsAddressInUSA()
    {
        return _address.IsUSA();
    }
}