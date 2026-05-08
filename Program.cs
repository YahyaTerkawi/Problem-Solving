static class program
{



    static int DigitFrequency(long number , int digit)
    {
        int reminder = 0;
        int Frequency = 0;

        while(number>0)
        {
            if (number % 10 == digit)
                Frequency++;

            number /= 10;
        }


        return Frequency;
    }

    static void PrintDigitsRepeates(long number)
    {
        int repeates = 0;

        for (int i = 0; i < 10; i++)
        {
            repeates = DigitFrequency(number, i);

            if (repeates > 0)
                Console.WriteLine($"{i} repeates {repeates}");
        }
    }

    static void Main(string[] args)
    {

        PrintDigitsRepeates(112225550009991000);
       
        Console.ReadKey();

    }
}