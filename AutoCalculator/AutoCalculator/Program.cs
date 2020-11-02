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
            int[,] input = new int[,] { { 1, 0 }, { 1, 1 }, { 0, 1 }, { 0, 0 } };
            int[] outputs = { 0, 1, 0, 0 };

            Random r = new Random();

            double[] weights = { r.NextDouble(), r.NextDouble(), r.NextDouble() };

            double learningRate = 1;
            double totalError = 1;

            // 학습
            while (totalError > 0.2)
            {
                totalError = 0;
                for (int i = 0; i < 4; i++)
                {
                    int output = calculateOutput(input[i, 0], input[i, 1], weights);

                    int error = outputs[i] - output;

                    weights[0] += learningRate * error * input[i, 0];
                    weights[1] += learningRate * error * input[i, 1];
                    weights[2] += learningRate * error * 1;

                    totalError += Math.Abs(error);
                }

            }

            Console.WriteLine("Results:");

            // 평가
            for (int i = 0; i < 4; i++)
                Console.WriteLine(calculateOutput(input[i, 0], input[i, 1], weights));

            Console.ReadLine();

        }

        private static int calculateOutput(double input1, double input2, double[] weights)
        {
            double sum = input1 * weights[0] + input2 * weights[1] + 1 * weights[2];
//            Console.WriteLine(sum);
            return (sum >= 0) ? 1 : 0;
        }

    }
}
