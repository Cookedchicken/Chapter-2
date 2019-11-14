using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dozenEggs = 12;
            int numEggs; // num of eggs entered
            int cartonofEggs;
            int eggsRemaining;

            Console.WriteLine("How many eggs are there? >>>");
            numEggs = Convert.ToInt32(Console.ReadLine());
      

            cartonofEggs = numEggs / dozenEggs;
            eggsRemaining = numEggs % dozenEggs;

            Console.WriteLine("The number of eggs colleted {0}, and we have {1} cartons of eggs and, "+
                "{2} eggs remainig", numEggs, cartonofEggs, eggsRemaining);



        }
    }
}
