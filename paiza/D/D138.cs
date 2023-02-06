using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D138
    {
        static void D119Main()
        {
            string line = Console.ReadLine();
            string[] wh = line.Split(' ');
            int w = int.Parse(wh[0]);
            int h = int.Parse(wh[1]);
            List<string> result = new List<string>();
            if (w >= 1 && w <= 20 && h >= 1 && h <= 20)
            {
                for (int i = 1; i <= h; i++)
                {
                    string input = Console.ReadLine();
                    result.Add(input);
                }

                for (int i = 0; i < h; i++)
                {
                    Console.WriteLine(result[i]);
                }

            }
            
        }
    }
}
