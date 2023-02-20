using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C097
    {
        public static void C097Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line.Split(' ')[0]);
            int X = int.Parse(line.Split(' ')[1]);
            int Y = int.Parse(line.Split(' ')[2]);
            if (N >= 1 && N <= 1000 && X >= 1 && X <= N && Y >= 1 && Y <= N)
            {
                for (int i = 1; i <= N; i++)
                {
                    string result = "";
                    if (i % X == 0)
                    {
                        result = "A";
                    }
                    if (i % Y == 0)
                    {
                        result = result + "B";
                    }
                    else if (i % X != 0 && i % Y != 0)
                    {
                        result = "N";
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
