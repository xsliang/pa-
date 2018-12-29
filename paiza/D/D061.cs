

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D061
    {
        public static void D061Main()
        {
            
            

            try
            {
                var line = System.Console.ReadLine();
                int c = Convert.ToInt32(line);
                if (0 <= c && c <= 100)
                {
                    int result = 0;
                    if (c == 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = c * 3;
                    }
                    System.Console.WriteLine(result);
                }
            }
            catch
            {

            }

        }
    }

}
