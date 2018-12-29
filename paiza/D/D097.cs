using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D097
    {
        public static void D097Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                string[] input = line.Split(' ');
                if (input.Length == 7)
                {
                    int count = 0;
                    foreach (var item in input)
                    {
                        if (item == "1")
                        {
                            count++;
                        }
                    }

                    if (count >= 5)
                    {
                        System.Console.WriteLine("yes");
                    }
                    else
                    {
                        System.Console.WriteLine("no");
                    }
                }


            }
            catch
            {
            }


        }
    }
}
