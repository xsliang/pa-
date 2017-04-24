// あなたは管理しているサーバーのアクセスログから、特定のIPのアクセスを抽出しようとしています。
//IPアドレスを指定する書式の例は以下のようになっており、IPv4のみを対象としています。
//※ # 以降はコメントです。

//    192.168.0.1 #192.168.0.1のみを対象
//    192.168.0.[10-20] #192.168.0.10~192.168.0.20の範囲を対象
//    192.168.[1-2].[10-20] #192.168.1.10~192.168.1.20と192.168.2.10~192.168.2.20の範囲を対象
//    192.168.0.* #192.168.0.0~192.168.0.255の範囲を対象
//    192.168.*.* #192.168.0.0~192.168.255.255の範囲を対象
//    　#*は[0-255]と等価

//IPアドレスは「.」で区切られて左から第1.第2.第3.第4オクテットと呼ばれます。
//範囲指定ができるのは第3、第4オクテットまでとします。
//Apacheのログが以下のような書式であります。ログは上から古い順に記録されているとします。
//「IPアドレス identユーザー名 認証ユーザー名[アクセス日時] "リクエストヘッダ ファイル名 プロトコル" ステータスコード 転送されたバイト数 呼び出し元URL ブラウザ情報等」

//    IPアドレス
//    identユーザー名
//    認証ユーザー名
//    [アクセス日時]
//    "リクエストヘッダ ファイル名 プロトコル"
//    ステータスコード
//    転送されたバイト数
//    呼び出し元URL
//    ブラウザ情報等

//※半角スペース区切り

//    101.80.23.49 - - [08/Jul/2013:16:55:14 +0900] "GET /index.html HTTP/1.1" 200 12345 "http://google.com" "safari"
//    51.185.9.25 - - [08/Jul/2013:17:05:10 +0900] "GET / HTTP/1.1" 200 12345 "http://google.com" "chrome"
//    ……

//日付のフォーマットは[日付 / 月 / 西暦4桁:時:分:秒 タイムゾーン] で入力されます。
//各値は0詰めされてるとします。
//月の表記はそれぞれ1月から順に以下のように記録されています。

//    Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec
//    ……

//抽出対象のIPアドレスの指定、入力されるログの行数、ログの入力から対象のアクセスを抽出し、
//IPアドレス、タイムゾーンの指定を除外した日付、ファイル名をスペース区切りで
//出力するプログラムを作成してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B004
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                string[] add = line.Split('.');
                string add1 = add[0];
                string add2 = add[1];
                string add3 = add[2];
                string add4 = add[3];

                int add3_1 = 0;
                int add3_2 = 0;
                int add4_1 = 0;
                int add4_2 = 0;


                if (add3 == "*")
                {
                    add3_1 = 0;
                    add3_2 = 255;
                }
                else if (add3.Contains("-"))
                {
                    add3 = add3.Replace("[", "");
                    add3 = add3.Replace("]", "");
                    add3_1 = Convert.ToInt32(add3.Split('-')[0]);
                    add3_2 = Convert.ToInt32(add3.Split('-')[1]);
                    if (add3_1 > add3_2 || add3_1 < 0 || add3_1 > 255 || add3_2 < 0 || add3_2 > 255)
                    {
                        return;
                    }
                }
                else
                {
                    add3_1 = Convert.ToInt32(add3);
                    add3_2 = Convert.ToInt32(add3);
                }


                if (add4 == "*")
                {
                    add4_1 = 0;
                    add4_2 = 255;
                }
                else if (add4.Contains("-"))
                {
                    add4 = add4.Replace("[", "");
                    add4 = add4.Replace("]", "");
                    add4_1 = Convert.ToInt32(add4.Split('-')[0]);
                    add4_2 = Convert.ToInt32(add4.Split('-')[1]);
                    if (add4_1 > add4_2 || add4_1 < 0 || add4_1 > 255 || add4_2 < 0 || add4_2 > 255)
                    {
                        return;
                    }
                }
                else
                {
                    add4_1 = Convert.ToInt32(add4);
                    add4_2 = Convert.ToInt32(add4);
                }

                var line2 = System.Console.ReadLine();
                int N = Convert.ToInt32(line2);
                if (N < 1 || N > 1000)
                {
                    return;
                }

                List<string> resultLst = new List<string>();

                for (int i = 0; i < N; i++)
                {
                    string result = string.Empty;
                    var line3 = System.Console.ReadLine();
                    if (line3.Length <= 500)
                    {
                        string[] resultAry = line3.Split(' ');
                        string addressResult = resultAry[0];
                        string[] addressResultAry = addressResult.Split('.');
                        if (addressResultAry[0] == add1 &&
                            addressResultAry[1] == add2 &&
                            Convert.ToInt32(addressResultAry[2]) >= add3_1 && Convert.ToInt32(addressResultAry[2]) <= add3_2 &&
                            Convert.ToInt32(addressResultAry[3]) >= add4_1 && Convert.ToInt32(addressResultAry[3]) <= add4_2)
                        {
                            result = resultAry[0] + " ";
                            result = result + (resultAry[3].Replace("[", "")) + " ";
                            result = result + resultAry[6];
                            resultLst.Add(result);
                        }
                    }
                }

                foreach (var item in resultLst)
                {
                    System.Console.WriteLine(item);
                }
            }
            catch
            {
            }

        }
    }
}
