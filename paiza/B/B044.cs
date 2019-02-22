using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace paiza.B
{
    class B044
    {
        static List<string> Xcount = new List<string>();

        enum MyEnum
        {
            up,
            down,
            left,
            right
        }

        public static void B044Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int H = Convert.ToInt32(line.Split(' ')[0]);
                int W = Convert.ToInt32(line.Split(' ')[1]);

                if (H < 3 || W < 3 || H > 100 || W > 100)
                {
                    return;
                }

                string[,] inputArray = new string[H, W];

                List<string> input = new List<string>();

                const string pattern = "^[1-9]*$";
                Regex rx = new Regex(pattern);


                List<string> NumberCount = new List<string>();

                for (int i = 0; i < H; i++)
                {
                    line = System.Console.ReadLine();
                    string temp = line;
                    if (temp.Length != W)
                    {
                        return;
                    }
                    for (int j = 0; j < W; j++)
                    {
                        string item = line[j].ToString();

                        if (item == "." || item == "#" || item == "X" || rx.IsMatch(item))
                        {
                            if (i == 0 && item != "#")
                            {
                                return;
                            }
                            if (i == H - 1 && item != "#")
                            {
                                return;
                            }
                            if (j == 0 && item != "#")
                            {
                                return;
                            }
                            if (j == W - 1 && item != "#")
                            {
                                return;
                            }

                            if (item == "X")
                            {
                                Xcount.Add(i.ToString() + "," + j.ToString());
                            }
                            else if (rx.IsMatch(item))
                            {
                                NumberCount.Add(i.ToString() + "," + j.ToString() + "," + item);
                            }

                            inputArray[i, j] = item;
                        }
                        else
                        {
                            return;
                        }
                    }
                    input.Add(temp);
                }

                List<string> redArea = new List<string>();

                foreach (var item in NumberCount)
                {
                    int x = Convert.ToInt32(item.Split(',')[0]);
                    int y = Convert.ToInt32(item.Split(',')[1]);
                    int number = Convert.ToInt32(item.Split(',')[2]);

                    //up
                    if (x - 1 != 0)
                    {
                        NewMethod(H, W, inputArray, x, y, MyEnum.up, number);
                    }

                    //down
                    if (x + 1 != H - 1)
                    {
                        NewMethod(H, W, inputArray, x, y, MyEnum.down, number);
                    }

                    // left
                    if (y - 1 != 0)
                    {
                        NewMethod(H, W, inputArray, x, y, MyEnum.left, number);
                    }

                    // right
                    if (y + 1 != W - 1)
                    {
                        NewMethod(H, W, inputArray, x, y, MyEnum.right, number);
                    }
                }

                if (Xcount.Count > 0)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void NewMethod(int H, int W, string[,] inputArray, int x, int y, MyEnum en, int number)
        {

            string temp2 = string.Empty;
            switch (en)
            {
                case MyEnum.up:
                    temp2 = inputArray[x - 1, y];
                    break;
                case MyEnum.down:
                    temp2 = inputArray[x + 1, y];
                    break;
                case MyEnum.left:
                    temp2 = inputArray[x, y - 1];
                    break;
                case MyEnum.right:
                    temp2 = inputArray[x, y + 1];
                    break;
                default:
                    break;
            }

            if (temp2 == "#" || number == 0)
            {
                return;
            }
            else
            {
                string comp = string.Empty;
                switch (en)
                {
                    case MyEnum.up:
                        comp = (x - 1).ToString() + "," + y.ToString();
                        break;
                    case MyEnum.down:
                        comp = (x + 1).ToString() + "," + y.ToString();
                        break;
                    case MyEnum.left:
                        comp = x.ToString() + "," + (y - 1).ToString();
                        break;
                    case MyEnum.right:
                        comp = x.ToString() + "," + (y + 1).ToString();
                        break;
                    default:
                        break;
                }
                if (Xcount.Contains(comp))
                {
                    Xcount.Remove(comp);
                }

                if (Xcount.Count == 0)
                {
                    return;
                }

                switch (en)
                {
                    case MyEnum.up:
                        if (x - 1 != 0)
                        {
                            number--;
                            NewMethod(H, W, inputArray, x - 1, y, MyEnum.up, number);
                        }
                        break;
                    case MyEnum.down:
                        if (x + 1 != H - 1)
                        {
                            number--;
                            NewMethod(H, W, inputArray, x + 1, y, MyEnum.down, number);
                        }
                        break;
                    case MyEnum.left:
                        if (y - 1 != 0)
                        {
                            number--;
                            NewMethod(H, W, inputArray, x, y - 1, MyEnum.left, number);
                        }
                        break;
                    case MyEnum.right:
                        if (y + 1 != W - 1)
                        {
                            number--;
                            NewMethod(H, W, inputArray, x, y + 1, MyEnum.right, number);
                        }
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
