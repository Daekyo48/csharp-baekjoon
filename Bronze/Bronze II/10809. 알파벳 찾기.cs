class Class
{
    static void Main()
    {
        string s = Console.ReadLine()!;
        
        int[] firstPositions = Enumerable.Repeat(-1, 26).ToArray();

        for (int i = 0; i < s.Length; i++)
        {
            if (firstPositions[s[i] - 'a'] == -1)
            {
                firstPositions[s[i] - 'a'] = i;
            }
        }

        Console.WriteLine(string.Join(' ', firstPositions));
    }
}