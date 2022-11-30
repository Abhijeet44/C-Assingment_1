using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalStatments
{
    class GreateestAmongThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number : ");
            int c = int.Parse(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.WriteLine("1st Number is Greater");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("2nd Number is Greater");
            }
            else
            {
                Console.WriteLine("3rd number is Greater");
            }
        }
    }
}
