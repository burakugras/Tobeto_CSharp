internal class Program
{
    private static void Main(string[] args)
    {
        //value types

        byte number4 = 255;
        short number3 = 32767;//16 bit
        int number1 = 2147483647;//32 bit
        long number2 = 9223372036854775807;//64 bit
        Console.WriteLine("Number1 is {0}",number1);
        Console.WriteLine("Number1 is {0}",number2);
        Console.WriteLine("Number1 is {0}",number3);
        Console.WriteLine("Number1 is {0}",number4);
        Console.ReadLine();
    }
}