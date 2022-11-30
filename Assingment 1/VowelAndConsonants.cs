using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class VowelAndConsonants
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character : ");
            char c = Convert.ToChar(Console.ReadLine());

            if(c == 'a' || c == 'A')
            {
                Console.WriteLine("Vovel");
            }
            else if(c == 'e' || c == 'E')
            {
                Console.WriteLine("Vowel");
            }
            else if(c == 'i' || c == 'I')
            {
                Console.WriteLine("Voewl");
            }
            else if(c == 'o' || c == 'O')
            {
                Console.WriteLine("Vowel");
            }
            else if(c == 'u' || c == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

        }
    }
}
