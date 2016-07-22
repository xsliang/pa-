// D005:等差数列

//以下のような数列を出力するプログラムを作りましょう。

//    5 8 11 14 17 20 23 26 29 32 

//最初の数字が5で、3ずつ増加していく事がわかります。
//一般的にこれを初項5、公差3の等差数列といいます。

//このような数列を出力するプログラムを作りましょう。
//初項 m が与えられ、公差 n が与えられるので 10番目までの数字をスペース区切りで出力するプログラムを作成してください。

using System;
public class D005
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        string[] aryLine = line.Split(' ');
        if (Convert.ToInt32(aryLine[0]) >= 1 && Convert.ToInt32(aryLine[0]) <= 100 &&
        Convert.ToInt32(aryLine[1]) >= 1 && Convert.ToInt32(aryLine[1]) <= 100)
        {
            int m = Convert.ToInt32(aryLine[0]);
            int n = Convert.ToInt32(aryLine[1]);
            int[] aryResult = new int[10];
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    result = m;
                }
                else
                {
                    result = result + n;
                }
                aryResult[i] = result;
            }
            System.Console.WriteLine(string.Join(" ", aryResult));
        }
    }
}
