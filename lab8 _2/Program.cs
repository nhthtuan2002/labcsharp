using System;
using System.Collections.Generic;

namespace lab8__2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<double> able = new List<double>();
            var dem = GreaterCount(able, 0);
            Console.WriteLine("Number of elements of the list >= min: {0}", dem);
        }

        private static double GreaterCount(IEnumerable<double> able, double min)
        {
            double dem = 0;
            foreach (var e in able)
            {
                if (e>=min)
                {
                    dem += 1;
                }
            }
            return dem;
        }
    }
}