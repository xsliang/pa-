
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D052
    {
        public static void Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                if (1 <= n && n <= 100)
                {
                    System.Console.WriteLine((1 + n) * n / 2);
                }
            }
            catch
            {

            }

        }
    }

}
