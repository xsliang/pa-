using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B004
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                string[] add = line.Split('.');
                string add1 = add[0];
                string add2 = add[1];
                string add3 = add[2];
                string add4 = add[3];

                int add3_1 = 0;
                int add3_2 = 0;
                int add4_1 = 0;
                int add4_2 = 0;


                if (add3 == "*")
                {
                    add3_1 = 0;
                    add3_2 = 255;
                }
                else if (add3.Contains("-"))
                {
                    add3 = add3.Replace("[", "");
                    add3 = add3.Replace("]", "");
                    add3_1 = Convert.ToInt32(add3.Split('-')[0]);
                    add3_2 = Convert.ToInt32(add3.Split('-')[1]);
                    if (add3_1 > add3_2 || add3_1 < 0 || add3_1 > 255 || add3_2 < 0 || add3_2 > 255)
                    {
                        return;
                    }
                }
                else
                {
                    add3_1 = Convert.ToInt32(add3);
                    add3_2 = Convert.ToInt32(add3);
                }


                if (add4 == "*")
                {
                    add4_1 = 0;
                    add4_2 = 255;
                }
                else if (add4.Contains("-"))
                {
                    add4 = add4.Replace("[", "");
                    add4 = add4.Replace("]", "");
                    add4_1 = Convert.ToInt32(add4.Split('-')[0]);
                    add4_2 = Convert.ToInt32(add4.Split('-')[1]);
                    if (add4_1 > add4_2 || add4_1 < 0 || add4_1 > 255 || add4_2 < 0 || add4_2 > 255)
                    {
                        return;
                    }
                }
                else
                {
                    add4_1 = Convert.ToInt32(add4);
                    add4_2 = Convert.ToInt32(add4);
                }

                var line2 = System.Console.ReadLine();
                int N = Convert.ToInt32(line2);
                if (N < 1 || N > 1000)
                {
                    return;
                }

                List<string> resultLst = new List<string>();

                for (int i = 0; i < N; i++)
                {
                    string result = string.Empty;
                    var line3 = System.Console.ReadLine();
                    if (line3.Length <= 500)
                    {
                        string[] resultAry = line3.Split(' ');
                        string addressResult = resultAry[0];
                        string[] addressResultAry = addressResult.Split('.');
                        if (addressResultAry[0] == add1 &&
                            addressResultAry[1] == add2 &&
                            Convert.ToInt32(addressResultAry[2]) >= add3_1 && Convert.ToInt32(addressResultAry[2]) <= add3_2 &&
                            Convert.ToInt32(addressResultAry[3]) >= add4_1 && Convert.ToInt32(addressResultAry[3]) <= add4_2)
                        {
                            result = resultAry[0] + " ";
                            result = result + (resultAry[3].Replace("[", "")) + " ";
                            result = result + resultAry[6];
                            resultLst.Add(result);
                        }
                    }
                }

                foreach (var item in resultLst)
                {
                    System.Console.WriteLine(item);
                }
            }
            catch
            {
            }

        }
    }
}
