
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B038
    {
        public static void B038Main()
        {
            var input = System.Console.ReadLine();

            if (input.Split(' ').Length != 4)
            {
                return;
            }

            int a = Convert.ToInt32(input.Split(' ')[0]);
            int b = Convert.ToInt32(input.Split(' ')[1]);
            int c = Convert.ToInt32(input.Split(' ')[2]);
            int d = Convert.ToInt32(input.Split(' ')[3]);

            if (a < 0 || a > 100 ||
                b < 0 || b > 100 ||
                c < 0 || c > 100 ||
                d < 0 || d > 100)
            {
                return;
            }

            int resultX = 0;
            int resultY = 0;
            bool ok = false;

            for (int x = 1; x <= b; x++)
            {
                if (ok == true)
                {
                    break;
                }

                for (int y = 1; y < b; y++)
                {
                    if (ok == true)
                    {
                        break;
                    }
                    if (x + y == b && (c * x) + (d * y) == a)
                    {
                        resultX = x;
                        resultY = y;
                        ok = true;
                    }
                }
            }

            if (ok == true)
            {
                System.Console.WriteLine(resultX + " " + resultY);
            }
            else
            {
                System.Console.WriteLine("miss");
            }
        }
    }
}
