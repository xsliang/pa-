using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class helloD091
    {
        public static void D091()
        {
            try
            {
                var line = System.Console.ReadLine();
                int day = 0;
                string[] input = line.Split(' ');
                if (input.Length >= 1 && input.Length <= 10)
                {
                    foreach (var item in input)
                    {
                        if (Convert.ToInt32(item) <= 2)
                        {
                            day++;
                        }
                    }
                }

                System.Console.WriteLine(day);

            }
            catch
            {
            }


        }
    }
}
