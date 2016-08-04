// D017:最大と最小

//5個の数字 n_1, n_2, n_3, n_4, n_5 が改行区切りで与えられます。

//それらの数字の最大の数字、最小の数字を改行区切りで出力してください。

//例えば

//    9
//    12
//    3
//    6
//    10

//と入力された場合

//    12
//    3

//と出力して下さい。

using System.Collections.Generic;
using System;
public class D017
{
    public static void Main()
    {
        List<int> input = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            var line = System.Console.ReadLine();
            if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 99)
            {
                input.Add(Convert.ToInt32(line));
            }
            else
            {
                return;
            }

        }
        input.Sort();
        System.Console.WriteLine(input[input.Count - 1]);
        System.Console.WriteLine(input[0]);
    }
}
