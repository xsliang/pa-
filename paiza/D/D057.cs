

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D057
    {
        public static void D057Main()
        {
            
            
            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            try
            {
                int g = Convert.ToInt32(line);
                if (1 <= g && g <= 3)
                {
                    string[] words = line2.Split(' ');
                    if (words[g - 1].Length >= 1 && words[g - 1].Length <= 20)
                    {
                        Console.WriteLine(words[g - 1]);
                    }
                }

            }
            catch
            {

            }

        }
    }

}
