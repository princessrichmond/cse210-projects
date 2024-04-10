using System;

public class OutdoorGathering: Event{
    public string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        :base(title, description, date, time, address){
            _weather = weather;
        }

    public override string FullDetails(){
        return $"{base.FullDetails()}\nWeather: {_weather}";
    }
}