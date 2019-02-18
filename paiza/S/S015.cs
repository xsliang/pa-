using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace paiza.S
{
    class S015
    {
        static void S015Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int k = Convert.ToInt32(line.Split(' ')[0]);
                int s = Convert.ToInt32(line.Split(' ')[1]);
                int t = Convert.ToInt32(line.Split(' ')[2]);

                int currentIndex = 0;
                int currentLayer = 0;
                Dictionary<int, string> currentInfo = new Dictionary<int, string>();
                string currentCahr = string.Empty;

                currentLayer = k;

                if (k >= 1 && k <= 50 && s >= 1 && t >= 1 && s<=t && t - s + 1 >= 1 && t - s + 1 <= 100)
                {
                    NewMethod(ref currentIndex, currentLayer, currentInfo, ref currentCahr, k, s, t);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void NewMethod(ref int currentIndex, int currentLayer, Dictionary<int, string> currentInfo, ref string currentCahr, int k, int s, int t)
        {
            if (currentIndex > t)
            {
                return;
            }

            if (currentInfo.ContainsKey(currentLayer) == false)
            {
                currentIndex++;
                currentCahr = "A";
                if (t - s + 1 >= 1 && t - s + 1 <= 100 && currentIndex >= s && currentIndex <= t)
                {
                    Console.Write(currentCahr);
                }
                currentInfo.Add(currentLayer, "A");
                if (currentLayer > 1)
                {
                    NewMethod(ref currentIndex, currentLayer - 1, currentInfo, ref currentCahr, k, s, t);
                }
            }

            if (currentInfo.ContainsKey(currentLayer) == true && currentInfo[currentLayer] == "A")
            {
                currentIndex++;
                currentCahr = "B";
                if (t - s + 1 >= 1 && t - s + 1 <= 100 && currentIndex >= s && currentIndex <= t)
                {
                    Console.Write(currentCahr);
                }
                currentInfo[currentLayer] = "B";
                if (currentLayer > 1)
                {
                    NewMethod(ref currentIndex, currentLayer - 1, currentInfo, ref currentCahr, k, s, t);
                }
            }

            if (currentInfo.ContainsKey(currentLayer) == true && currentInfo[currentLayer] == "B")
            {
                currentIndex++;
                currentCahr = "C";
                if (t - s + 1 >= 1 && t - s + 1 <= 100 && currentIndex >= s && currentIndex <= t)
                {
                    Console.Write(currentCahr);
                }
                currentInfo[currentLayer] = "C";
                if (currentLayer < k)
                {
                    currentInfo.Remove(currentLayer);
                    currentLayer++;
                }

                return;
            }
        }
    }
}
