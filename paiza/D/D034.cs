// D034:どれにしようかな

//あなたはレストランで何を注文しようか迷っています。しかしあまり時間がないので「どれにしようかな天の神様の言うとおり」で决めてしまいましょう。

//選ばれるメニューはこの文字数 21 を迷っているメニューの数で割れば求められます。ただし余りが 0 となるときはそのメニューの中で最後のものが選ばれることに注意しましょう。

//例)
//4 つの中で迷っている場合
//21 ÷ 4 = 5 余り 1 なので 1 番目のメニューが選ばれます。

//3 つの中で迷っている場合
//21 ÷ 3 = 7 余り 0 ですが、これは一番最後にくるものを指すので、 3 番目のメニューが選ばれます。

using System;
public class D034
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var line = System.Console.ReadLine();
            if (Convert.ToInt32(line) >= 2 && Convert.ToInt32(line) <= 21)
            {
                int n = Convert.ToInt32(line);
                if (21 % n == 0)
                {
                    System.Console.WriteLine(n);
                }
                else
                {
                    System.Console.WriteLine(21 % n);
                }
            }
        }
        catch
        { }
    }
}
