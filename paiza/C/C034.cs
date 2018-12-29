
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C034
    {
        static void C034Main(string[] args)
        {
            var line = System.Console.ReadLine();

            string[] lines = line.Split(' ');

            string temp = "1234567890x";

            string a = lines[0];
            if (temp.Contains(a)==false)
            {
                return;
            }

            string op= lines[1];
            if ("+-".Contains(op)==false)
            {
                return;
            }

            string b = lines[2];
            if (temp.Contains(b) == false)
            {
                return;
            }

            string c = lines[4];
            if (temp.Contains(c) == false)
            {
                return;
            }

            int result = 0;

            if (op=="+")
            {
                if (a=="x")
                {
                    result = Convert.ToInt32(c) - Convert.ToInt32(b);
                }
                else if (b=="x")
                {
                    result = Convert.ToInt32(c) - Convert.ToInt32(a);
                }
                else
                {
                    result = Convert.ToInt32(a) + Convert.ToInt32(b);
                }
            }
            else
            {
                if (a == "x")
                {
                    result = Convert.ToInt32(c) + Convert.ToInt32(b);
                }
                else if (b == "x")
                {
                    result = Convert.ToInt32(a) - Convert.ToInt32(c);
                }
                else
                {
                    result = Convert.ToInt32(a) - Convert.ToInt32(b);
                }
            }

            Console.WriteLine(result);
        }
    }
}
