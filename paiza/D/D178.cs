using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D178
    {
        public static void Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            if (n >= 1 && n <= 20) {
                var line2 = Console.ReadLine();
                    string result = "";
                for (int i = n-1; i >= 0; i--)
                {
                    result = result + line2[i];
                }
                Console.WriteLine(result);
            }
        }
    }
}
