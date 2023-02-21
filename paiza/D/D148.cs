using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D148
    {
        public static void D148Main()
        {
            var line = Console.ReadLine();
            int A = int.Parse(line.Split(' ')[0]);
            int B = int.Parse(line.Split(' ')[1]);
            var line2 = Console.ReadLine();
            int C = int.Parse(line2);
            if (A >= 0 && A <= 100 && B >= 0 && B <= 100 && C>=0 && C<=100)
            {
                if (A>=C)
                {
                    Console.WriteLine(A+B);
                }
                else
                {
                    Console.WriteLine(A);
                }
            }
        }
    }
}
