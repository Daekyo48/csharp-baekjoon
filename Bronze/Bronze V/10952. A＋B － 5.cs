class Class
{
    static void Main()
    {
        string numberPair;

        while ((numberPair = Console.ReadLine()!) != "0 0")
        {
            string[] numbers = numberPair.Split();

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            Console.WriteLine(a + b);
        }
    }
}