using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10989_수_정렬하기3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            //List<int> myArray = new List<int>();

            //for (int i = 0; i < N; i++)
            //{
            //    myArray.Add(int.Parse(Console.ReadLine()));
            //}

            //myArray.Sort(); // 메모리 초과 발생됨

            //foreach (int a in myArray)
            //{
            //    Console.WriteLine(a);
            //}

            int[] myArray = Enumerable.Repeat<int>(0,10000000).ToArray<int>();


            int tmp = 0;

            //Console.WriteLine("N : {0}",N);

            for (int i = 0; i < N; i++)
            {
               myArray[i] = int.Parse(Console.ReadLine());
            }

            int cnt = 0;
            while (cnt <= N)
            {
                for (int i= N - 1; i > cnt; i--)
                {
                    //Console.WriteLine("tmp : , i-1 :{1}, i :{2}", tmp, myArray[i - 1], myArray[i]);
                    tmp = myArray[i];
                    if (myArray[i] < myArray[i - 1]) // 이전 배열 수가 더 크면 둘이 바꿈
                    {
                        myArray[i] = myArray[i - 1];
                        myArray[i - 1] = tmp;
                    }
                    //Console.WriteLine("tmp :{0}, i-1 :{1}, i :{2}", tmp, myArray[i - 1], myArray[i]);
                }
                //Console.WriteLine("=========================================");
                cnt++;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
