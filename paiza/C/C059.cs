using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C059
    {
        public static void C059Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            if (N >= 2 && N <= 50)
            {
                List<string> inputs = new List<string>();



                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();

                    if (line.Length != 4)
                    {
                        return;
                    }

                    for (int j = 0; j < 4; j++)
                    {
                        var item= line[j].ToString();

                        if (item != "0" && item != "1")
                        {
                            return;
                        }
                        else
                        {
                            if (item == "1")
                            {
                                switch (j)
                                {
                                    case 0:
                                        count1++;
                                        break;
                                    case 1:
                                        count2++;
                                        break;
                                    case 2:
                                        count3++;
                                        break;
                                    case 3:
                                        count4++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }

    
                }

                Console.WriteLine((count1 % 2).ToString() + (count2 % 2).ToString() + (count3 % 2).ToString() + (count4 % 2).ToString());



            }
        }
    }
}
