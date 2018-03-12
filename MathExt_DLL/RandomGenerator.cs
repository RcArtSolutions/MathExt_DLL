using System;
using System.Collections.Generic;

namespace Rca.MathExt
{
    public class RandomGenerator
    {
        /// <summary>
        /// Normalverteilte Zufallszahlen nach der Box-Muller-Methode
        /// </summary>
        /// <param name="mean">Mittelwert</param>
        /// <param name="sigma">Abweichung (2s, 3s...)</param>
        /// <param name="n">Anzahl der zu erzeugenden Werte</param>
        /// <returns>Zufallszahlen</returns>
        static public List<double> NormalDistributed(double mean, double sigma, int n = 100)
        {
            if (n <= 0)
                throw new ArgumentException("Anzahl darf nicht kleiner-gleich 0 sein, übergeben wurde n = " + n);

            var result = new List<double>();
            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var u1 = rnd.NextDouble();
                var u2 = rnd.NextDouble();
                //double randStdNorm = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                double rndStdNorm = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
                result.Add(mean + sigma * rndStdNorm);
            }

            return result;
        }
    }
}