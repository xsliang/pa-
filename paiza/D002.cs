// D002:数の比較

// ある正の整数aとbがスペース区切りで入力されます。

// aとbを比較し大きい方の値を出力して下さい。aとbが同じ場合は「eq」と出力して下さい。

using System;
public class D002
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var line = System.Console.ReadLine();
            if (line.ToString().Split(' ').Length == 2)
            {
                int a = Convert.ToInt32(line.ToString().Split(' ')[0]);
                int b = Convert.ToInt32(line.ToString().Split(' ')[1]);
                if (a >= 0 && a <= 1000 && b >= 0 && b <= 1000)
                {
                    if (a > b)
                    {
                        System.Console.WriteLine(a.ToString());
                    }
                    else if (a < b)
                    {
                        System.Console.WriteLine(b.ToString());
                    }
                    else
                    {
                        System.Console.WriteLine("eq");
                    }
                }
            }
        }
        catch
        {

        }
    }
}


