using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoCalculator
{
    public class PandoraCalculator
    {
        public static double GetTeslaCode(int param)
        {
            return GetTeslaCode(param.ToString());
        }

        public static double GetTeslaCode(double param)
        {
            return GetTeslaCode(param.ToString());
        }

        public static double GetTeslaCode(string param)
        {
            var result = 0.0;
            var length = 0;

            if (param.Contains('.'))
            {
                length = param.Split('.')[1].Length;
                result = Double.Parse(param);
                for (var i=0; i<length; i++)
                {
                    result = result * 10;
                }
            }
            else
            {
                result = Int32.Parse(param) > 9 ? Int32.Parse(param) : Int32.Parse(param) * 2;
            }

            result = Math.Round(result);

            if (result >= 10)
            {
                int cnt = result.ToString().Length;

                while (result >= 10)
                {
                    var arr = new ArrayList();
                    var temp = result;

                    // 한 자리 수로 만드는 알고리즘
                    for (var i = cnt; i > 0; i--)
                    {
                        arr.Add((int)(temp / (int)Math.Pow(10, i - 1)));
                        temp = temp % (int)Math.Pow(10, i - 1);
                    }

                    int sum = 0;
                    for (var i = 0; i < arr.Count; i++)
                    {
                        sum += (int)arr.ToArray()[i];
                    }

                    result = sum;
                }
            }

            return result;
        }


    }
}
