using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a270, b270;
            Console.Write("Nhap a: ");
            a270 = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b270 = float.Parse(Console.ReadLine());
            if (a270 == 0)
                if (b270 == 0)
                    Console.Write("Phuong trinh vo so nghiem!");
                else
                    Console.Write("Phuong trinh vo nghiem!");
            else
                Console.Write("Phuong trinh co nghiem la: "+ -b270/a270);

            Console.ReadKey();

        }
    }
}
