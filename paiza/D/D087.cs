
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D087
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();
            int count = Convert.ToInt32(line);
            if (count < 1 || count > 10)
            {
                return;
            }
            string[] result =new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = System.Console.ReadLine();
            }

            System.Console.WriteLine(String.Join("", result));
        }
    }
}
