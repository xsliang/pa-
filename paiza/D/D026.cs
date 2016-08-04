// D026:一週間の予定

//あなたは1週間を全て休みにするために有給を申請することにしました。もともと決まっている休みもあります。

//改行区切りで7日間のもともと決まった休みが、休みならば「yes」、休みでなければ「no」と入力されます。
//有給申請しなくては行けない日数を出力してください。

//例えば以下のような入力の場合

//    yes
//    yes
//    yes
//    yes
//    no
//    no
//    yes

//以下のように出力して下さい

//    2

public class D026
{
    public static void Main()
    {
        int count = 0;
        for (int i = 0; i < 7; i++)
        {
            var line = System.Console.ReadLine();
            if (line == "yes" || line == "no")
            {
                if (line == "no")
                {
                    count++;
                }
            }
            else
            {
                return;
            }
        }
        System.Console.WriteLine(count);
    }
}
