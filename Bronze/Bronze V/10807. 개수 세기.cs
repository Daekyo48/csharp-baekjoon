class Class
{
    static void Main()
    {
        string n = Console.ReadLine()!;
        string[] numbers = Console.ReadLine()!.Split();
        string v = Console.ReadLine()!;

        int count = 0;

        foreach (string number in numbers)
        {
            if (number == v)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}