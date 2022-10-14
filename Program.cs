using System;
using System.Collections.Generic;
using System.Linq;


namespace PalinPerfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting point N:");
            int startingPoint = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the ending point M:");
            int endingPoint = int.Parse(Console.ReadLine());

            int m, n, sum;

            
            Console.WriteLine("The palindromic perfect squares are as follows:");

            for(int i = startingPoint; i < endingPoint; i++)
            {
                
                if (IsPalindrome(i))
                {
                    i = 1;
                    sum = 0;
                    while(i < startingPoint)
                    {
                        if(n%i == startingPoint)
                    }
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPalindrome(int number)
        {
            int remainder,sum = 0;
            int temporaryNumber =number;
            
            while(number > 0)
            {
                remainder = number % 10;

                sum = (sum * 10) + remainder;

                number = number / 10;
            }
            if(temporaryNumber == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public 
    }

}

//first start by a simple operation which generates 