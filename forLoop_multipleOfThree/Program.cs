using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop_multipleOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine($"{num} X {i} = {num * i}");
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        }
    }
}
