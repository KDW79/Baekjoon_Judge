using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10989_수_정렬하기3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());

            ////List<int> myArray = new List<int>();

            ////for (int i = 0; i < N; i++)
            ////{
            ////    myArray.Add(int.Parse(Console.ReadLine()));
            ////}

            ////myArray.Sort(); // 메모리 초과 발생됨

            ////foreach (int a in myArray)
            ////{
            ////    Console.WriteLine(a);
            ////}

            //int[] myArray = Enumerable.Repeat<int>(0,10000).ToArray<int>();


            //int tmp = 0;

            ////Console.WriteLine("N : {0}",N);

            //for (int i = 0; i < N; i++)
            //{
            //   myArray[i] = int.Parse(Console.ReadLine());
            //}

            //int cnt = 0;
            //while (cnt <= N)
            //{
            //    for (int i= N - 1; i > cnt; i--)
            //    {
            //        //Console.WriteLine("tmp : , i-1 :{1}, i :{2}", tmp, myArray[i - 1], myArray[i]);
            //        tmp = myArray[i];
            //        if (myArray[i] < myArray[i - 1]) // 이전 배열 수가 더 크면 둘이 바꿈
            //        {
            //            myArray[i] = myArray[i - 1];
            //            myArray[i - 1] = tmp;
            //        }
            //        //Console.WriteLine("tmp :{0}, i-1 :{1}, i :{2}", tmp, myArray[i - 1], myArray[i]);
            //    }
            //    //Console.WriteLine("=========================================");
            //    cnt++;
            //}

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //StreamReader sr = new StreamReader(Console.OpenStandardInput());
            //StringBuilder sb = new StringBuilder();

            int N = int.Parse(Console.ReadLine());
            int[] b = new int[10001];

            for (int i = 0; i < N; i++) ++b[int.Parse(Console.ReadLine())];

            for (int i = 1; i < 10001; i++)
            {
                int j;
                //for (; b[i]>0; b[i]--)
                //{
                //    sb.AppendFormat("{0}\n", i);
                //}
                if (b[i] > 0)
                {
                    for (j = 0; j < b[i]; j++) Console.WriteLine(i);
                }
            }
            //Console.WriteLine(sb.ToString());
        }
    }
}
