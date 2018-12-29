

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D086
    {
        public static void D086Main()
        {
            var line = System.Console.ReadLine();
            double count = Convert.ToDouble(line);
            if (count < 1 || count > 100)
            {
                return;
            }

            System.Console.WriteLine(count / 3.0 * 15);
        }
    }
}
