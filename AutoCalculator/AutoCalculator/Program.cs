using System;

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
                var rand = new Random();
                oper = rand.Next(0, 3);
                test = rand.Next(1, 9);
                test2 = rand.Next(1, 9);
                //                result = 

                switch (oper)
                {
                    // +
                    case 0:
                        result = test + test2;
                        operString = "+";
                        break;
                    // -
                    case 1:
                        result = test - test2;
                        operString = "-";
                        break;
                    // *
                    case 2:
                        result = test * test2;
                        operString = "*";
                        break;
                    // /
                    case 3:
                        result = test / test2;
                        operString = "/";
                        break;
                }

                Console.WriteLine(test + " " + operString + " " + test2 + " = " + result);

            }
        }
    }
}
