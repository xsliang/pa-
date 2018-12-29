using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D094
    {
        public static void D094Main()
        {
            try
            {
                int catNo = 0;
                int dogNo = 0;
                for (int i = 0; i < 3; i++)
                {
                    var line = System.Console.ReadLine();
                    if (line == "cat")
                    {
                        catNo++;
                    }
                    else
                    {
                        dogNo++;
                    }
                }

                if (catNo > dogNo)
                {
                    System.Console.WriteLine("cat");
                }
                else
                {
                    System.Console.WriteLine("dog");
                }


            }
            catch
            {
            }


        }
    }
}
