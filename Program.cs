class program
{

    static void PrintLetterPattern(int num)
    {
        for (int i = 65; i < 65 + num; i++)
        {
            for (int j = 65; j <= i; j++)
            {
                Console.Write((char)i);
            }

            Console.WriteLine();

        }
    }

    static void Main(string[] args)
    {
        PrintLetterPattern(9);
    }
}