using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x270, y270, z270;
            for (x270 = 1; x270 < 100 / 5; ++x270)
                for (y270 = 1; y270 < 100 / 3; ++y270)
                {
                    z270 = 100 - (x270 + y270);
                    if (300 == 15 * x270 + 9 * y270 + z270)
                        Console.Write("( {0} , {1} , {2} )\n", +x270, +y270, +z270);

                }
            Console.ReadKey();
        }
    }
}
