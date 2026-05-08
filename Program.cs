static class program
{

    static (bool,List<int>,int sum) IsPerfectNumber(int number)
    {
        int num = number / 2;
        int sum = 0;
        List<int> divisors = new();


        for(int i = 1; i <= num;i++)
        {
            if (number % i == 0)
            { 
                
               sum += i; 
               divisors.Add(i);
            
            }

            
        }

        return (sum == number, divisors ,sum);
    }


    static void Main(string[] args)
    {
        Console.Write("enter a number to check if is it a perfect number : ");

        int num;

        while(!int.TryParse(Console.ReadLine(), out num) || num<0)
        {
            Console.WriteLine("please enter a valid number");
        }

        (bool IsPerfect, List<int> divisors,int sum) result = IsPerfectNumber(num);

        if(result.IsPerfect)
        {
            Console.Write($"\n{num} = divisors sum (");
            foreach(int divisor in result.divisors )
            {
                if(divisor== result.divisors[result.divisors.Count-1])
                    Console.Write($"{divisor} = {result.sum})");
                else
                    Console.Write($"{divisor} + ");
            }

            Console.WriteLine($"\nso the {num} is a perfect number");
        }

        else
        {
            Console.Write($"\n{num} != divisors sum (");
            foreach (int divisor in result.divisors)
            {
                if (divisor == result.divisors[result.divisors.Count - 1])
                    Console.Write($"{divisor} = {result.sum})");
                else
                    Console.Write($"{divisor} + ");
            }

            Console.WriteLine($"\nso the {num} is not a perfect number");
        }

        Console.ReadKey();
    }
}