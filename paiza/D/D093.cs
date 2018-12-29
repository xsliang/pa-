using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D093
    {
        public static void D093Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int number = Convert.ToInt32(line);
                if (number >= 1000 && number <= 50000)
                {
                    string numberStr = number.ToString();
                    char test = numberStr[0];
                    foreach (char item in line)
                    {
                        if (item != test)
                        {
                            System.Console.WriteLine("No");
                            return;
                        }
                    }

                    System.Console.WriteLine(line);
                }


            }
            catch
            {
            }


        }
    }
}
