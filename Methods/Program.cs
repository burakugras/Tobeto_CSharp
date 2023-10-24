internal class Program
{
    private static void Main(string[] args)
    {
        Add();
        Add();
        Add();
        Add();

        var result = Add2(4);
        Console.WriteLine(result);

        Console.ReadLine();
    }

    static void Add()
    {
        Console.WriteLine("Added!!!");
    }

    static int Add2(int number1 = 20, int number2 = 30)// default değerler her zaman metotoun en sonunda olmak zorunda
    {
        var result = number1 + number2;
        return result;
    }
}