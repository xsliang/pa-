using System;

namespace paiza.B
{
    public class B006
    {
        public static void B006Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                string[] date1 = line.Split(' ');
                double o_y = Convert.ToDouble(date1[0]);
                double s = Convert.ToDouble(date1[1]);
                double seta = Convert.ToDouble(date1[2]);

                if (o_y < 0 || o_y > 100)
                {
                    return;
                }

                if (s < 1 || s > 100)
                {
                    return;
                }

                if (seta < 0 || seta > 90)
                {
                    return;
                }

                seta = Math.PI / 180 * seta;

                var line2 = System.Console.ReadLine();

                string[] date2 = line2.Split(' ');
                double x = Convert.ToDouble(date2[0]);
                double y = Convert.ToDouble(date2[1]);
                double a = Convert.ToDouble(date2[2]);

                if (x < 1 || x > 100)
                {
                    return;
                }

                if (y < 0 || y > 100)
                {
                    return;
                }

                if (a < 1 || a > 100)
                {
                    return;
                }

                double g = 9.8d;

                double new_y = o_y + (x * Math.Tan(seta)) - (g * x * x / (2 * s * s * (Math.Cos(seta)) * (Math.Cos(seta))));

                double result = Math.Round(Math.Abs(y - new_y), 1, MidpointRounding.AwayFromZero);
                if (new_y < (y - a / 2) || new_y > (y + a / 2))
                {
                    System.Console.WriteLine("Miss");

                }
                else
                {
                    System.Console.WriteLine("Hit " + result);
                }
            }
            catch
            {

            }

        }
    }
}
