using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C099
    {
        public static void C099Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line.Split(' ')[0]);
            int D = int.Parse(line.Split(' ')[1]);
            if (N >= 2 && N <= 100 && D >= 2 && D <= 10)
            {
                int result = D;
                for (int i = 0; i <= N - 2; i++)
                {
                    var line2 = Console.ReadLine();
                    int A = int.Parse(line2);
                    if (A >= 1 && A <= D/2)
                    {
                        result = result + (D - A);
                    }
                }
                result = D * result;
                Console.WriteLine(result);
            }
        }
    }
}
