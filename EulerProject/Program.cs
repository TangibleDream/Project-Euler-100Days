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
                    long problem_num = 600851475143;
                    bool solved = false;
                    long dividend = problem_num;
                    int p3x;
                    while (solved == false)
                    {
                        //find smallest prime factor
                        p3x = 2;
                        while (dividend % p3x != 0) { p3x = p3x + 1; }
                        // if smallest prime factor == dividend then you have the largest prime factor
                        if (p3x == dividend)
                        {
                            Console.WriteLine($"The largest prime factor is {dividend}");
                            solved = true;
                        }
                        else
                        {
                            dividend = dividend / p3x;
                        }
                        // else the diviend / quotient becomes the new dividend
                    }
                    break;
                case 4:
                    Console.WriteLine("Problem 4: Find the largest palindrome made from the product of two 3-digit numbers.");
                    int p4FactorOne = 999;
                    int p4FactorTwo = 999;
                    int lf1 = 0;
                    int lf2 = 0;
                    int largest_palindrome = 10001;
                    for (p4FactorOne = 999; p4FactorOne > 100; p4FactorOne--)
                    {
                        for (p4FactorTwo = 999; p4FactorTwo > 100; p4FactorTwo--)
                        {
                            //turn the product of p4FactorOne and p4FactorTwo into string                           
                            // determine if palindrome by comparing string and reverse string
                            // if palindrome is determined and higher than largest_palindrome then largwst palindrom is set to new palidrome
                            string p4ProdString = (p4FactorOne * p4FactorTwo).ToString();
                            char[] p4ProdArray = p4ProdString.ToCharArray();
                            Array.Reverse(p4ProdArray);
                            string p4ProdStringReversed = new string(p4ProdArray);
                            if (p4ProdString == p4ProdStringReversed)
                            {
                                if ((p4FactorOne * p4FactorTwo) > largest_palindrome)
                                {
                                    largest_palindrome = (p4FactorOne * p4FactorTwo);
                                    lf1 = p4FactorOne;
                                    lf2 = p4FactorTwo;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"The largest palindrome number is {largest_palindrome} ({lf1} X {lf2})");

                    break;
                case 5:
                    Console.WriteLine("Problem 5: What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");
                    int p5HigestDivisor = 20;
                    int p5PSolution = (p5HigestDivisor * (p5HigestDivisor-1));

                    while (p5PSolution % 2 != 0 || p5PSolution % 3 != 0 || p5PSolution % 4 != 0 || p5PSolution % 5 != 0 ||
                             p5PSolution % 6 != 0 || p5PSolution % 7 != 0 || p5PSolution % 8 != 0 || p5PSolution % 9 != 0 ||
                             p5PSolution % 10 != 0 || p5PSolution % 11 != 0 || p5PSolution % 12 != 0 || p5PSolution % 13 != 0 ||
                             p5PSolution % 14 != 0 || p5PSolution % 15 != 0 || p5PSolution % 16 != 0 || p5PSolution % 17 != 0 ||
                             p5PSolution % 18 != 0 || p5PSolution % 19 != 0 || p5PSolution % 20 != 0)
                    {
                        p5PSolution+= p5HigestDivisor * (p5HigestDivisor - 1);
                    }
                    Console.WriteLine($"The smallest number divisible by 1..20 is {p5PSolution}");
                    break;
 
                default:
                    Console.WriteLine("You haven't solved that problem yet.");
                break;                    
            }
            Thread.Sleep(10000);
        }
        public string Reversal(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
