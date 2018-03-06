//あなたは小学校一年生の先生です。今週の授業で、足し算と引き算を教えます。あなたは、足し算と引き算を用いた宿題を作る必要があり、そのためのプログラムを書くことにしました。

//以下の手順で問題をランダム生成するプログラムはもうできているのですが、その答えを求めるプログラムはまだできていません。答えを求めるプログラムを書いてください。

//[問題生成の手順]

//1. 正しい式 a + b = c, あるいは a - b = c(a, b, c, は整数) を生成する
//2. a, b, c のうちいずれか 1 つを空欄にする

//この空欄に入れるべき整数が「答え」となります。

//ここに、足し算、引き算の問題について例を一つずつ示します。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C034
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine();

            string[] lines = line.Split(' ');

            string temp = "1234567890x";

            string a = lines[0];
            if (temp.Contains(a)==false)
            {
                return;
            }

            string op= lines[1];
            if ("+-".Contains(op)==false)
            {
                return;
            }

            string b = lines[2];
            if (temp.Contains(b) == false)
            {
                return;
            }

            string c = lines[4];
            if (temp.Contains(c) == false)
            {
                return;
            }

            int result = 0;

            if (op=="+")
            {
                if (a=="x")
                {
                    result = Convert.ToInt32(c) - Convert.ToInt32(b);
                }
                else if (b=="x")
                {
                    result = Convert.ToInt32(c) - Convert.ToInt32(a);
                }
                else
                {
                    result = Convert.ToInt32(a) + Convert.ToInt32(b);
                }
            }
            else
            {
                if (a == "x")
                {
                    result = Convert.ToInt32(c) + Convert.ToInt32(b);
                }
                else if (b == "x")
                {
                    result = Convert.ToInt32(a) - Convert.ToInt32(c);
                }
                else
                {
                    result = Convert.ToInt32(a) - Convert.ToInt32(b);
                }
            }

            Console.WriteLine(result);
        }
    }
}
