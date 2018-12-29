

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D084
    {
        public static void D084Main()
        {
            string[] month = new string[] {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var line = System.Console.ReadLine();
            int count = Convert.ToInt32(line);
            if (count < 1 || count > 12)
            {
                return;
            }

            System.Console.WriteLine(month[count - 1]);
        }
    }
}
