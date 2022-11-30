using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_1
{
    class SalaryOfEmployee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Salary : ");
            int salary = int.Parse(Console.ReadLine());

            if(salary <= 10000)
            {
                double totalSalary = salary + salary * 0.2  + salary * 0.8;
                Console.WriteLine("Total Salary : " + totalSalary);
            }
            else if(salary >= 10000 && salary <= 20000)
            {
                double totalSalary = salary + salary*1.25 + salary*1.9;
                Console.WriteLine("Total Salary : " + totalSalary);
            }
            else
            {
                double totalSalary = salary + salary * 1.3 + salary * 1.95;
                Console.WriteLine("Total Salary : " + totalSalary);
            }
        }
    }
}
