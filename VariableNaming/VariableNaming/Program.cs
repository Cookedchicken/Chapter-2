using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int resultAdd;
            int resultMinus;
            int resultDivde;
            int resultMultiply;
            int resultModulus;

            resultAdd = num1 + num2;
            resultMinus = num2 - num1;
            resultDivde = num2 / num1;
            resultMultiply = num2 * num1;
            resultModulus = num2 % num1;
            Console.WriteLine("The result of" + num1 + " + " + num2 + " = " + resultAdd);
            Console.WriteLine("The result of ${0} - ${1} = ${2}", num1, num2, resultMinus);
            Console.WriteLine("The result of ${0} / ${1} = ${2}", num1, num2, resultDivde);
            Console.WriteLine("The result of ${0} * ${1} = ${2}", num1, num2, resultMultiply);
            Console.WriteLine("The result of ${0} % ${1} = ${2}", num1, num2, resultModulus);
        }
    }
}
