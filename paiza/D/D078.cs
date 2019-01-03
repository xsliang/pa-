
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D078
    {
        public static void D078Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();

                int result = 0;
                for (int i = 0; i < 7; i++)
                {
                    int number = Convert.ToInt32(line.Split(' ')[i]);

                    if (number < 0 || number > 100)
                    {
                        return;
                    }

                    result = result + number;

                }

                result = result / 7;

                if (result >= Convert.ToInt32(line2))
                {
                    System.Console.WriteLine("pass");
                }
                else
                {
                    System.Console.WriteLine("failure");
                }
            }
            catch
            {
            }
        }
    }
}
