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

        static int GetTeslaCode(string param)
        {
            var result = Int32.Parse(param) > 9 ? Int32.Parse(param) : Int32.Parse(param) * 2;

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
                        arr.Add(temp / (int)Math.Pow(10, i - 1));
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
