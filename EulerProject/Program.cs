using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int eulerChoice = -1;
            Console.WriteLine("Enter the Euler problem number: ");
            eulerChoice = Convert.ToInt32(Console.ReadLine());
            switch (eulerChoice)
            {
                case 1:
                    Console.WriteLine("Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.");
                    int sum = 0;
                    for (int i = 1 ; i < 1000; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            sum = sum + i;
                        }
                    }                    
                    Console.WriteLine($"The correct sum is {sum}");
                    break;
                case 2:
                    Console.WriteLine("Problem 2: In the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
                    int sum2 = 2;
                    int x1 = 1;
                    int x2 = 2;
                    int r = 0;
                    while (r <= 4000000)
                    {
                        r = x1 + x2;
                        x1 = x2;
                        x2 = r;
                        if (r % 2 == 0)
                        {
                            sum2 = sum2 + r;
                        }
                    }
                        Console.WriteLine($"The sum of even terms is {sum2}");
                        break;
                case 3:
                    Console.WriteLine("Problem 3: What is the largest prime factor of the number 600851475143 ?");
                    break;
                default:
                    Console.WriteLine("You haven't solved that problem yet.");
                break;                    
            }
            Thread.Sleep(10000);
        }
    }
}
