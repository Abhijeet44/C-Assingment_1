using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class AlphabetDigitOrSpChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character : ");
            char c = Convert.ToChar(Console.ReadLine());

            if((c >= 'A' && c <= 'Z') || c >= 'a' && c <= 'z')
            {
                Console.WriteLine("It is Alphabet");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine("It is Digit");
            }
            else
            {
                Console.WriteLine("It is a Special Character");
            }
        }
    }
}
