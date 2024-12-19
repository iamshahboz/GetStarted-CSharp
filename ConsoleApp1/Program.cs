namespace ConsoleApp1;

internal static class Program
{
    private static void Main()
    {
        const int number = 5;
        var s = number.ToString();
        Console.WriteLine($"The value of the number is:{number}");
        Console.WriteLine($"The type of the number is:{s.GetType()}");

        var digit = 2;
        var count = 10;
        var totalPrice = 20.95f;
        var firstName = "Tommy";
        var isWorking = false;

        Console.WriteLine(digit);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);
        


        #region Checking

        var checker = new Checker();
        checker.Check();

        #endregion
    }
}