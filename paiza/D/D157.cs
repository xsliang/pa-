using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D157
    {
        public static void D157Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);

            if (N >= 1 && N <= 15)
            {

                int result = 2;
                for (int i = 0; i < N - 1; i++)
                {
                    result = result * 2;
                }
                Console.WriteLine(result);

            }
        }
    }
}
