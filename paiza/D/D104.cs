using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D104
    {
        public static void D104Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 1 && N <= 50)
                {
                    if (N<10)
                    {
                        System.Console.WriteLine("1000");
                    }
                    else
                    {
                        int result = N * 150;
                        System.Console.WriteLine(result);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
