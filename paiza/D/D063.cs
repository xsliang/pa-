

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D063
    {
        public static void D063Main()
        {
            
            
            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            try
            {
                int t1 = Convert.ToInt32(line.Split(' ')[0]);
                int t2 = Convert.ToInt32(line.Split(' ')[1]);
                int t3 = Convert.ToInt32(line.Split(' ')[2]);
                int t4 = Convert.ToInt32(line.Split(' ')[3]);
                int t5 = Convert.ToInt32(line.Split(' ')[4]);

                int a = Convert.ToInt32(line2);

                if (0 <= t1 && t1 < t2 && t2 < t3 && t3 < t4 && t4 < t5 && t5 <= 59 &&
                0 <= a && a <= 59)
                {
                    if (a <= t1)
                    {
                        System.Console.WriteLine(1);
                    }
                    else if (a <= t2)
                    {
                        System.Console.WriteLine(2);
                    }
                    else if (a <= t3)
                    {
                        System.Console.WriteLine(3);
                    }
                    else if (a <= t4)
                    {
                        System.Console.WriteLine(4);
                    }
                    else if (a <= t5)
                    {
                        System.Console.WriteLine(5);
                    }
                    else if (a > t5)
                    {
                        System.Console.WriteLine(6);
                    }
                }
            }
            catch
            {

            }
        }
    }

}
