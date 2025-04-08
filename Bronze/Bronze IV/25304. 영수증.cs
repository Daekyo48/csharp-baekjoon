class Class
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n; i++)
        {
            string[] receiptItems = Console.ReadLine()!.Split();

            int a = int.Parse(receiptItems[0]);
            int b = int.Parse(receiptItems[1]);

            x -= a * b;
        }

        Console.WriteLine(x == 0 ? "Yes" : "No");
    }
}