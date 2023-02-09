using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D200
    {
        public static void D200Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            if (n>=1 && n<=10)
            {
                Console.WriteLine(n*25*24);
            }
        }
    }
}
