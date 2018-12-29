using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D100
    {
        public static void D100Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                if (line.Length >= 1 && line.Length <= 100)
                {
                    if (line.Split('-').Length > line.Split('_').Length)
                    {
                        line = line.Replace('_', '-');
                    }
                    else
                    {
                        line = line.Replace('-', '_');
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
