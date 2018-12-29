

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D089
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();

            string temp = string.Empty;

            foreach (char item in line)
            {
                if ("1234567890".Contains(item))
                {
                    temp = temp + item.ToString();
                }
            }

            int tempInt = Convert.ToInt32(temp);

            if (tempInt >= 0 && tempInt <= 100)
            {
                System.Console.WriteLine(temp);
            }


        }
    }
}
