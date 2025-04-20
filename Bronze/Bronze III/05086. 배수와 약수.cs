class Class
{
    static void Main()
    {
        string numberPair;

        while ((numberPair = Console.ReadLine()!) != "0 0")
        {
            string[] numbers = numberPair.Split();

            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            if (secondNumber % firstNumber == 0)
            {
                Console.WriteLine("factor");
            }
            else if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine("multiple");
            }
            else
            {
                Console.WriteLine("neither");
            }
        }
    }
}