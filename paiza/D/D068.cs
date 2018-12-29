
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D068
    {
        public static void D068Main()
        {
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                var line2 = System.Console.ReadLine();
                int s = 0;
                int r = 0;
                foreach (char item in line2)
                {
                    if (item == 'S')
                    {
                        s++;
                    }
                    else if (item == 'R')
                    {
                        r++;
                    }
                }
                System.Console.WriteLine(s + " " + r);
            }
            catch
            {
            }

        }
    }
}
