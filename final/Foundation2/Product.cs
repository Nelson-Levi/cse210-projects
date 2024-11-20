public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private double _quantity;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public Product(string name, int id, double price, double quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetProductCost()
    {
        double productCost = _price * _quantity;
        return productCost;
    }
}