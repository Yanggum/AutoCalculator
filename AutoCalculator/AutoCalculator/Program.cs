using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace AutoCalculator
{
    class Program
    {
        public static double seed = 0.0f;

        static void Main(string[] args)
        {
            double originVal = 0.0f;
            Light l = new Light();
            Dark d = new Dark();

            while (true)
            {
                originVal += l.Create();
                originVal += d.Create();

                Console.WriteLine(originVal);
            }
        }
    }
}
