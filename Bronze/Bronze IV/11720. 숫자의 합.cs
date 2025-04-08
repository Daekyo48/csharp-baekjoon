class Class
{
    static void Main()
    {
        Console.ReadLine();
        string numbers = Console.ReadLine()!;

        int numberSum = 0;

        foreach (char number in numbers)
        {
            numberSum += number - '0';
        }

        Console.WriteLine(numberSum);
    }
}