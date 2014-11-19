using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rca.MathExt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myRandVals = RandomGenerator.NormalDistributed(0, 10, 1000);

            myRandVals.Sort();

            foreach (double val in myRandVals)
            {
                Console.WriteLine(val.ToString());
            }

            Console.WriteLine((myRandVals.Max() + myRandVals.Min()).ToString());

            Console.ReadKey();
        }
    }
}
