using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace AutoCalculator
{
    public class SingularityCalculator
    {
        Thread t1 = new Thread(new ThreadStart(SingularityProc));
        Thread t2 = new Thread(new ThreadStart(SingularityProc3));
        Thread t3 = new Thread(new ThreadStart(SingularityProc9));
        public static double seed = 0.0f;
        public static void SingularityProc()
        {
            var charList = new ArrayList();

            var rand = new Random();
            bool isSeedTriggered = true;
            //            double seed = 0.0f;

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
            //            double seed = 0.0f;

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

        public static void SingularityProc9()
        {
            var charList = new ArrayList();

            var rand = new Random();
            bool isSeedTriggered = true;
            //            double seed = 0.0f;

            while (true)
            {
                if (isSeedTriggered)
                {
                    seed = 9;
                    isSeedTriggered = false;
                }

                seed = PandoraCalculator.GetTeslaCode(seed);
                Console.WriteLine(seed);
            }
        }

        public SingularityCalculator()
        {
            t1.Start();
            t2.Start();
            t3.Start();
        }

        //~SingularityCalculator()
        //{
        //    t1.Abort();
        //    t2.Abort();
        //    t3.Abort();
        //}

        public static double getCurrentSingNum()
        {
            return seed;
        }
    }
}
