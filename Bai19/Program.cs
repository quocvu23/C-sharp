using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h270, m270, s270;
            long t270;
            Console.Write("Nhap gio, phut, giay [1]: ");
            h270 =  int.Parse(Console.ReadLine());
            m270 = int.Parse(Console.ReadLine());   
            s270 = int.Parse(Console.ReadLine());

            t270 = 3600 * h270 + 60 * m270 + s270;

            Console.Write("Nhap gio, phut, giay [2]: ");
            h270 = int.Parse(Console.ReadLine());
            m270 = int.Parse(Console.ReadLine());
            s270 = int.Parse(Console.ReadLine());

            t270 -= 3600 * h270 + 60 * m270 + s270;

            if(t270 < 0)
                t270 = -t270;
            Console.Write("Hieu thoi gian: {0} gio, {1} phut, {2} giay", +t270 / 3600, +(t270 % 3600) / 60, +(t270 % 3600) % 60);
            Console.ReadKey();
        }
    }
}
