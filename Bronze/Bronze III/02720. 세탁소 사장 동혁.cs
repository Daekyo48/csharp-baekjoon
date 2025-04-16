class Class
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            int c = int.Parse(Console.ReadLine()!);

            int Quarter = c / 25;
            c %= 25;
            int Dime = c / 10;
            c %= 10;
            int Nickel = c / 5;
            c %= 5;
            int Penny = c;

            Console.WriteLine($"{Quarter} {Dime} {Nickel} {Penny}");
        }
    }
}