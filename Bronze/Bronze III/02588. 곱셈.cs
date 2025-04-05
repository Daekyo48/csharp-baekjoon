class Class
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine()!);
        int secondNumber = int.Parse(Console.ReadLine()!);

        int oneDigit = secondNumber % 10;
        int tenDigit = secondNumber % 100 / 10;
        int hundredDigit = secondNumber / 100;

        Console.WriteLine(firstNumber * oneDigit);
        Console.WriteLine(firstNumber * tenDigit);
        Console.WriteLine(firstNumber * hundredDigit);
        Console.WriteLine(firstNumber * secondNumber);
    }
}