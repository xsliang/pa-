//ある半角小文字アルファベット "c", "a", "t" で構成される文字列 S が与えられます。
//文字列 Sに 含まれる "c", "a", "t" を1つずつ集め "cat" という文字列をあなたは作ろうとしています。

//"cat" と完全に作れる個数、余った "c", "a", "t" から "cat" を作るのに必要なそれぞれの個数を求め
//完全に作れる個数、必要な "c" の個数、必要な "a" の個数、必要な "t" の個数の順に改行区切りで出力して下さい。

//    1 ≦ 文字列 S の長さ ≦ 100

//S は半角小文字アルファベット "c", "a", "t" で構成された文字列

public class ando19
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            if (line.ToString().Length >= 1 && line.ToString().Length <= 100)
            {
                string input = line.ToString();
                int c = 0;
                int a = 0;
                int t = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i].ToString())
                    {
                        case "c":
                            c++;
                            break;
                        case "a":
                            a++;
                            break;
                        case "t":
                            t++;
                            break;
                        default:
                            return;
                    }
                }

                int countCat = 0;
                while (c > 0 && a > 0 && t > 0)
                {
                    countCat++;
                    c--;
                    a--;
                    t--;
                }

                //max
                int max = 0;
                if (c > a)
                {
                    max = c;
                }
                else
                {
                    max = a;
                }

                if (max < t)
                {
                    max = t;
                }

                System.Console.WriteLine(countCat.ToString());
                System.Console.WriteLine((max - c).ToString());
                System.Console.WriteLine((max - a).ToString());
                System.Console.WriteLine((max - t).ToString());
            }
        }
        catch
        {

        }
    }
}

