static class program
{

    static int ReverseNumber(int num)
    {
        int ReversedNumber = 0;
        int Reminder = 0;

        while (num > 0)
        {
            Reminder = num % 10;
            num /= 10;
            ReversedNumber = ReversedNumber * 10 + Reminder;
            
        }





        return ReversedNumber;
    
    }




    static void Main(string[] args)
    {
        Console.WriteLine(ReverseNumber(999777));

        Console.ReadKey();
    }
}