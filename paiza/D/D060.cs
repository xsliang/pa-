
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D060
    {
        public static void D060Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                int a = Convert.ToInt32(line.Split(' ')[0]);
                int b = Convert.ToInt32(line.Split(' ')[1]);
                if (0 <= a && a <= 100 && 0 <= b && b <= 100)
                {
                    System.Console.WriteLine(0 + a - b);
                }
            }
            catch
            {

            }

        }
    }

}
