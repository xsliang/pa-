using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D079
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                if (line.Length >= 2 && line.Length <= 100)
                {
                    string one = line[0].ToString();

                    bool result = true;

                    foreach (char item in line)
                    {
                        if (item.ToString() != one)
                        {
                            result = false;
                            break;
                        }
                    }

                    if (result == true)
                    {
                        System.Console.WriteLine("NG");
                    }
                    else
                    {
                        System.Console.WriteLine("OK");
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
