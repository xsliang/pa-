

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    using System;
    using System.Collections.Generic;

    public class B009
    {
        public static void B009Main()
        {
            
               
            try
            {
                var line = System.Console.ReadLine();
                string temp = "abcdefghijklmnopqrstuvwxyz";
                int N = Convert.ToInt32(line);
                if (N < 1 || N > 10)
                {
                    return;
                }
                string lasttime = "10:00";

                List<string> result = new List<string>();
                List<string> inputs = new List<string>();

                for (int i = 0; i < N; i++)
                {
                    var line2 = System.Console.ReadLine();
                    string name = line2.Split(' ')[0];
                    if (name.Length > 10 || name.Length < 1)
                    {
                        return;
                    }
                    foreach (var item in name)
                    {
                        if (temp.Contains(item.ToString()) == false)
                        {
                            return;
                        }
                    }
                    int time = Convert.ToInt32(line2.Split(' ')[1]);
                    if (time > 60 || time < 1)
                    {
                        return;
                    }

                    inputs.Add(line2);

                }

                for (int i = 0; i < N; i++)
                {
                    string begin = lasttime;
                    int hours = Convert.ToInt32(lasttime.Split(':')[0]);
                    int min = Convert.ToInt32(lasttime.Split(':')[1]);

                    string input = inputs[i];
                    string name = input.Split(' ')[0];
                    int time = Convert.ToInt32(input.Split(' ')[1]);

                    if (min + time >= 60)
                    {
                        hours = hours + 1;
                        min = min + time - 60;
                    }
                    else
                    {
                        min = min + time;
                    }

                    lasttime = hours + ":" + min.ToString("00");

                    result.Add(begin + " - " + lasttime + " " + name);

                    //have a rest
                    if (N != i + 1)
                    {
                        int next = Convert.ToInt32(inputs[i + 1].Split(' ')[1]);
                        if (min + 10 + next > 60 && hours + 1 == 12)
                        {
                            hours = hours + 1;
                        }
                        else
                        {
                            if (min + 10 >= 60)
                            {
                                hours = hours + 1;
                                min = min + 10 - 60;
                            }
                            else
                            {
                                min = min + 10;
                            }
                        }
                    }
                    else
                    {
                        if (min + 10 >= 60)
                        {
                            hours = hours + 1;
                            min = min + 10 - 60;
                        }
                        else
                        {
                            min = min + 10;
                        }
                    }

                    lasttime = hours + ":" + min.ToString("00");
                }

                foreach (var item in result)
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
