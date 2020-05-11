using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2108_통계학
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //int[] b = new int[500001];

            List<int> b = new List<int>();

            for (int i = 0; i < N; i++)
            {
                //b[i] = int.Parse(Console.ReadLine());
                b.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(sansul(b, N));
            Console.WriteLine(findMid(b));
            Console.WriteLine(findFrequently(b));
            Console.WriteLine(findRange(b));
        }

        public static int sansul(List<int> input, int N)
        {
            int cnt = 0;
            double result = 0;
            while (cnt < N)
            {
                result += input[cnt];
                cnt++;
            }

            result = Math.Round(result / N);

            return (int)result;
        }

        public static int findMid(List<int> input)
        {
            int result = 0;
            input.Sort();
            if (input.Count == 1)
                result = input[0];
            else if (input.Count > 1)
            result = input[(int)Math.Round((double)input.Count / 2)];

            return result;
        }

        public static int findFrequently(List<int> input)
        {
            int cnt = 0;
            int result = 0;
            int[] data = new int[input.Count];
            input.Sort();
            if (input.Count == 1)
                result = input[0];
            else if (input.Count > 1)
                for (int i = 0; i < input.Count; i++)
                {
                    
                }
                //while (true)
                //{
                //    if (input[cnt] < input[cnt + 1])
                //    {
                //        result = input[cnt + 1];
                //        break;
                //    }
                //    cnt++;
                //}

            return result;
        }

        public static int findRange(List<int> input)
        {
            int result = 0;
            int min, max;
            min = input.Min();
            max = input.Max();
            result = max - min;
            return result;
        }

    }
}
