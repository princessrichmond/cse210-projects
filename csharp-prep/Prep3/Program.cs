using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magic_num = int.Parse(Console.ReadLine());

        Random randomgen = new Random();
        int magic_num = randomgen.Next(1, 101);
        int guess = -1;

        while (guess != magic_num)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic_num > guess){
                Console.WriteLine("Higher");
            }
            else if (magic_num < guess){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }
    }
}