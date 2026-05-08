static class program
{

    static void PrintHeader()
    {
        Console.WriteLine();
        Console.WriteLine("\t\t\t Multiplication Table From 1 to 10");
        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"\t {i}");
        }
        Console.WriteLine();
        Console.WriteLine("________________________________________________________________________________________________________");
    }

    static void PrintMultiPlicationTableX(int Table , string ColumnSeperaor= "    ")
    {
        Console.WriteLine();

        Console.Write($"{Table}{ColumnSeperaor}|   ");

        for (int i = 1; i <= 10; i++)
        {
            
            Console.Write($"{i*Table}\t");

        }
    }

    static void PrintMultiplicationTables()
    {
        for(int i = 1;i <= 10;i++)
        {
            if (i == 10)
            {
                PrintMultiPlicationTableX(i, "   ");
                break;
            }
               

            PrintMultiPlicationTableX (i);
        }
    }

    static void Main(string[] args)
    {
        PrintHeader();
        PrintMultiplicationTables();
        Console.ReadKey();
    }
}