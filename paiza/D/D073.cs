using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D073
    {
        public static void D073Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                string result = string.Empty;
                //string[] aryLine = line.Split(' ');
                if (line.Length >= 1 && line.Length <= 100)
                {
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        result = result + line[i];
                    }
                }

                System.Console.WriteLine(result);


            }
            catch
            {
            }
        }
    }
}
