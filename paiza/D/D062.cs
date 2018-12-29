

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D062
    {
        public static void D062Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                int h1 = Convert.ToInt32(line.ToString().Split(' ')[0]);
                int h2 = Convert.ToInt32(line.ToString().Split(' ')[1]);
                int h3 = Convert.ToInt32(line.ToString().Split(' ')[2]);
                if (h1 >= 1 && h1 <= 10 &&
                h2 >= 1 && h2 <= 10 &&
                h3 >= 1 && h3 <= 10 &&
                h1 + h2 + h3 == 10)
                {
                    string temp = "ABCDEFGHIJ";
                    System.Console.WriteLine(temp.Substring(0, h1));
                    System.Console.WriteLine(temp.Substring(h1, h2));
                    System.Console.WriteLine(temp.Substring(h2 + h1, h3));
                }
            }
            catch
            {

            }

        }
    }

}
