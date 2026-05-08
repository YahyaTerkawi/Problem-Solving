class program
{


    static bool IsPalindromeNumber(int number)
    {
        string s = number.ToString();
        int length = s.Length;

        for (int i = 0; i < length; i++)
        {
            if (s[i] != s[length-1-i])
                return false;

        }
        return true;
    }

    static bool IsPalindromeNumber2(int number)
    {
        int OldNumber = number;
        int ReversedNumber = 0;
        int reminder = 0;

        while(number>0)
        {
            reminder = number % 10;
            number /= 10;
            ReversedNumber = ReversedNumber*10 + reminder;
        }

        return ReversedNumber == OldNumber;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("enter a number to check if is it a palindrome number");

        int num;

        while ((!int.TryParse(Console.ReadLine(), out num)) || num < 0)
        {
            Console.WriteLine("enter a valid number");
        }

        if (IsPalindromeNumber2(num))
            Console.WriteLine($"{num} is a palindrome number");
        else
            Console.WriteLine($"{num} is not a palindrome number");
    }
}