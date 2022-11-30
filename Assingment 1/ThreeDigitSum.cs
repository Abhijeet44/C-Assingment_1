using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class ThreeDigitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            if(num > 99 && num < 1000)
            {
                for(int i=0; i<=num ; i++)
                {
                   
                }
                 
            }
            else
            {
                Console.WriteLine("This is Not a three Digit number");
            }
        }
    }
}
