using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D180
    {
        public static void D180Main()
        {
            var line = Console.ReadLine();
            int X = int.Parse(line.Split(' ')[0]);
            int Y = int.Parse(line.Split(' ')[1]);
            if (X >= 1 && X <= 1000 && Y >= 1 && Y <= 1000)
            {
                Console.WriteLine(Math.Abs(X-Y));
            }
        }
    }
}
