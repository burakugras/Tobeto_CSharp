﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Add();
        //Add();
        //Add();
        //Add();

        //var result = Add2(4);

        //int number1=20;
        //int number2 = 100;

        //out keyword ile number1'e bir değer atamaya gerek yoktur
        //var result2=Add3(out number1, number2);


        //Console.WriteLine(result2);
        //Console.WriteLine(number1);

        Console.WriteLine(Multiply(2,4));
        Console.WriteLine(Multiply(2,4,5));

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

    static int Add3(out int number1,int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
    static int Multiply(int number1, int number2,int number3)
    {
        return number1 * number2*number3;
    }
}