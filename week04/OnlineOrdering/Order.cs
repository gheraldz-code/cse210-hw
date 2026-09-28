public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(string aCustomer, Address theAddress)
    {
        _products = new List<Product>();
        _customer = new Customer(aCustomer, theAddress);
    }

    public void SetProduct(Product aProduct)
    {
        _products.Add(aProduct);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        double shippingCost = 35;
        foreach (Product item in _products)
        {
            totalPrice += item.GetTotalCost();
        }
        if (_customer.LiveInUSA())
        {
            shippingCost = 5;
        }
        return totalPrice + shippingCost;
    }

    public string GetProducts()
    {
        string result = "";
        foreach (Product item in _products)
        {
            result = result + item.GetProduct() + "\n";
        }
        return result;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}\n{GetProducts()}";
    }
}