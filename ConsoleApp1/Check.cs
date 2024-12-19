namespace ConsoleApp1;

internal class Checker
{
    public void Check()
    {
        checked
        {
            long i = int.MaxValue;
            i++;
            Console.WriteLine(i);

            Console.WriteLine();
            byte number = 200;
            number += 2;
            Console.WriteLine(number);
        }
    }
}