//階乗とは数学の演算の一つで、N の階乗をN! と書きます。N が自然数であるとき、階乗は次のように計算できます。

//N! = N* (N - 1) * ... * 2 * 1


//N が与えられたとき、N! のすべての桁の代わりに、N! の最下位桁から続く0 をすべて除いた値の下位9桁を求めるプログラムを作成してください。
//9桁ではあるが先頭が0であるような場合は先頭の0を取り除いた値を出力してください。先頭に0のついた値を出力すると誤答となります。
//例えば N = 38 の時は以下のようになります。

//     条件

//すべてのテストケースにおいて、以下の条件をみたします。

//1 ≦ N ≦ 1000000

//     期待する出力

//N! の最下位桁から続く0 をすべて除いた値の下位9桁を出力して下さい。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.poh.ando
{
    public class ando13
    {
        //public static void Main()
        //{
        //    //版本二
        //    //为解决时间问题 用长整形只存储后几位
        //    // 结果有错 放弃
        //    try
        //    {
        //        List<string> lstResult = new List<string>();

        //        var line = System.Console.ReadLine();

        //        DateTime start = DateTime.Now;

        //        int N = Convert.ToInt32(line);
        //        if (N < 1 || N > 1000000)
        //        {
        //            return;
        //        }
        //        int tempN = N;
        //        N = 1;
        //        for (int a = 1; a <= tempN; a++)
        //        {
        //            N = a;


        //            long tempResultA = 1L;
        //            long tempResultB = 1L;

        //            for (int i = 1; i <= N; i++)
        //            {
        //                tempResultB = i;
        //                string tempStrB = tempResultB.ToString();
        //                int indexJ = 0;
        //                for (int j = tempStrB.Length - 1; j >= 0; j--)
        //                {
        //                    if (tempStrB[j] != '0')
        //                    {
        //                        indexJ = j;
        //                        break;
        //                    }
        //                }
        //                tempStrB = tempStrB.Substring(0, indexJ + 1);

        //                tempResultB = Int64.Parse(tempStrB);

        //                string tempStrA = tempResultA.ToString();
        //                int indexK = 0;
        //                for (int k = tempStrA.Length - 1; k >= 0; k--)
        //                {
        //                    if (tempStrA[k] != '0')
        //                    {
        //                        indexK = k;
        //                        break;
        //                    }
        //                }
        //                tempStrA = tempStrA.Substring(0, indexK + 1);
        //                if (tempStrA.Length > 15)
        //                {
        //                    tempStrA = tempStrA.Substring(tempStrA.Length - 15);
        //                }

        //                tempResultA = Int64.Parse(tempStrA);


        //                tempResultA = tempResultA * tempResultB;

        //            }

        //            string resultA = tempResultA.ToString();
        //            int indexL = 0;
        //            for (int l = resultA.Length - 1; l >= 0; l--)
        //            {
        //                if (resultA[l] != '0')
        //                {
        //                    indexL = l;
        //                    break;
        //                }
        //            }
        //            resultA = resultA.Substring(0, indexL + 1);
        //            if (resultA.Length > 9)
        //            {
        //                resultA = resultA.Substring(resultA.Length - 9);
        //            }
        //            System.Console.WriteLine(Convert.ToInt32(resultA).ToString());
        //            lstResult.Add(Convert.ToInt32(resultA).ToString());
        //        }

        //        File.WriteAllLines(@"c:\resultNew.txt", lstResult.ToArray());
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //}

        public void Main()
        {
            //版本一
            //标准的计算阶乘 只计算后9位 结尾非零

            try
            {
                List<string> lstResult = new List<string>();

                var line = System.Console.ReadLine();

                DateTime start = DateTime.Now;

                int N = Convert.ToInt32(line);
                if (N < 1 || N > 1000000)
                {
                    return;
                }
                //int tempN = N;
                //for (int a = 1; a <= tempN; a++)
                //{
                //    N = a;
                int arrayLength = 20;

                int[] tempResultA = new int[arrayLength];
                int[] tempResultB = new int[arrayLength];
                int[] tempResultC = new int[arrayLength];

                for (int i = 1; i <= N; i++)
                {
                    if (i == 1)
                    {
                        tempResultA[0] = 1;
                    }

                    tempResultB = new int[arrayLength];
                    bool haveValue = false;
                    int tempC = 0;
                    for (int tempI = 0; tempI < tempResultA.Length; tempI++)
                    {
                        if (tempResultA[tempI] != 0)
                        {
                            haveValue = true;
                        }

                        if (haveValue == true)
                        {
                            tempResultB[tempC] = tempResultA[tempI];
                            tempC++;
                        }
                    }
                    tempResultA = new int[arrayLength];
                    tempResultB.CopyTo(tempResultC, 0);

                    ////耗时原因改进 10的倍数减倍数计算
                    //int length = int.Parse(i.ToString().TrimEnd('0'));

                    //for (int j = 1; j < length; j++)
                    //{
                    //    bool addOne = false;
                    //    for (int k = 0; k < arrayLength; k++)
                    //    {
                    //        int tempResult = 0;
                    //        tempResult = tempResultA[k] + tempResultB[k];
                    //        if (addOne)
                    //        {
                    //            tempResult = tempResult + 1;
                    //        }
                    //        if (tempResult >= 10)
                    //        {
                    //            addOne = true;
                    //            tempResultA[k] = tempResult - 10;
                    //        }
                    //        else
                    //        {
                    //            addOne = false;
                    //            tempResultA[k] = tempResult;
                    //        }
                    //    }
                    //}

                    //乘法模拟版本
                    //最快的版本了 还是不能通过第四个测试 超时
                    string times = i.ToString().TrimEnd('0');
                    int arc_times1 = 0;
                    for (int times1 = times.Length - 1; times1 >= 0; times1--)
                    {
                        int time2 = Convert.ToInt32(times[times1].ToString());

                        if (time2 == 0)
                        {
                            arc_times1++;
                            continue;
                        }

                        tempResultB.CopyTo(tempResultC, 0);

                        int addOne = 0;
                        int count1 = 0;
                        for (int k = times.Length - 1 - times1; k < arrayLength; k++)
                        {
                            int tempResult = 0;
                            tempResult = tempResultB[count1] * time2;
                            count1++;

                            tempResult = tempResult + addOne;

                            if (tempResult >= 10)
                            {
                                addOne = Convert.ToInt32(tempResult.ToString().Substring(0, 1));
                                tempResultC[k] = Convert.ToInt32(tempResult.ToString().Substring(1, 1));
                            }
                            else
                            {
                                addOne = 0;
                                tempResultC[k] = tempResult;
                            }
                        }

                        for (int time5 = 0; time5 < arc_times1; time5++)
                        {
                            tempResultC[time5] = 0;
                        }
                        arc_times1++;

                        addOne = 0;
                        for (int k = 0; k < arrayLength; k++)
                        {
                            int tempResult = 0;
                            tempResult = tempResultA[k] + tempResultC[k];

                            tempResult = tempResult + addOne;
                            if (tempResult >= 10)
                            {
                                addOne = 1;
                                tempResultA[k] = tempResult - 10;
                            }
                            else
                            {
                                addOne = 0;
                                tempResultA[k] = tempResult;
                            }
                        }
                    }

                }

                string result = string.Empty;
                int count = 0;
                for (int l = 0; l < tempResultA.Length; l++)
                {
                    if (count == 9)
                    {
                        break;
                    }

                    if (tempResultA[l] == 0 && count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        count++;
                        result = tempResultA[l] + result;
                    }
                }
                System.Console.WriteLine(Convert.ToInt32(result).ToString());
                //lstResult.Add(Convert.ToInt32(result).ToString());

                // DateTime end = DateTime.Now;
                //System.Console.WriteLine(end - start);
                //}

                //File.WriteAllLines(@"c:\resultOld_2.txt", lstResult.ToArray());
            }
            catch (Exception ex)
            {
            }
        }
    }
}
