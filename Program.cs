static class program
{

    static bool IsPrimeNumber(int num)
    {
        if(num == 2)
            return true;

        for(int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }


    static List<int> PrimeNumbersFrom1ToN(int N)
    {
        List<int> primes = new();

        for(int i = 2; i<=N; i++ )
        {
            if(IsPrimeNumber(i))
                primes.Add(i);
        }

        return primes;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("enter a number to print all prime numbers from 1 to it : ");
        int num;


        while(!int.TryParse(Console.ReadLine() , out num)  || (num<=0))
        {

            Console.WriteLine("please enter a valid number : ");

            
        }

        List<int> primes = PrimeNumbersFrom1ToN(num);


        Console.WriteLine($"\nPrime Numbers Count : {primes.Count}\n");
        

        Console.Write("Prime Numbers :");

        foreach(int p in primes)
        {
            Console.Write($"   {p}");
        }

        Console.ReadKey();


    }
}