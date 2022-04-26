using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a270 = Int32.Parse(Console.ReadLine());
            double b270 = Int32.Parse(Console.ReadLine());
            double c270 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a270, b270, c270);

            double delta = pt.delta(a270, b270, c270);
            int check270 = pt.nghiem(delta);
            if (check270 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check270 == 0)
            {
                double x = -b270 / (2 * a270);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b270 - Math.Sqrt(delta)) / (2 * a270);
                double x2 = (-b270 + Math.Sqrt(delta)) / (2 * a270);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
            Console.ReadKey();
        }
    }

    class ptb2
    {
        private double a270;
        private double b270;
        private double c270;

        public ptb2()
        {
        }

        public ptb2(double a270, double b270, double c270)
        {
            A = a270;
            B = b270;
            C = c270;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a270, double b270, double c270)
        {
            return b270 * b270 - 4 * a270 * c270;
        }

        public int nghiem(double delta270)
        {
            if (delta270 < 0)
            {
                return -1;
            }
            else if (delta270 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
