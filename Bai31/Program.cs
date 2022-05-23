using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i270, j270;
            Console.WriteLine("Bang cuu chuong");
            for (i270 = 2; i270 <= 9; i270++)
            {
                for (j270 = 1; j270 <= 10; j270++)
                    Console.WriteLine("{0} * {1} = {2}", +i270, +j270, i270 * j270);
                Console.WriteLine("\n");
            }
            Console.ReadKey();  
        }
    }
}
