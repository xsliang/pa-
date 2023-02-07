using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D219
    {
        public static void D219Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 30)
            {
                if (line== "saru")
                {
                    Console.WriteLine("No");
                }
                else {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}
