// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
public class Product
{
    // Contains the name, product id, price, and quantity of each product.
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product()
    {

    }

    // Don't need this method. Erase later
    public void Display()
    {
        Console.WriteLine($"{_name} ({_productId}) {_price}-{_quantity}");
    }

    public Product(string name, int productId)
    {
        //  Setters
        _name = name;
        _productId = productId;
    }

    // Getter
    public string GetPackingLabel()
    {
        return $"{_name}, {_productId}";
    }

    // The price of this product is computed by multiplying the price and the quantity.
    public double GetPrice()
    {
        double productPrice = _price * _quantity;
        return productPrice;
    }
}