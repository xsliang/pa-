using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D143
    {
        public static void D143Main() {
            string input = Console.ReadLine();
            string[] MVF = input.Split(' ');
            int m = int.Parse(MVF[0]);
            int v = int.Parse(MVF[1]);
            int f = int.Parse(MVF[2]);
            if (m>=1 && m<=1000 && v >= 1 && v <= 100 && f >= 1 && f <= 10000)
            {
               int result = (m*v*v) / (2 * f);
                Console.WriteLine(result);
            }
        }
    }
}
