class Class
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()!.Split();

        int firstNumber = (numbers[0][2] - '0') * 100 + (numbers[0][1] - '0') * 10 + (numbers[0][0] - '0');
        int secondNumber = (numbers[1][2] - '0') * 100 + (numbers[1][1] - '0') * 10 + (numbers[1][0] - '0');

        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}