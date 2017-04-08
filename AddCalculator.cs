using System;

class AddCalculator 
{
    static void Main() 
    {
        Console.WriteLine("Give me a number");
        string firstNumberString = Console.ReadLine();
        int firstNumberInt = int.Parse(firstNumberString);
        Console.WriteLine("Give me a second number");
        string secondNumberString = Console.ReadLine();
        int secondNumberInt = int.Parse(secondNumberString);

        int total = firstNumberInt + secondNumberInt;
        string totalString = total.ToString();
        Console.WriteLine(firstNumberString + " + " + secondNumberString + " equals " + totalString);
    }
}