using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D069
    {
        public static void D069Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                double temp2 = 0;
                string[] aryLine = line.Split(' ');
                if (aryLine.Length != 7)
                {
                    return;
                }
                for (int i = 0; i < aryLine.Length; i++)
                {
                    double temp = Convert.ToInt32(aryLine[i]);

                    if (temp < 0 || temp > 100)
                    {
                        return;
                    }
                    temp2 = temp2 + temp;
                }

                double temp3 = Math.Round(temp2 / 7, 1, MidpointRounding.ToEven);

                System.Console.WriteLine(temp3.ToString("#0.0"));

            }
            catch
            {
            }
        }
    }
}
