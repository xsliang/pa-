using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C044
    {
        public static void C044Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 2 && N <= 10)
                {
                    int countPaper = 0;
                    int countRock = 0;
                    int countScissorsr = 0;


                    for (int i = 0; i < N; i++)
                    {
                        line = System.Console.ReadLine();

                        if (line == "paper")
                        {
                            countPaper++;
                        }
                        else if (line == "rock")
                        {
                            countRock++;
                        }
                        else if (line == "scissors")
                        {
                            countScissorsr++;
                        }
                    }

                    if (countPaper > 0 && countRock > 0 && countScissorsr > 0)
                    {
                        System.Console.WriteLine("draw");
                    }
                    else if (countPaper > 0 && countRock > 0)
                    {
                        System.Console.WriteLine("paper");
                    }
                    else if (countPaper > 0 && countScissorsr > 0)
                    {
                        System.Console.WriteLine("scissors");
                    }
                    else if (countRock > 0 && countScissorsr > 0)
                    {
                        System.Console.WriteLine("rock");
                    }
                }
            }
            catch
            {
            }

        }
    }
}
