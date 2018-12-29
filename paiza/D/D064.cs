
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D064
    {
        public static void D064Main()
        {
            
            
            var line = System.Console.ReadLine();
            try
            {
                if (line.Length >= 1 && line.Length <= 100)
                {
                    string result = line.Replace("False", "True");
                    System.Console.WriteLine(result);
                }
            }
            catch
            {

            }

        }
    }

}
