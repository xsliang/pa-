using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C115
    {
        public static void C115Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line.Split(' ')[0]);
            int M = int.Parse(line.Split(' ')[1]);
            if (N>=1 && N<=1000)
            {
                int result = 0;
                for (int i = 0; i < N-1; i++)
                {
                    var line2 = Console.ReadLine();
                    int A = int.Parse(line2);
                    if (A>=1 && A<=200)
                    {
                        if (A<=M)
                        {
                            result = result + A;
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
