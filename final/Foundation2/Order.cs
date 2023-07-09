// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
using System.Text;

public class Order
{
    // Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
    private List<Product> _products;
    // private Product product;
    private Customer _customer;

    private double _price = 0;


    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void CreateProductList(Product product)
    {
        _products.Add(product);
    }

    // The total price is calculated as the sum of the prices of each product plus a one-time shipping cost ($5 for US citizens, $35 for non-US citizens).
    public double GetOrderCost()
    {
        foreach (Product product in _products)
        {
            _price += product.GetPrice();
        }
        _price += _customer.GetShipping();

        return _price;
    }

    // A packing label should list the name and product id of each product in the order.
    public string PackingLabel()
    {
        StringBuilder s = new StringBuilder();
        foreach (Product product in _products)
        {
            // Console.WriteLine(product.GetPackingLabel());
            s.AppendLine(product.GetPackingLabel());
        }
        return s.ToString();

    }

    // A shipping label should list the name and address of the customer
    public string ShippingLabel()
    {
        return _customer.GetShippingLabel();


    }
}