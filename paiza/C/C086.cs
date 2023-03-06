using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C086
    {
        public static void C086Main()
        {
            var line = Console.ReadLine();
            if (line.Length>=5 && line.Length<=30)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var item in line)
                {
                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                        item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
                    {
                        continue;
                    }
                    else {
                        sb.Append(item);
                    }
                }

                Console.WriteLine(sb.ToString());
            }
            
        }
    }
}
