

public class ando19
{
    public static void ando19Main()
    {
        
        
        var line = System.Console.ReadLine();
        try
        {
            if (line.ToString().Length >= 1 && line.ToString().Length <= 100)
            {
                string input = line.ToString();
                int c = 0;
                int a = 0;
                int t = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i].ToString())
                    {
                        case "c":
                            c++;
                            break;
                        case "a":
                            a++;
                            break;
                        case "t":
                            t++;
                            break;
                        default:
                            return;
                    }
                }

                int countCat = 0;
                while (c > 0 && a > 0 && t > 0)
                {
                    countCat++;
                    c--;
                    a--;
                    t--;
                }

                //max
                int max = 0;
                if (c > a)
                {
                    max = c;
                }
                else
                {
                    max = a;
                }

                if (max < t)
                {
                    max = t;
                }

                System.Console.WriteLine(countCat.ToString());
                System.Console.WriteLine((max - c).ToString());
                System.Console.WriteLine((max - a).ToString());
                System.Console.WriteLine((max - t).ToString());
            }
        }
        catch
        {

        }
    }
}

