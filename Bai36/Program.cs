using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n270, k270, i270, count;
            Console.Write("Nhap n: ");
            n270 = int.Parse(Console.ReadLine());
            k270 = 2;
            count = 0;
            while (count < n270)
            {
                for (i270 = 2; i270 * i270 <= k270; ++i270)
                    if (k270 % i270 == 0)
                        break;
                if (i270 * i270 > k270)
                {
                    Console.Write("{0} ",+k270);
                    count++;
                }
                k270++;
                Console.ReadKey();
            }

        }
    }
}

