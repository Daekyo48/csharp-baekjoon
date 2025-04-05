class Class
{
    static void Main()
    {
        string[] times = Console.ReadLine()!.Split();
        int c = int.Parse(Console.ReadLine()!);

        int b = int.Parse(times[1]) + c;
        int a = int.Parse(times[0]) + b / 60;

        Console.WriteLine($"{a % 24} {b % 60}");
    }
}