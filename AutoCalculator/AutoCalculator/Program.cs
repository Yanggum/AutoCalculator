using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace AutoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = 0;
            var test2 = 0;
            var result = 0;
            var oper = -1;
            var operString = "";

            while (true)
            {
                Console.Write("숫자를 입력하세요: ");
                operString = Console.ReadLine();
                Console.WriteLine(PandoraCalculator.GetTeslaCode(operString));
            }
        }
    }
}
