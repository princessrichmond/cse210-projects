using System;

public class Address{
    public string _streetAddress{
        get;
        set;
    }
    public string _city{
        get;
        set;
    }
    public string _state{
        get;
        set;
    }
    public string _country{
        get;
        set;
    }
    
    public bool IsInUSA(){ //
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
    public string FullAddress(){
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}