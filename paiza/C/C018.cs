// C018:何人前作れる？

//魅力的な料理のレシピを手に入れたあなたは、早速調理を始めたいと思っています。
//レシピには、1人前を調理するのに必要な食材とその量が載っています。

//このレシピと、あなたが所持している食材とその量が与えられるので、最大で何人前作れるかを求めてください。



//入力される値
//    入力は以下のフォーマットで与えられます。

//        n　　　　　#レシピに書かれている食材の数を表す整数 n
//        a_1 b_1　　#レシピに書かれている食材の名前 a_1, 数 b_1
//        a_2 b_2　　#レシピに書かれている食材の名前 a_2, 数 b_2
//        ...
//        a_n b_n　　#レシピに書かれている食材の名前 a_n, 数 b_n
//        m　　　　　#あなたが所持している食材の数を表す整数 m
//        c_1 d_1　　#所持している食材の名前 c_1, 数 d_1
//        c_2 d_2　　#所持している食材の名前 c_2, 数 d_2
//        ...
//        c_m d_m　　#所持している食材の名前 c_m, 数 d_m

//    ここで、n はレシピに書かれている食材の数を表す整数
//    文字列 a_i と整数 b_i(1 ≦ i ≦ n) は、1人前あたりの食材 a_i が b_i だけ必要であることを表します。

//    同様に、m はあなたが所持している食材の数を表す整数
//    文字列 c_i と整数 d_i(1 ≦i ≦ m) は、食材 c_i を d_i だけ所持していることを表します。

//    それぞれの値は文字列で標準入力から渡されます。標準入力からの値取得方法はこちらをご確認ください

//期待する出力
//    何人前作ることができるかを数字で一行に出力してください。

//    最後は改行し、余計な文字、空行を含んではいけません。

//条件
//    すべてのテストケースで以下の条件を満たします。

//    ・1 ≦ n ≦ 100
//    ・0 ≦ m ≦ 100
//    ・1 ≦ a_i の長さ, c_i の長さ ≦ 10
//    ・1 ≦ b_i ≦ 100
//    ・1 ≦ d_i ≦ 10,000
//    ・i ≠ j のとき a_i ≠ a_j
//    ・i ≠ j のとき c_i ≠ c_j

using System;
using System.Collections.Generic;
public class C018
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var line = System.Console.ReadLine();
            if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
            {
                int n = Convert.ToInt32(line);
                Dictionary<string, int> listA = new Dictionary<string, int>();
                for (int i = 0; i < n; i++)
                {
                    line = System.Console.ReadLine();
                    if (line.Split(' ').Length != 2)
                    {
                        return;
                    }
                    else
                    {
                        string a = line.Split(' ')[0];
                        int b = Convert.ToInt32(line.Split(' ')[1]);
                        if (a.Length < 1 && a.Length > 10)
                        {
                            return;
                        }
                        if (b < 1 && b > 100)
                        {
                            return;
                        }
                        listA.Add(a, b);
                    }
                }
                Dictionary<string, int> listB = new Dictionary<string, int>();
                line = System.Console.ReadLine();
                if (Convert.ToInt32(line) >= 0 && Convert.ToInt32(line) <= 100)
                {
                    int m = Convert.ToInt32(line);
                    for (int i = 0; i < m; i++)
                    {
                        line = System.Console.ReadLine();
                        if (line.Split(' ').Length != 2)
                        {
                            return;
                        }
                        else
                        {
                            string a = line.Split(' ')[0];
                            int b = Convert.ToInt32(line.Split(' ')[1]);
                            if (a.Length < 1 && a.Length > 10)
                            {
                                return;
                            }
                            if (b < 1 && b > 10000)
                            {
                                return;
                            }
                            listB.Add(a, b);
                        }
                    }
                }
                List<int> listC = new List<int>();
                foreach (var item in listA)
                {
                    if (listB.ContainsKey(item.Key) == false)
                    {
                        System.Console.WriteLine(0);
                        return;
                    }
                    else
                    {
                        int valueA = item.Value;
                        int valueB = listB[item.Key];
                        listC.Add(valueB / valueA);
                    }
                }
                if (listB.Count > 0)
                {
                    listC.Sort();
                    System.Console.WriteLine(listC[0]);
                }
                else
                {
                    System.Console.WriteLine(0);
                }
            }
        }
        catch
        {

        }
    }
}

