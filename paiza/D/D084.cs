//英語が堪能な Paiza 君ですが、唯一月の名前だけ覚えることができませんでした。
//そこで、いつでも調べることができるように数字を入れるとその月を表す英語が表示されるアプリを開発してください。

//月の名称は以下の表に従います。
//月 英語
//1 	January
//2 	February
//3 	March
//4 	April
//5 	May
//6 	June
//7 	July
//8 	August
//9 	September
//10 	October
//11 	November
//12 	December

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D084
    {
        public static void Main()
        {
            string[] month = new string[] {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var line = System.Console.ReadLine();
            int count = Convert.ToInt32(line);
            if (count < 1 || count > 12)
            {
                return;
            }

            System.Console.WriteLine(month[count - 1]);
        }
    }
}
