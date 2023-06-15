public class FibonacciCalculator
{

    public static void GenerateFibonacciSequence(int maxValue)
    {
        int[] fibonacciArray = new int[maxValue + 1];
        int sequenceLength = 0;

        fibonacciArray[0] = 0;
        fibonacciArray[1] = 1;
        sequenceLength = 2;

        for (int i = 2; i <= maxValue; i++)
        {
            fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            if (fibonacciArray[i] > maxValue)
                break;

            sequenceLength++;
        }

        for (int i = sequenceLength - 1; i >= 0; i--)
        {
            Console.Write(fibonacciArray[i] + " ");
        }
    }


}