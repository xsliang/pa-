using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D075
    {
        public static void Main()
        {
            try
            {
                List<int> lst = new List<int>();

                for (int i = 0; i < 4; i++)
                {
                    var line1 = System.Console.ReadLine();

                    int intLine = Convert.ToInt32(line1);

                    if (intLine < 0 || intLine > 5)
                    {
                        return;
                    }

                    lst.Add(intLine);
                }

                if (lst.Contains(1) == false)
                {
                    System.Console.WriteLine(1);
                }
                if (lst.Contains(2) == false)
                {
                    System.Console.WriteLine(2);
                }
                if (lst.Contains(3) == false)
                {
                    System.Console.WriteLine(3);
                }
                if (lst.Contains(4) == false)
                {
                    System.Console.WriteLine(4);
                }
                if (lst.Contains(5) == false)
                {
                    System.Console.WriteLine(5);
                }


            }
            catch (Exception ex)
            {
            }
        }
    }
}
