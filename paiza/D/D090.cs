using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D090
    {
        public static void D090Main()
        {
            var line = System.Console.ReadLine();

            if (line.Split(' ').Length != 5)
            {
                return;
            }

            int a = Convert.ToInt32(line.Split(' ')[0]);
            int b = Convert.ToInt32(line.Split(' ')[1]);
            int c = Convert.ToInt32(line.Split(' ')[2]);
            int d = Convert.ToInt32(line.Split(' ')[3]);
            int e = Convert.ToInt32(line.Split(' ')[4]);

            if (a < 0 || a > 100 ||
                b < 0 || b > 100 ||
                c < 0 || c > 100 ||
                d < 0 || d > 100 ||
                e < 0 || e > 100)
            {
                return;
            }

            int temp = a + b + c + d + e;

            System.Console.WriteLine(temp.ToString().Substring(temp.ToString().Length - 1, 1));
        }
    }
}
