using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalPrice()
    {
        double price = 0;
        foreach (Product product in _products)
        {
            price += product.GetProductCost();
        }
        if (_customer.IsAddressInUSA())
        {
            price = price + 5;
            double formattedPrice = Math.Round((double)price, 2);
            return formattedPrice;
        }
        else
        {
            price = price + 35;
            double formattedPrice = Math.Round((double)price, 2);
            return formattedPrice;
        }
    }

    public string PackingLabel()
    {
        StringBuilder labelBuilder = new StringBuilder();
        List<int> ids = new List<int>();
        foreach (Product product in _products)
        {
            ids.Add(product.Id);
        }
        string idList = string.Join(", ", ids);
        labelBuilder.AppendLine($"\nCustomer: {_customer.Name} - Product IDs: {idList}");
        return labelBuilder.ToString();
    }

    public string ShippingLabel()
    {
        return $"\n{_customer.Name}\n{_customer.Address.FormattedAddress()}";
    }
}