using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace AutoCalculator
{
    class Program
    {
        public static void SingularityProc()
        {
            var charList = new ArrayList();

            var rand = new Random();
            bool isSeedTriggered = true;
            double seed = 0.0f;

            while (true)
            {
                if (isSeedTriggered)
                {
                    seed = 1;
                    isSeedTriggered = false;
                }

                seed = PandoraCalculator.GetTeslaCode(seed);
                Console.WriteLine(seed);
            }
        }

        public static void SingularityProc3()
        {
            var charList = new ArrayList();

            var rand = new Random();
            bool isSeedTriggered = true;
            double seed = 0.0f;

            while (true)
            {
                if (isSeedTriggered)
                {
                    seed = 3;
                    isSeedTriggered = false;
                }

                seed = PandoraCalculator.GetTeslaCode(seed);
                Console.WriteLine(seed);
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(SingularityProc));
            Thread t2 = new Thread(new ThreadStart(SingularityProc3));

            t1.Start();
            t2.Start();


        }
    }
}
