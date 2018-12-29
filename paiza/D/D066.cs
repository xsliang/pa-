
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D066
    {
        public static void D066Main()
        {
            var line = System.Console.ReadLine();
            try
            {
                int m = Convert.ToInt32(line.Split(' ')[0]);
                int n = Convert.ToInt32(line.Split(' ')[1]);
                if (1 <= m && m <= 20 && 1 <= n && n <= 20)
                {
                    if (n-m>=0)
                    {
                        System.Console.WriteLine(n - m);
                    }
                    else
                    {
                        System.Console.WriteLine("No");
                    }
                }
                
            }
            catch
            {
            }

        }
    }
}
