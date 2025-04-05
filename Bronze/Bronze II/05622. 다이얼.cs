class Class
{
    static void Main()
    {
        string word = Console.ReadLine()!;

        int timeSum = 0;
        int[] dialTimes = {
            3, 3, 3,
            4, 4, 4,
            5, 5, 5,
            6, 6, 6,
            7, 7, 7,
            8, 8, 8, 8,
            9, 9, 9,
            10, 10, 10, 10
        };

        foreach (char character in word)
        {
            timeSum += dialTimes[character - 'A'];
        }

        Console.WriteLine(timeSum);
    }
}