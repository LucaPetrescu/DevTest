public class Counter
{
    public static void count()
    {
        string lowLimit = "a";
        string upperLimit = "aaaaaaaaaa";

        for (int i = lowLimit.Length; i <= upperLimit.Length * upperLimit.Length; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void countUsingASCII()
    {
        string start = "a";
        int end = 'c' + start.Length;
        for (int i = start.Length; i <= end; i++)
        {
            Console.WriteLine("" + i);
        }
    }
}