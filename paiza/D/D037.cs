// D037:花粉症でつらい

//あなたは花粉症でティッシュを毎日使っては買いに行くのを繰り返していましたが、必要なティッシュ箱の数を計算し一気に注文しようと考えました。

//ティッシュ1箱が空になるまでの期間を M 日、残りの花粉症の季節を N 日が改行区切りで入力されるので、花粉症の季節が終わるまでに必要なティッシュ箱の数を求めて下さい。

//例えば、ティッシュ1箱が空になるまでの期間を 7 日、残りの花粉症の季節を 30 日とした時

//    7
//    30

//と入力され、30 / 7 = 4 あまり 2 となり

//4 箱と余った 2 日分で 1 箱、合計 5 箱必要になるので

//    5


//と出力してください。

using System;
public class D037
{
    public static void Main()
    {
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        try
        {
            int M = Convert.ToInt32(line1);
            int N = Convert.ToInt32(line2);
            if (1 <= M && M <= 100 && 1 <= N && N <= 100)
            {
                double result = Convert.ToDouble(N) / Convert.ToDouble(M);
                double realResult = Math.Ceiling(result);

                System.Console.WriteLine(realResult);
            }
        }
        catch
        {

        }
    }
}
