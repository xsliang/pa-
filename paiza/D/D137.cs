using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D137
    {
        public static void D137Main()
        {
            var line = Console.ReadLine();
            if (line.Length ==10)
            {
                int result = 0;
                foreach (var item in line)
                {
                    if (item=='y')
                    {
                        result++;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
