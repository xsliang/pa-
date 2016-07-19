// D003:掛け算のリスト
// ある正の整数nが入力されます。
// 正の整数1から9に整数nをそれぞれを掛けた数を半角スペース区切りで出力して下さい。

// 例えばn=2の場合

//    2 4 6 8 10 12 14 16 18 

// となります 


using System;
public class D003
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
            {
                int[] number = new int[9];
                int n = Convert.ToInt32(line);
                for (int i = 1; i <= 9; i++)
                {
                    number[i - 1] = n * i;
                }
                System.Console.WriteLine(String.Join(" ", number));
            }
        }
        catch
        {

        }

    }
}

