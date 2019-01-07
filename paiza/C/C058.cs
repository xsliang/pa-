using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C058
    {
        public static void C058Main()
        {
            var line = System.Console.ReadLine();
            if (line.Split(' ').Length == 3)
            {
                int n = Convert.ToInt32(line.Split(' ')[0]);
                string t = line.Split(' ')[1];
                string s = line.Split(' ')[2];

                if (t.Length != s.Length || t.Length != n || s.Length != n)
                {
                    return;
                }

                int count = 0;

                while (t != s)
                {
                    s = s.Substring(1, s.Length - 1) + s.Substring(0, 1);
                    count++;
                }

                System.Console.WriteLine(count);
            }
        }
    }
}
