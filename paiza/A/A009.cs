using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.A
{
    class A009
    {
        public enum Next_direction
        {
            up,
            down,
            left,
            right
        }

        public static void A009Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int H = Convert.ToInt32(line.Split(' ')[0]);
                int W = Convert.ToInt32(line.Split(' ')[1]);
                int count = 0;
                if (H >= 1 && H <= 100 && W >= 1 && W <= 100)
                {
                    string[,] input = new string[H, W];

                    // input values
                    for (int i = 0; i < H; i++)
                    {
                        line = System.Console.ReadLine();
                        for (int j = 0; j < W; j++)
                        {
                            var item = line[j];

                            if (item == '/' || item == '\\' || item == '_')
                            {
                                input[i, j] = item.ToString();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    int next_i = 0;
                    int next_j = 0;
                    Next_direction next_direction = Next_direction.right;
                    do
                    {
                        if (input[next_i, next_j] == "_")
                        {
                            if (next_direction == Next_direction.right)
                            {
                                next_j = next_j + 1;
                            }
                            else if (next_direction == Next_direction.left)
                            {
                                next_j = next_j - 1;
                            }
                            else if (next_direction == Next_direction.up)
                            {
                                next_i = next_i - 1;
                            }
                            else if (next_direction == Next_direction.down)
                            {
                                next_i = next_i + 1;
                            }
                        }
                        else if (input[next_i, next_j] == "\\")
                        {
                            if (next_direction == Next_direction.right)
                            {
                                next_i = next_i + 1;
                                next_direction = Next_direction.down;
                            }
                            else if (next_direction == Next_direction.left)
                            {
                                next_i = next_i - 1;
                                next_direction = Next_direction.up;
                            }
                            else if (next_direction == Next_direction.up)
                            {
                                next_j = next_j - 1;
                                next_direction = Next_direction.left;
                            }
                            else if (next_direction == Next_direction.down)
                            {
                                next_j = next_j + 1;
                                next_direction = Next_direction.right;
                            }
                        }
                        else if (input[next_i, next_j] == "/")
                        {
                            if (next_direction == Next_direction.right)
                            {
                                next_i = next_i - 1;
                                next_direction = Next_direction.up;
                            }
                            else if (next_direction == Next_direction.left)
                            {
                                next_i = next_i + 1;
                                next_direction = Next_direction.down;
                            }
                            else if (next_direction == Next_direction.up)
                            {
                                next_j = next_j + 1;
                                next_direction = Next_direction.right;
                            }
                            else if (next_direction == Next_direction.down)
                            {
                                next_j = next_j - 1;
                                next_direction = Next_direction.left;
                            }
                        }
                        count++;

                    } while (next_i >= 0 && next_i <= H - 1 && next_j >= 0 && next_j <= W - 1);

                    System.Console.WriteLine(count);

                }
            }
            catch
            {
            }
        }
    }
}
