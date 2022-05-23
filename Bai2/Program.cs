using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float xA270, yA270, xB270, yB270;
            Console.Write("Nhap toa do A: ");
            xA270 = float.Parse(Console.ReadLine());
            yA270 = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem B: ");
            xB270 = float.Parse(Console.ReadLine());
            yB270 = float.Parse(Console.ReadLine());

            Console.WriteLine("|AB| = " + Math.Sqrt((xB270 - xA270) * (xB270 - xA270) + (yB270 - yA270) * (yB270 - yA270)));
            Console.ReadKey();
        }
    }
}
