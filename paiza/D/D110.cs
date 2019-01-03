using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D110
    {
        public static void D110Main()
        {
            try
            {
                var line1 = System.Console.ReadLine();
                int a = Convert.ToInt32(line1.Split(' ')[0]);
                int b = Convert.ToInt32(line1.Split(' ')[1]);
                int c = Convert.ToInt32(line1.Split(' ')[2]);
                if (a >= 0 && a <= 100 && b >= 0 && b <= 100 && c >= 0 && c <= 100)
                {
                    System.Console.WriteLine(a*b*c);
                }
            }
            catch
            {
            }
        }
    }
}
