using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C052
    {
        public static void C052Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int H = Convert.ToInt32(line.Split(' ')[0]);
                int W = Convert.ToInt32(line.Split(' ')[1]);
                var line2 = System.Console.ReadLine();
                int dy = Convert.ToInt32(line2.Split(' ')[0]);
                int dx = Convert.ToInt32(line2.Split(' ')[1]);

                if (H >= 1 && H <= 10000 && W >= 1 && W <= 10000 && dy >= -H && dy <= H && dx >= -W && dx <= W)
                {
                    int result = (H * Math.Abs(dx)) + (W * Math.Abs(dy)) - (Math.Abs(dx * dy));

                    Console.WriteLine(result);
                }
            }
            catch
            {
            }
        }
    }
}
