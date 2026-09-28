public class Product
{
    private int _product_id;
    private string _name;
    private int _quantity;
    private double _price;

    public Product(int id, string name, int quantity, double price)
    {
        _product_id = id;
        _name = name;
        _quantity = quantity;
        _price = price;
    }

    public string GetProduct()
    {
        return $"{_product_id}: {_name} (${_price} x {_quantity})";
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }
}