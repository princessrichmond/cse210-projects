using System;

public class Product{
    public string _name{
        get;
        set;
    }
    public int _productId{
        get;
        set;
    }
    public decimal _price{
        get;
        set;
    }
    public int _quantity{
        get;
        set;
    }

    public decimal TotalCost(){
        return _price * _quantity;
    }
}