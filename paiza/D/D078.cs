//あなたは PAIZA 大学の 7 科目からなる入学試験を受けました。

//7 つの科目はすべて 100 点満点のテストで、平均点が合格点以上なら合格します。

//あなたの 7 科目それぞれの点数と合格点が与えられるので、合格する場合は"pass"を、不合格の場合は"failure"を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D078
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();

                int result = 0;
                for (int i = 0; i < 7; i++)
                {
                    int number = Convert.ToInt32(line.Split(' ')[i]);

                    if (number < 0 || number > 100)
                    {
                        return;
                    }

                    result = result + number;

                }

                result = result / 7;

                if (result >= Convert.ToInt32(line2))
                {
                    System.Console.WriteLine("pass");
                }
                else
                {
                    System.Console.WriteLine("failure");
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
