using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D103
    {
        public static void D103Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                string result = string.Empty;
                string alphabate = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (line.Length >= 1 && line.Length <= 50)
                {
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        if (alphabate.Contains(line[i].ToString()))
                        {
                            result += line[i].ToString();
                        }
                    }

                    System.Console.WriteLine(result);
                }
            }
            catch
            {
            }
        }
    }
}
