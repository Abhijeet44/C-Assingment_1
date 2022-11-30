using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class DivisibleByFiveAndEleven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());

            if(n % 5 == 0 && n % 11 == 0)
            {
                Console.WriteLine("Number is Divisible by Both 5 & 11");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 5 & 11");
            }
        }
    }
}
