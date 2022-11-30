using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class NumberToWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 5 : ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;

                case 2:
                    Console.WriteLine("TWO");
                    break;

                case 3:
                    Console.WriteLine("THREE");
                    break;

                case 4:
                    Console.WriteLine("FOUR");
                    break;

                case 5:
                    Console.WriteLine("FIVE");
                    break;

                default:
                    Console.WriteLine("Enter a valid Input");
                    break;


            }

        }

    }
}
