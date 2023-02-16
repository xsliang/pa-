using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D176
    {
        public static void D176Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 1000)
            {
                if (line.Length <= 20)
                {
                    Console.WriteLine("OK");
                }
                else {
                    Console.WriteLine("NG");
                }
            }
        }
    }
}
