

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D055
    {
        public static void D055Main()
        {
            
            
            var line = System.Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            try
            {
                string s1 = line.ToString().Split(' ')[0];
                string s2 = line.ToString().Split(' ')[1];
                if (s1.Length >= 1 && s1.Length <= 20 &&
                s2.Length >= 1 && s2.Length <= 20)
                {
                    foreach (var text in s1)
                    {
                        if (abc.Contains(text.ToString()) == false)
                        {
                            return;
                        }
                    }
                    foreach (var text in s2)
                    {
                        if (abc.Contains(text.ToString()) == false)
                        {
                            return;
                        }
                    }
                    System.Console.WriteLine("Best in " + s1 + " " + s2);
                }

            }
            catch
            {

            }

        }
    }

}
