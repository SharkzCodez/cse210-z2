public class Product
{
    private string _name;
    private int _productID;
    private double _costOfGoods;
    private int _quantity;

    public Product(string name, int productID, double costOfGoods, int quantity)
    {
        _name = name;
        _productID = productID;
        _costOfGoods = costOfGoods;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
    }
    public int productID
    {
        get { return _productID; }
    }
    public double costOfGoods
    {
        get { return _costOfGoods; }
    }
    public int quantity
    {
        get { return _quantity; }
    }

    public double TotalCost()
    {
        return _costOfGoods * _quantity;
    }


}