// D008:奇数か偶数か

//正の整数 N が入力されるので、N が奇数ならば"odd" 偶数ならば"even" と出力するプログラムを作成して下さい。

using System;
public class D008
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            if (n % 2 == 0)
            {
                System.Console.WriteLine("even");
            }
            else
            {
                System.Console.WriteLine("odd");
            }
        }
    }
}
