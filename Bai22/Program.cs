using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n270, i270, count, sum;
            Console.Write("Nhap n: ");
            n270 = int.Parse(Console.ReadLine());
            Console.Write("Cac uoc so: ");
            for (count = sum = 0, i270 = 1; i270 <= n270; ++i270)
                if (n270 % i270 == 0)
                {  
                    Console.Write("{0} ", +i270);
                    count++;
                    sum += i270;
                }
            Console.Write("\nCo {0} uoc so, tong la: {1} ", +count, +sum);
            Console.ReadKey();
        }
    }
}
