using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D096
    {
        public static void D096Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                if (line.Length >= 1 && line.Length <= 100)
                {
                    if (line.Contains("I") || line.Contains("l") || line.Contains("i"))
                    {
                        System.Console.WriteLine("caution");
                    }
                    else
                    {
                        System.Console.WriteLine(line);
                    }
                }


            }
            catch
            {
            }


        }
    }
}
