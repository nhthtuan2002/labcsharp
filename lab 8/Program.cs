using System;
using System.Collections.Generic;

namespace lab_8
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var temperatures = new List<int>
            {
                1, 200, 15, 50
            };

            var dem = 0;
            foreach (var n in temperatures)
            {
                if(n >= 25) {
                    dem += 1;
                }
            }
            Console.WriteLine("Number of temperatures >= 25 degrees: {0}", dem);
            
            var dem2 = GreaterCount(temperatures, 25);
            
            Console.WriteLine("Number of elements of the list >= min: {0}", dem2);
        }

        private static int GreaterCount(List<int> list, double min)	
        { 
            var dem2 = 0;
            foreach (var n in list)
            {
                if(n >= min) {
                    dem2 = dem2 + 1;
                }
            }
            return dem2;
        }
    }
}