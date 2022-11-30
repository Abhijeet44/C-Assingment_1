using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year : ");
            int year = int.Parse(Console.ReadLine());

            if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0 ))
            {
                Console.WriteLine("This is a Leap Year");
            }
            else
            {
                Console.WriteLine("This is NOT a Leap Year");
            }
        }
    }
}
