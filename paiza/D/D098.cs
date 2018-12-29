using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public static void D098Main()
    {
        try
        {
            var line = System.Console.ReadLine();
            int a = Convert.ToInt32(line.Split(' ')[0]);
            int b = Convert.ToInt32(line.Split(' ')[1]);
            if (a >= 200000 && a <= 1000000 && b >= 1 && b <= 6)
            {
                System.Console.WriteLine(a * b);

            }


        }
        catch
        {
        }


    }
}
