using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        
        {
            const double PREDICITED_RAISES = 1.04;
            double employeesalary1;
            double employeesalary2;
            double employeesalary3;

            Console.WriteLine("What is employee 1's salary this year >>>");
            employeesalary1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is employee 2's salary this year >>>");
            employeesalary2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is employee 3's salary this year >>>");
            employeesalary3 = Convert.ToDouble(Console.ReadLine());

            employeesalary1 = employeesalary1 * PREDICITED_RAISES;
            employeesalary2 = employeesalary2 * PREDICITED_RAISES;
            employeesalary3 = employeesalary3 * PREDICITED_RAISES;

            Console.WriteLine("Employee 1 slaray is {0}", employeesalary1);
            Console.WriteLine("Employee 2 slaray is {0}", employeesalary2);
            Console.WriteLine("Employee 3 slaray is {0}", employeesalary3);
        }


       
    }
}
