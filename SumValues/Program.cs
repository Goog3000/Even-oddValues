using System;

namespace SumValues
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumberCount = 0;
            uint evenNumberCount = 0;

            int oddNumberSum = 0;
            int evenNumberSum = 0;

            Console.WriteLine("Enter first value of range :");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second value of range :");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumberCount++;
                    evenNumberSum += currentValue;
                }
                else
                {
                    
                    oddNumberCount++;
                    oddNumberSum = oddNumberSum + currentValue;
                }
                currentValue++;
                
            }


            Console.WriteLine("Quantity of Odd Numbers: " + oddNumberCount);
            Console.WriteLine("Quantity of Even Numbers: " + evenNumberCount);
            Console.WriteLine("Sum of Odd Numbers: " + oddNumberSum);
            Console.WriteLine("Sum of Even Numbers: " + evenNumberSum);

        }
    }
}
