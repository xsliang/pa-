

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D082
    {
        public static void D082Main()
        {
            
            

            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            if (line.Length < 2 || line.Length > 20 ||
            line2.Length < 2 || line2.Length > 20)
            {
                return;
            }

            if (line[line.Length - 1] == line2[0] && line2[line2.Length - 1] != 'n')
            {
                System.Console.WriteLine("OK");
            }
            else
            {
                System.Console.WriteLine("NG");
            }


        }
    }
}
