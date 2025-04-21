class Class
{
    static void Main()
    {
        string[] values = Console.ReadLine()!.Split();

        List<int> factors = new();
        int n = int.Parse(values[0]);
        int k = int.Parse(values[1]);

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
            }
        }

        Console.WriteLine(factors.Count < k ? 0 : factors[k - 1]);
    }
}