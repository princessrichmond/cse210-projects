using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        while (true){
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0){
                break;
            }
            numbers.Add(num);
        }
        int sum = numbers.Sum();
        float average = (float)sum / numbers.Count;
        int max_num = numbers.Max();  
        // int smallest_num = numbers.Min();
        List<int> positiveNum = numbers.Where(n => n > 0).ToList();
        int sm_positive_num = positiveNum.Count > 0 ? positiveNum.Min(): 0;
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max_num}");
        Console.WriteLine($"The smallest positive number is: {sm_positive_num}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int num in numbers){
            Console.WriteLine(num);
        }
        {
            
        }
    }
}