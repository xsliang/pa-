using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D207
    {
        public static void D207Main()
        {
            var line = Console.ReadLine();
            if (line.Length>=3 && line.Length<=20)
            {
                Console.WriteLine(line.Substring(0,3));
            }
        }
    }
}
