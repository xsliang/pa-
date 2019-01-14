using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C048
    {

        public static double all = 0;

        public static void C048Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                double X = Convert.ToDouble(line.Split(' ')[0]);
                double P = Convert.ToDouble(line.Split(' ')[1]);
                //double all = 0;
                if (X >= 0 && X <= 10000 && P >= 1 && P <= 100)
                {
                    all = X;
                    NewMethod(X, P);

                    System.Console.WriteLine(all);
                }
            }
            catch
            {
            }
        }

        private static void NewMethod(double X, double P)
        {
            X = Math.Floor(X * ((100 - P) * 0.01));
            if (X > 0)
            {
                all = all + X;
                NewMethod(X, P);
            }
        }
    }
}
