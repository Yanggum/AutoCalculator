using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCalculator
{
    public class Light : Origin
    {
        public double Create()
        {
            var rand = new Random();

            return value + rand.NextDouble();
        }
    }
}
