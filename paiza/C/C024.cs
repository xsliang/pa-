
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C024
    {
        public static void C024Main()
        {
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                if (n >= 1 && n <= 10)
                {
                    int i1 = 0;
                    int i2 = 0;
                    for (int i = 0; i < n; i++)
                    {
                        var line2 = System.Console.ReadLine();
                        string[] proc = line2.Split(' ');
                        if (proc[0].ToUpper() == "SET")
                        {
                            int a = Convert.ToInt32(proc[2]);
                            if (a >= -1000 && a <= 1000)
                            {
                                if (proc[1] == "1")
                                {
                                    i1 = a;
                                }
                                else if (proc[1] == "2")
                                {
                                    i2 = a;
                                }
                            }
                        }
                        else if (proc[0].ToUpper() == "ADD")
                        {
                            int a = Convert.ToInt32(proc[1]);
                            if (a >= -1000 && a <= 1000)
                            {
                                i2 = i1 + a;
                            }
                        }
                        else if (proc[0].ToUpper() == "SUB")
                        {
                            int a = Convert.ToInt32(proc[1]);
                            if (a >= -1000 && a <= 1000)
                            {
                                i2 = i1 - a;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    System.Console.WriteLine(i1 + " " + i2);
                }
            }
            catch
            {
            }

        }
    }
}
