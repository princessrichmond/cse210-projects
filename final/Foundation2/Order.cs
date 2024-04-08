using System;

public class Order{
    public List<Product> _products{
        get;
        set;
    }
    public Customer _customer{//
        get;
        set;
    }

    public decimal TotalCost(){
        decimal _totalCost = 0;
        foreach (Product product in _products){
            _totalCost += product.TotalCost();
        }
        decimal _shippingCost = _customer.IsInUSA()? 5 : 35;//
        return _totalCost + _shippingCost;
    }

    public string PackingLabel(){
        string _packingLabel = "Packing Label:\n";
        foreach (Product product in _products){
            _packingLabel += $"{product._name} (ID: {product._productId})\n";
        }
        return _packingLabel;
    }

    public string ShippingLabel(){
        return $"Shipping Label:\n{_customer._name}\n{_customer._address.FullAddress()}";
    }
}