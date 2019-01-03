using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C039
    {
        static void C039Main(string[] args)
        {
            var line = System.Console.ReadLine();
            if (line.Length < 3 || line.Length > 100)
            {
                return;
            }

            int Nten = 0;
            int Nnum = 0;
            int sum = 0;

            foreach (char item in line)
            {
                if (item == '<')
                {
                    Nten++;
                }
                else if (item == '/')
                {
                    Nnum++;
                }
                else if (item == '+')
                {
                    sum = sum + (Nten * 10 + Nnum);
                    Nten = 0;
                    Nnum = 0;
                }
                else
                {
                    return;
                }
            }

            sum = sum + (Nten * 10 + Nnum);

            Console.WriteLine(sum);
        }
    }
}
