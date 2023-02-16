using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D132
    {
        public static void D132Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            var S = Console.ReadLine();

            if (N >= 1 && N <= 100 && S.Length>=1 && S.Length<=10)
            {

                string result = S;
                for (int i = 0; i < N; i++)
                {
                    result = result +S;
                }
                Console.WriteLine(result);

            }
        }
    }
}
