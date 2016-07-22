// D009:西暦の計算

//2つの西暦 a, b が半角スペース区切りの整数で入力されます。

//a から b が何年間あるか出力してください。

//例えば

//    1990 2014

//と入力された場合

//    24

//と出力してください。 

using System;
public class D009
{
    public static void Main()
    {
        try
        {
            var a = System.Console.ReadLine();
            string[] number = a.Split(' ');
            if (Convert.ToInt32(number[0]) >= 1 && Convert.ToInt32(number[0]) <= 2014 &&
            Convert.ToInt32(number[1]) >= 1 && Convert.ToInt32(number[1]) <= 2014)
            {
                int Na = Convert.ToInt32(number[0]);
                int Nb = Convert.ToInt32(number[1]);
                if (Na < Nb)
                {
                    System.Console.WriteLine(Convert.ToString(Nb - Na));
                }
            }

        }
        catch { }
    }
}
