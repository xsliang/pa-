using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C043
    {
        public static void C043Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 1 && N <= 1000)
                {
                    line = System.Console.ReadLine();
                    Dictionary<string, int> result = new Dictionary<string, int>();

                    if (line.Split(' ').Length == N)
                    {
                        string[] input = line.Split(' ');
                        foreach (var item in input)
                        {
                            int number = Convert.ToInt32(item);
                            if (number >= 1 && number <= 10000)
                            {
                                if (result.ContainsKey(number.ToString()))
                                {
                                    result[number.ToString()] = result[number.ToString()] + 1;
                                }
                                else
                                {
                                    result[number.ToString()] = 1;
                                }
                            }
                        }

                        var temp = result.OrderByDescending(x => x.Value).ToList();

                        List<int> result2 = new List<int>();
                        int max = temp[0].Value;
                        //result2.Add(temp[0].Key);
                        foreach (var item in temp)
                        {
                            if (item.Value == max)
                            {
                                result2.Add(Convert.ToInt32(item.Key));
                            }
                            else
                            {
                                break;
                            }
                        }

                        result2.Sort();

                        System.Console.WriteLine(String.Join(" ",result2.ToArray()));
                    }
                }
            }
            catch
            {
            }
        }
    }
}
