
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D101
    {
        public static void D101Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line.Split(' ')[0]);
                int M = Convert.ToInt32(line.Split(' ')[1]);
                if (N >= 1 && N <= 50 && M >= 1 && M <= 50)
                {
                    if ((N % 2 == 0 && M % 2 != 0) || (M % 2 == 0 && N % 2 != 0))
                    {
                        System.Console.WriteLine("YES");
                    }
                    else
                    {
                        System.Console.WriteLine("NO");
                    }
                }
            }
            catch
            {
            }
        }
    }
}
