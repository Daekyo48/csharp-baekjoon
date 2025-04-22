class Class
{
    static void Main()
    {
        string number;

        while ((number = Console.ReadLine()!) != "-1")
        {
            int n = int.Parse(number);

            List<int> factors = new();

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                }
            }

            if (factors.Sum() == n)
            {
                Console.WriteLine($"{n} = {string.Join(" + ", factors)}");
            }
            else
            {
                Console.WriteLine($"{n} is NOT perfect.");
            }
        }
    }
}