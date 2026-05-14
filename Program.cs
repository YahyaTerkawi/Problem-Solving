class program
{

    static void PrintInvertedLetterPattern(int num)
    {
        for (int i = 64+num; i > 64; i--)
        {
            for(int j = 64 ; j<i; j++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        PrintInvertedLetterPattern(9);
    }
}