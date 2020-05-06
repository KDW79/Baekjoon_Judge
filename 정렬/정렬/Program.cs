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

            List<int> myArray = new List<int>();

            for (int i = 0; i < N; i++)
            {
                myArray.Add(int.Parse(Console.ReadLine()));
            }
            myArray.Sort();

            foreach (int a in myArray)
            {
                Console.WriteLine(a);
            }
        }
    }
}
