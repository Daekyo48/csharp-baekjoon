class Class
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] scores = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

        double maxScore = scores.Max();
        double totalScore = 0;

        foreach (double score in scores)
        {
            totalScore += score / maxScore * 100;
        }

        Console.WriteLine(totalScore / n);
    }
}