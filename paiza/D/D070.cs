//using System;
//あなたは本を読んでいたところ、残り何ページか知りたくなりました。

//本の総ページ数 m と読み終えたページ n が入力されるので、残りのページ数を表示してください。

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D070
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                string[] aryLine = line.Split(' ');
                int m = Convert.ToInt32(aryLine[0]);
                int n = Convert.ToInt32(aryLine[1]);
                if (m >= 0 && n >= 0 && m <= 100 && n <= 100 && m > n)
                {
                    System.Console.WriteLine(m - n);
                }



            }
            catch (Exception ex)
            {
            }
        }

    }
}
