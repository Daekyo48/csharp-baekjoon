class Class
{
    const int bufferSize = 131072;
    static readonly StreamReader input = new(new BufferedStream(Console.OpenStandardInput(), bufferSize));
    static readonly StreamWriter output = new(new BufferedStream(Console.OpenStandardOutput(), bufferSize));

    static void Main()
    {
        int t = int.Parse(input.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] numbers = input.ReadLine()!.Split();

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            output.WriteLine(a + b);
        }

        output.Close();
    }
}