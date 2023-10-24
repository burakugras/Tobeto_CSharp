internal class Program
{
    private static void Main(string[] args)
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };


        string[] students2 = { "Engin", "Derin", "Salih" };

        foreach (string student in students2)
        {
            Console.WriteLine(student);
        }

        Console.ReadLine();
    }
}