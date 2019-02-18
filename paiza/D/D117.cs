using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D117
    {
        static void D117Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                int count = Convert.ToInt32(line);
                string[] N = line2.Split(' ');
                if (count > 0 && count < 100 && N.Length == count)
                {
                    int a = 0;
                    for (int i = 0; i < N.Length; i++)
                    {
                        int temp = Convert.ToInt32(N[i]);
                        if (temp < 1 || temp > 6)
                        {
                            return;
                        }
                        a = a + temp;
                    }

                    Console.WriteLine(a);
                }
            }
            catch
            {
            }
        }
    }
}
