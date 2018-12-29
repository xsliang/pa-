
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D076
    {
        public static void D076Main()
        {
            try
            {

                var w = System.Console.ReadLine();
                var s = System.Console.ReadLine();

                if (w.Length >= 1 && w.Length <= 100 &&
                    s.Length >= 1 && s.Length <= 100)
                {
                    if (s.Contains(w))
                    {
                        System.Console.WriteLine("NG");
                    }
                    else
                    {
                        System.Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
