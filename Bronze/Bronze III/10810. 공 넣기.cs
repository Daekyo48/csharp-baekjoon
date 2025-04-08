class Class
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();

        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);
        int[] baskets = new int[n];

        for (int index = 0; index < m; index++)
        {
            string[] ways = Console.ReadLine()!.Split();

            int i = int.Parse(ways[0]) - 1;
            int j = int.Parse(ways[1]) - 1;
            int k = int.Parse(ways[2]);

            Array.Fill(baskets, k, i, j - i + 1);
        }

        Console.WriteLine(string.Join(' ', baskets));
    }
}