
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C033
    {
        static void C033Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 3 || N > 6)
            {
                return;
            }

            List<string> input = new List<string>();

            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                input.Add(line);
            }

            int countBall = 0;
            int countStrike = 0;

            foreach (var item in input)
            {
                if (item == "ball")
                {
                    countBall++;
                    if (countBall==4)
                    {
                        Console.WriteLine("fourball!");
                    }
                    else
                    {
                        Console.WriteLine("ball!");
                    }          
                }
                else if (item == "strike")
                {
                    countStrike++;
                    if (countStrike==3)
                    {
                        Console.WriteLine("out!");
                    }
                    else
                    {
                        Console.WriteLine("strike!");
                    }
                }
            }
        }
    }
}
