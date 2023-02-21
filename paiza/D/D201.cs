using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D201
    {
        public static void D201Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N >= 1 && N <= 10)
            {
                int result = 0;
                for (int i = 0; i < N; i++)
                {

                    line = Console.ReadLine();
                    int x = int.Parse(line);
                    if (x >= 6 && x <= 18)
                    {
                        result = result + x;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
