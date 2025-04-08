class Class
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        bool[] hasSeen = new bool[26];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine()!;

            for (int j = 1; j < word.Length; j++)
            {
                hasSeen[word[j - 1] - 'a'] = true;

                if (word[j] != word[j - 1] && hasSeen[word[j] - 'a'])
                {
                    count++;
                    break;
                }
            }

            Array.Clear(hasSeen, 0, 26);
        }

        Console.WriteLine(n - count);
    }
}