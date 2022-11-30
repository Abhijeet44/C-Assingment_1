using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class AreaOfShapes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \n1 : Circle \n2 : Square \n3 : Triangle \n4 : Rectangle");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the Radius of circle : ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area : " + (3.14*r*r));
                    Console.WriteLine("Perimeter : " + (2*3.14*r));
                    break;

                case 2:
                    Console.WriteLine("Enter side of Square : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area : " + a*a);
                    Console.WriteLine("Perimeter : " + 4*a);
                    break;

                case 3:
                    Console.WriteLine("Enter Base of Tringle : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height of Triangle : ");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of Triangle : " + (0.5*b*h));
                    break;

                case 4:
                    Console.WriteLine("Enter Length of Rectangle : ");
                    int l= int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter breadth of Rectangle : ");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area : " + l*d);
                    break;

                default:
                    Console.WriteLine("Enter a valid input");
                    break;
            }
        }
    }
}
