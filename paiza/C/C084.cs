using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C084
    {
        public static void C084Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 100)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < line.Length + 2; i++)
                {
                    sb.Append("+");
                }
                Console.WriteLine(sb.ToString());
                Console.WriteLine("+" + line + "+");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
