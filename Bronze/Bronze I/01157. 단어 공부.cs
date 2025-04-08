class Class
{
    static void Main()
    {
        string word = Console.ReadLine()!.ToUpper();

        int[] counts = Enumerable.Repeat(0, 26).ToArray();
        int maxCount = 0;
        int maxCountIndex = 0;
        bool hasMultiple = false;

        foreach (char character in word)
        {
            counts[character - 'A']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                maxCountIndex = i;
                hasMultiple = false;
            }
            else if (counts[i] == maxCount)
            {
                hasMultiple = true;
            }
        }

        Console.WriteLine(hasMultiple ? '?' : (char)(maxCountIndex + 'A'));
    }
}