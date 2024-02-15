using jenkinsAssesment;
using System;

namespace jenkinsAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a Simple .NET Core Console Application!");

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");

            Calculator calculator = new Calculator();

            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = calculator.Add(number1, number2);
            int difference = calculator.Subtract(number1, number2);

            Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
            Console.WriteLine($"The difference between {number1} and {number2} is: {difference}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
