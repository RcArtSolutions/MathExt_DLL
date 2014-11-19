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
        static public List<double> NormalDistributed(double mean, double sigma, int n)
        {
            if (n <= 0)
                throw new ArgumentException("Übergebenene Anzahl darf nicht kleiner-gleich 0 sein");

            List<double> result = new List<double>();

            Random randGenerator = new Random();

            for (int i = 0; i < n; i++)
            {
                double u1 = randGenerator.NextDouble();
                double u2 = randGenerator.NextDouble();
                //double randStdNorm = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                double randStdNorm = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
                result.Add(mean + sigma * randStdNorm);
            }

            return result;
        }
    }
}