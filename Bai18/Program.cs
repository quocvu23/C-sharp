using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long h270;
            Console.Write("Nhap so gio: ");
            h270 = long.Parse(Console.ReadLine());
            Console.Write("{0} tuan, {1} ngay, {2} gio\n", +h270 / (24 * 7), +(h270 % (24 * 7)) / 24, +(h270 % (24 * 7)) % 24);
            Console.ReadKey();
        }
    }
}
