using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D174
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            int k = int.Parse(line);
            if (k>=1 & k<=100)
            {
                Console.WriteLine(k*1500);
            }
        }
    }
}
