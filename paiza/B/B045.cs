//小学校低学年向けの足し算と引き算の計算ドリルをつくりましょう。計算ドリルとして問題に重複があると計算力の訓練にならないため、足し算、引き算それぞれで重複が無いようにつくらなければなりません。必要な足し算と引き算の問題の数が与えられるので、それに従ってドリルを作成してください。

//なお、その際問題に出てくる数値および解答はすべて 0 ~ 99 の整数になるようにします。
//足し算も順番を変えたものは異なる問題とします(a ≠ b のとき "a + b =" と "b + a =" は異なる問題)。

//例)
//足し算 5 つ、引き算 3 つのドリルを作成(入力例 1 に対応)

//計算ドリルの例:

//    25 + 5 =
//    89 + 10 =
//    45 - 16 =
//    3 + 46 =
//    82 + 3 =
//    0 + 84 =
//    70 - 6 =
//    27 - 26 =


//条件を満たせばどのような問題の並びでもかまいません。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B045
    {
        public static void Main()
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
