using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D072
    {
        public static void D072Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                string[] aryLine = line.Split(' ');
                double X = Convert.ToDouble(aryLine[0]);
                double Y = Convert.ToDouble(aryLine[1]);
                double P = Convert.ToDouble(aryLine[2]);
                if (X >= 1 && X <= 1000 &&
                    Y >= 1 && Y <= 1000 &&
                    P >= 1 && P <= 10000)
                {
                    double result = Math.Ceiling((X / Y)) * P;

                    System.Console.WriteLine(result);

                }



            }
            catch
            {
            }
        }
    }
}
