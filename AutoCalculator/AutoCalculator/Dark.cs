using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCalculator
{
    public class Dark : Origin
    {
        public double Create()
        {
            var rand = new Random();            

            return value - rand.NextDouble();
        }
    }
}
