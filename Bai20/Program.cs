using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kw270;
            long money;
            Console.Write("Nhap so Kw tieu thu: ");
            kw270 = int.Parse(Console.ReadLine());

            money = kw270 * 500;
            if(kw270 > 100) 
                money += (kw270 - 100)*300;
            if (kw270 > 250)
                money += (kw270 - 250) * 200;
            if (kw270 > 350)
                money += (kw270 - 350) * 500;
            Console.Write("Chi phi: "+money);
            Console.ReadKey();
        }
    }
}
