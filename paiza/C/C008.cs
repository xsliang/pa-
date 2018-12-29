

using System;
public class C008
{
    public static void C008Main()
    {
        try
        {
            var line = System.Console.ReadLine();
            if (line.Split(' ').Length != 2)
            {
                return;
            }
            string tagA = line.Split(' ')[0];
            string tagB = line.Split(' ')[1];
            if (tagA.Substring(0, 1) == "<" && tagA.Substring(tagA.Length - 1, 1) == ">" &&
            tagB.Substring(0, 1) == "<" && tagB.Substring(tagB.Length - 1, 1) == ">" &&
            tagA.Length >= 3 && tagA.Length <= 100 &&
            tagB.Length >= 3 && tagB.Length <= 100 && tagA!= tagB)
            {
                var line2 = System.Console.ReadLine();
                if (line2.Length >= 6 && line2.Length <= 5000)
                {
                    string sameTagA = "";
                    bool begin = false;
                    for (int i = 0; i < line2.Length; i++)
                    {
                        sameTagA = sameTagA + line2[i].ToString();
                        if (sameTagA.Contains(tagA) && begin == false)
                        {
                            sameTagA = "";
                            begin = true;
                        }
                        if (begin==true && sameTagA.Contains(tagB))
                        {
                            sameTagA = sameTagA.Replace(tagB, "");
                            if (sameTagA == "")
                            {
                                System.Console.WriteLine("<blank>");
                            }
                            else
                            {
                                System.Console.WriteLine(sameTagA);
                            }
                            sameTagA = "";
                            begin = false;
                        }
                    }
                }

            }
        }
        catch
        {

        }
    }
}
