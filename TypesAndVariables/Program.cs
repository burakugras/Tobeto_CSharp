internal class Program
{
    private static void Main(string[] args)
    {
        //value types

        double number5 = 10.4;//64 bit
        char character = 'A';//16 bit
        bool condition = false;//1 bit
        byte number4 = 255;//8 bit
        short number3 = 32767;//16 bit
        int number1 = 2147483647;//32 bit
        long number2 = 9223372036854775807;//64 bit
        Console.WriteLine("Number1 is {0}",number1);
        Console.WriteLine("Number2 is {0}",number2);
        Console.WriteLine("Number3 is {0}",number3);
        Console.WriteLine("Number4 is {0}",number4);
        Console.WriteLine("Number5 is {0}",number5);
        Console.WriteLine("Character is {0}",(int)character);
        Console.ReadLine();
    }
}