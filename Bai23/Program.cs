using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n270, i270, j270, sum270;
            Console.Write("Nhap n: ");
            n270 = int.Parse(Console.ReadLine());
            Console.Write("Cac so hoan hao nho hon {0} : ", + n270);
            for(i270 = 1;i270<n270;i270++)
            {
                for (sum270 = 0, j270 = 1; sum270 <= i270 && j270 < i270; j270++)
                    if (i270 % j270 == 0)
                        sum270 += j270;
                if (sum270 == i270)
                    Console.Write("{0} ",+i270);
            }    
            Console.ReadKey();

        }
    }
}
