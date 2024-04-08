using System;

public class Customer{
    public string _name{
        get;
        set;
    }
    public Address _address {
        get;
        set;
    }
    public bool IsInUSA(){
        return _address.IsInUSA();
    }
}
