using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D109
    {
        public static void D109Main()
        {
            try
            {
                bool result = true;

                var line = System.Console.ReadLine();
                if (line.ToString().Split(' ').Length == 2)
                {
                    int m = Convert.ToInt32(line.ToString().Split(' ')[0]);
                    int d = Convert.ToInt32(line.ToString().Split(' ')[1]);
                    if (m >= 1 && m <= 12 && d >= 1 && d <= 31)
                    {
                        string temp = m.ToString() + d.ToString();

                        string temp2 = temp[0].ToString();
                        for (int i = 1; i < temp.Length; i++)
                        {
                            if (temp2 != temp[i].ToString())
                            {
                                result = false;
                                break;
                            }
                        }

                        if (result==true)
                        {
                            System.Console.WriteLine("Yes");
                        }
                        else
                        {
                            System.Console.WriteLine("No");
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
