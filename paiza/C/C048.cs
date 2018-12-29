using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C048
    {
        static void C048Main(string[] args)
        {
            var line = System.Console.ReadLine();
            int S = Convert.ToInt32(line.Split(' ')[0]);
            int a = Convert.ToInt32(line.Split(' ')[1]);
            int b = Convert.ToInt32(line.Split(' ')[2]);

            if (S < 1 || S > 1000000 || a < 1 || a > 1000000 || b < 1 || b > 1000000)
            {
                return;
            }

            bool isA = true;
            string get = string.Empty;

            int temp = S;
            do
            {
                if (isA == true)
                {
                    if (a + 10 < S)
                    {
                        isA = false;
                        continue;
                    }

                    if (a >= temp + 10)
                    {
                        temp = temp + 10;
                        isA = false;
                        get = "A";
                    }
                    else
                    {
                        get = "B";
                        break;
                    }


                }
                else
                {
                    if (b >= temp + 1000)
                    {
                        temp = temp + 1000;
                        isA = true;
                        get = "B";
                    }
                    else
                    {
                        get = "A";
                        break;
                    }


                }
            } while (a >= temp && b >= temp);

            Console.WriteLine(get + " " + temp);
        }
    }
}
