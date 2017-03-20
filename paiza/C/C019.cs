//N を 2 以上の整数とし、N の約数のうち N 自身を除いたものの和を S とします。 このとき

//・N = S となるような N を完全数
//・|N-S| = 1 となるような N をほぼ完全数

//と言うことにしましょう。ここで、|N-S| は N-S の絶対値を意味します。

//たとえば、N = 28 のとき、28 の約数は 1, 2, 4, 7, 14, 28 なので、S = 1+2+4+7+14 = 28 となります。従って、28 は完全数です。
//また、N = 16 のときには S = 1 + 2 + 4 + 8 = 15 となるので、16 はほぼ完全数です。

//入力された整数が完全数かほぼ完全数かそのいずれでもないかを判定するプログラムを作成してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    using System;
    using System.Collections.Generic;
    public class C019
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            try
            {
                var line = System.Console.ReadLine();
                int q = Convert.ToInt32(line);
                if (1 <= q && q <= 50)
                {
                    List<string> result = new List<string>();
                    for (int i = 0; i < q; i++)
                    {
                        var line2 = System.Console.ReadLine();
                        int n = Convert.ToInt32(line2);
                        if (n >= 2 && n <= 1000)
                        {
                            //List<int> lst1=new List<int>();
                            int addresult = 0;
                            for (int j = 1; j < n; j++)
                            {
                                if (n % j == 0)
                                {
                                    addresult = addresult + j;
                                }
                            }
                            if (addresult == n)
                            {
                                result.Add("perfect");
                            }
                            else if (Math.Abs(n - addresult) == 1)
                            {
                                result.Add("nearly");
                            }
                            else
                            {
                                result.Add("neither");
                            }
                        }
                        else
                        {
                            break;
                        }


                    }

                    foreach (string item in result)
                    {
                        System.Console.WriteLine(item);
                    }
                }
            }
            catch
            {

            }

        }
    }

}
