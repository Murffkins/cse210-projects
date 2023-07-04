// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
public class Order
{
    // Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
    private List<Product> _products = new List<Product>();
    private double _price = 0;
    private int _shipping = 5;
    private Product product;
    private Customer customer;


    public Order()
    {
        product = new Product();
        customer = new Customer();
    }

    // The total price is calculated as the sum of the prices of each product plus a one-time shipping cost ($5 for US citizens, $35 for non-US citizens).
    public double GetOrderCost()
    {
        foreach (Product item in _products)
        {
            _price += _price;
            if (customer.UsCitizen() == true)
            {
                _price += _shipping;
                return _price;
            }
            else
            {
                _shipping = 35;
                _price += _shipping;
                return _price;
            }
        }
        return _price;
    }

    // A packing label should list the name and product id of each product in the order.
    public void PackingLabel()
    {
        foreach (Product item in _products)
        {
            Console.WriteLine(product.GetPackingLabel());
        }

    }

    // A shipping label should list the name and address of the customer
    public void ShippingLabel()
    {
        foreach (Product item in _products)
        {
            Console.WriteLine(customer.GetShippingLabel());
        }

    }
}