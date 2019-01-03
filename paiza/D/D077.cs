
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D077
    {
        public static void D077Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                int a = Convert.ToInt32(line.Split(' ')[0]);
                int b = Convert.ToInt32(line.Split(' ')[1]);

                if (a >= 1 && a <= 9999 &&
                    b >= 1 && b <= 9999)
                {
                    if (a * b > 10000)
                    {
                        System.Console.WriteLine("NG");
                    }
                    else
                    {
                        System.Console.WriteLine(a * b);
                    }
                }
            }
            catch
            {
            }
        }
    }
}
