

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D056
    {
        public static void D056Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                int r_1 = Convert.ToInt32(line.Split(' ')[0]);
                int r_2 = Convert.ToInt32(line.Split(' ')[1]);
                if (1 <= r_1 && r_1 > r_2 && r_1 <= 20 && r_2 <= 20)
                {
                    System.Console.WriteLine(r_1 * r_1 * r_1 - r_2 * r_2 * r_2);
                }
            }
            catch
            {

            }

        }
    }

}
