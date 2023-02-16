using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D173
    {
        public static void D173Main()
        {
            var line = Console.ReadLine();
            string a = line.Split(' ')[0];
            string b = line.Split(' ')[1];

            if (a.Length >= 1 && a.Length <= 10 && b.Length >= 1 && b.Length <= 10)
            {
                Console.WriteLine(b + " " + a);

            }
        }
    }
}
