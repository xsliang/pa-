

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D053
    {
        public static void D053Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                if (line.ToString().Length >= 1 && line.ToString().Length <= 20)
                {
                    switch (line)
                    {
                        case "chocolate":
                        case "candy":
                            System.Console.WriteLine("Thanks!");
                            break;
                        default:
                            System.Console.WriteLine("No!");
                            break;
                    }
                }
            }
            catch
            {

            }

        }
    }

}
