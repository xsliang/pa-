using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B029
    {
        static void B029Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int x = Convert.ToInt32(line.Split(' ')[0]);
                int y = Convert.ToInt32(line.Split(' ')[1]);
                if (x < 0 || y < 0 || x > 1000 || y > 1000)
                {
                    return;
                }

                line = System.Console.ReadLine();
                int k = Convert.ToInt32(line);
                line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 2 || N > 100)
                {
                    return;
                }
                if (k < 1 || k > N)
                {
                    return;
                }

                List<data> input = new List<data>();

                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    int xtemp = Convert.ToInt32(line.Split(' ')[0]);
                    int ytemp = Convert.ToInt32(line.Split(' ')[1]);
                    int ktemp = Convert.ToInt32(line.Split(' ')[2]);

                    if (xtemp < 0 || ytemp < 0 || xtemp > 1000 || ytemp > 1000 || ktemp < 1 || ktemp > 100)
                    {
                        return;
                    }
                    else
                    {
                        input.Add(new B.data
                        {
                            distance = Math.Sqrt(Convert.ToDouble((x - xtemp) * (x - xtemp) + (y - ytemp) * (y - ytemp))),
                            price = ktemp
                        });
                    }
                }

                input = input.OrderBy(o => o.distance).ToList();

                decimal sum = 0;

                for (int i = 0; i < k; i++)
                {
                    sum = input[i].price + sum;
                }

                Console.WriteLine(Math.Round(sum / k));
            }
            catch
            {
            }
        }
    }

    public class data
    {
        public double distance { get; set; }

        public decimal price { get; set; }
    }
}
