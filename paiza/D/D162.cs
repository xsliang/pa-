using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D162
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N >= 1 && N <= 20)
            {
                Console.WriteLine(N*150);
            }
        }
    }
}
