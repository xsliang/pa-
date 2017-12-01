using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D074
    {
        public static void Main()
        {
            try
            {

                var line = System.Console.ReadLine();

                int intLine = Convert.ToInt32(line);

                if (intLine >= 0 && intLine <= 47)
                {
                    if (intLine >= 24)
                    {
                        intLine = intLine - 24;
                    }

                    System.Console.WriteLine(intLine);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
