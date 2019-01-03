using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza
{
    class C037
    {
        public static void C037Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int MM = Convert.ToInt32(line.Split(' ')[0].Split('/')[0]);
                int dd = Convert.ToInt32(line.Split(' ')[0].Split('/')[1]);

                int hh = Convert.ToInt32(line.Split(' ')[1].Split(':')[0]);
                int mm = Convert.ToInt32(line.Split(' ')[1].Split(':')[1]);

                if (MM >= 1 && MM <= 12 && dd >= 1 && dd <= 31 && hh >= 0 && hh <= 99 && mm >= 0 && mm <= 59)
                {
                    decimal result = 0;
                    int mod = 0;
                    if (hh >= 24)
                    {
                         result = Math.Ceiling(Convert.ToDecimal(hh / 24));
                         mod = hh % 24;
                    }
                    else
                    {
                        mod = hh;
                    }

                    string keka = MM.ToString().PadLeft(2, '0') + "/" + (dd + result).ToString().PadLeft(2, '0') + " " + mod.ToString().PadLeft(2, '0') + ":" + mm.ToString().PadLeft(2, '0');

                    System.Console.WriteLine(keka);
                }
            }
            catch
            {

            }
        }
    }
}
