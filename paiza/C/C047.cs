
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C047
    {
        public static void C047Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 0 || N > 100)
            {
                return;
            }

            int count = 0;
            int first = 1;
            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                int f = Convert.ToInt32(line);
                if (f < 0 || f > 100)
                {
                    return;
                }

                count = count + (Math.Abs(f - first));
                first = f;
            }

            Console.WriteLine(count);
        }
    }
}
