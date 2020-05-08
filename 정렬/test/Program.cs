using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //BufferedStream bs = new BufferedStream("TEST");
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.WriteLine("test");
            Console.WriteLine(sw);

        }
    }
}
