

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D058
    {
        public static void D058Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                int l = Convert.ToInt32(line.Split(' ')[0]);
                int m = Convert.ToInt32(line.Split(' ')[1]);
                int n = Convert.ToInt32(line.Split(' ')[2]);
                if (0 <= l && l <= 20 &&
                0 <= m && m <= 20 &&
                0 <= n && n <= 20)
                {
                    string result = "";
                    for (int i = 0; i < l; i++)
                    {
                        result = result + "A";
                    }
                    for (int i = 0; i < m; i++)
                    {
                        result = result + "B";
                    }
                    for (int i = 0; i < n; i++)
                    {
                        result = result + "A";
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
