using System;

namespace Calculator
{
    class Program
    {
        static public void Main()
        {
            // const float pi = 3.14f;

            Console.Write("First number: ");
            string firstUserValue = Console.ReadLine();

            Console.Write("Second number: ");
            string secondUserValue = Console.ReadLine();

            decimal firstNumber = Convert.ToDecimal(firstUserValue);
            decimal secondNumber = Convert.ToDecimal(secondUserValue);

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
        }
    }
}
