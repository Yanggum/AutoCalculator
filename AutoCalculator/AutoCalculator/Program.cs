using System;
using System.Text.Json;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using Newtonsoft.Json;

namespace AutoCalculator
{
    class Program
    {
        public static double seed = 0.0f;

        static void Main(string[] args)
        {
            bool state = false;
            double originVal = 0.0f;
            Light l = new Light();
            Dark d = new Dark();
            List<Double> list = new List<Double>();
            int cnt = 1000000;

            for (int i = 0; i < cnt; i++) {
                if (state)
                {
                    state = false;
                    originVal += l.Create();
                    originVal += d.Create();

                    if (originVal == 0)
                    {
                        Random rand = new Random();
                        originVal = rand.Next(0, 1) == 0 ? d.Create() : l.Create();
                        continue;
                    }

                }
                else
                {
                    state = true;
                    list.Add(originVal);
                }
            }

            if (!File.Exists(@"C:\models"))
            {
                Directory.CreateDirectory(@"C:\models");
            }

            File.WriteAllText(@"C:\models\pack.json", JsonConvert.SerializeObject(list));

        }
    }
}
