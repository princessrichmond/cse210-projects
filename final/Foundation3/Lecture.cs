using System;

public class Lecture: Event{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        :base(title, description, date, time, address){
            _speaker = speaker;
            _capacity = capacity;
        }

    public override string FullDetails(){
        return $"{base.FullDetails()}\nSpeaker:{_speaker}\nCapacity: {_capacity}";
    }
}