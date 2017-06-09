//あなたは世界展開を目指す SNS "paizabook" を開発しているエンジニアです。
//paizabook では友達が投稿した日記などを見ることが出来ますが、ユーザの住んでいる場所によって表示される投稿時刻を修正する必要があります。

//例えば、ロンドンに住んでいるユーザが現地時刻 8:30 に投稿した日記の時刻は、日本に住んでいるユーザの画面では 17:30 と表示されなければなりません。
//これは、日本の時刻がロンドンの時刻よりもちょうど 9 時間進んでいるためです。なお、時間は 00:00 から 23:59 までの 24 時間制で表すものとします。

//N 個の都市の時差を表す情報と、その中のある都市に住むユーザの日記の投稿時刻(現地時間) が入力されるので
//それぞれの都市に住むユーザの画面に表示される投稿時刻を出力するプログラムを作成して下さい。

//・1 ≦ N ≦ 100
//・各 i(1 ≦ i ≦ N) について
//　・p_i は英字小文字で構成される文字列
//　・1 ≦ (p_i の長さ) ≦ 20
//　・-12 ≦ s_i ≦ 14
//・各 i, j (1 ≦ i, j ≦ N) について、i ≠ j のとき p_i ≠ p_j
//・q は p_1, p_2, …, p_N のいずれか 1 つに一致する文字列
//・t は 24 時間制で実際に存在する時刻を表す

using System;
using System.Collections.Generic;

namespace paiza.C
{
    class C031
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 1 || N > 100)
                {
                    return;
                }
                Dictionary<string, int> data = new Dictionary<string, int>();
                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    string p = line.Split(' ')[0];
                    int s = Convert.ToInt32(line.Split(' ')[1]);
                    if (p.Length < 1 || p.Length > 20 || -12 > s || s > 14)
                    {
                        return;
                    }
                    data.Add(p, s);
                }
                line = System.Console.ReadLine();
                string q = line.Split(' ')[0];
                string t = line.Split(' ')[1];
                int sa = data[q];

                foreach (var item in data)
                {

                    int hour = Convert.ToInt32(t.Split(':')[0]) + (item.Value - sa);
                    if (hour < 0)
                    {
                        hour = 24 + hour;
                    }
                    if (hour >= 24)
                    {
                        hour = hour - 24;
                    }

                    System.Console.WriteLine(hour.ToString("0#") + ":" + t.Split(':')[1]);
                }
            }
            catch
            {
            }

        }
    }
}
