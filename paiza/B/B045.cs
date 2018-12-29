

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B045
    {
        public static void B045Main()
        {
            var line = System.Console.ReadLine();

            int M = Convert.ToInt32(line.Split(' ')[0]);
            int N = Convert.ToInt32(line.Split(' ')[1]);

            if (M < 0 || M > 5050 || N < 0 || N > 5050 || M + N < 1)
            {
                return;
            }

            Random a = new Random(DateTime.Now.Millisecond + 2);
            Random b = new Random(DateTime.Now.Millisecond + 3);

            //List<string> resultList = new List<string>();
            int all = M + N;
            string[] resultList = new string[all];
            string tempResult = string.Empty;

            for (int i = 0; i < all; i++)
            {
                int numA = a.Next(0, 100);
                int numB = b.Next(0, 100 - numA);
                if (numA > numB)
                {
                    //add
                    if (M > 0)
                    {
                        tempResult = numA + " + " + numB + " =";
                        if (resultList.Contains(tempResult) == false)
                        {
                            resultList[i] = tempResult;
                            M--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else
                    {
                        if (numA > numB)
                        {
                            tempResult = numA + " - " + numB + " =";
                        }
                        else
                        {
                            tempResult = numB + " - " + numA + " =";
                        }
                        if (resultList.Contains(tempResult) == false)
                        {
                            resultList[i] = tempResult;
                            N--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else
                {
                    //sub
                    if (N > 0)
                    {
                        if (numA > numB)
                        {
                            tempResult = numA + " - " + numB + " =";
                        }
                        else
                        {
                            tempResult = numB + " - " + numA + " =";
                        }
                        if (resultList.Contains(tempResult) == false)
                        {
                            resultList[i] = tempResult;
                            N--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else
                    {
                        tempResult = numA + " + " + numB + " =";
                        if (resultList.Contains(tempResult) == false)
                        {
                            resultList[i] = tempResult;
                            M--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }

            foreach (var item in resultList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
