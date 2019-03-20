using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C061
    {
        public static void C061Main()
        {
            var line = System.Console.ReadLine();
            double A = Convert.ToDouble(line.Split(' ')[0]);
            double B = Convert.ToDouble(line.Split(' ')[1]);

            if (A >= 1 && A <= 999 && B >= 1 && B <= 999)
            {
                string a1 = string.Empty;
                double temp = Convert.ToDouble((A * 0.1).ToString("#0.000").Split('.')[1].Substring(0, 1)) +
                    Convert.ToDouble((B * 0.1).ToString("#0.000").Split('.')[1].Substring(0, 1));
                if (temp >= 10)
                {
                    temp = temp - 10;
                }
                a1 = temp.ToString();

                string a2 = string.Empty;
                if (A.ToString().Length >= 2 || B.ToString().Length >= 2)
                {
                    double temp2 = Convert.ToDouble((A * 0.01).ToString("#0.000").Split('.')[1].Substring(0, 1)) +
                    Convert.ToDouble((B * 0.01).ToString("#0.000").Split('.')[1].Substring(0, 1));
                    if (temp2 >= 10)
                    {
                        temp2 = temp2 - 10;
                    }
                    a2 = temp2.ToString();
                }

                string a3 = string.Empty;
                if (A.ToString().Length >= 3 || B.ToString().Length >= 3)
                {
                    double temp3 = Convert.ToDouble((A * 0.001).ToString("#0.000").Split('.')[1].Substring(0, 1)) +
                    Convert.ToDouble((B * 0.001).ToString("#0.000").Split('.')[1].Substring(0, 1));
                    if (temp3 >= 10)
                    {
                        temp3 = temp3 - 10;
                    }
                    a3 = temp3.ToString();

                }

                Console.WriteLine(a3 + a2 + a1);
            }
        }
    }
}
