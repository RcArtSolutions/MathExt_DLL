using System;
using System.Linq;

namespace Rca.MathExt
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRandVals = RandomGenerator.NormalDistributed(0, 10, 1000);

            myRandVals.Sort();

            foreach (double val in myRandVals)
                Console.WriteLine(val.ToString());

            Console.WriteLine();
            Console.WriteLine((myRandVals.Max() + myRandVals.Min()).ToString());
            Console.ReadKey();
        }
    }
}
