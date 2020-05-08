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
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            MemoryStream ms = new MemoryStream();

            int N = int.Parse(sr.ReadLine());
            byte[] _data = new byte[10001];

            for (int i = 0; i < N; i++) ++_data[int.Parse(sr.ReadLine())];

            ms.Write(_data, 0, _data.Length);

            byte[] _data2 = new byte[10001];
            _data2 = ms.GetBuffer();

            for (int i = 1; i < 10001; i++)
            {
                int j;
                if (_data2[i] > 0)
                {
                    for (j = 0; j < _data2[i]; j++) Console.Write(i + "\n");
                }
            }
        }
    }
}
