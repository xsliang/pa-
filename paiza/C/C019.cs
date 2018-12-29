
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    using System;
    using System.Collections.Generic;
    public class C019
    {
        public static void C019Main()
        {
            
            

            try
            {
                var line = System.Console.ReadLine();
                int q = Convert.ToInt32(line);
                if (1 <= q && q <= 50)
                {
                    List<string> result = new List<string>();
                    for (int i = 0; i < q; i++)
                    {
                        var line2 = System.Console.ReadLine();
                        int n = Convert.ToInt32(line2);
                        if (n >= 2 && n <= 1000)
                        {
                            //List<int> lst1=new List<int>();
                            int addresult = 0;
                            for (int j = 1; j < n; j++)
                            {
                                if (n % j == 0)
                                {
                                    addresult = addresult + j;
                                }
                            }
                            if (addresult == n)
                            {
                                result.Add("perfect");
                            }
                            else if (Math.Abs(n - addresult) == 1)
                            {
                                result.Add("nearly");
                            }
                            else
                            {
                                result.Add("neither");
                            }
                        }
                        else
                        {
                            break;
                        }


                    }

                    foreach (string item in result)
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

}
