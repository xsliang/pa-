using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public static void D099Main()
    {
        try
        {
            var line = System.Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 20)
            {
                foreach (var item in line)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        catch
        {
        }


    }
}
