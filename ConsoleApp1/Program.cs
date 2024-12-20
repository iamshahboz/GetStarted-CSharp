namespace ConsoleApp1;

internal static class Program
{
    private static void Main()
    {
        const int number = 5;
        var s = number.ToString();
        Console.WriteLine($"The value of the number is:{number}");
        Console.WriteLine($"The type of the number is:{s.GetType()}");

        //var digit = 2;
        //var count = 10;
        //var totalPrice = 20.95f;
        //var firstName = "Tommy";
        //var isWorking = false;

        //Console.WriteLine(digit);
        //Console.WriteLine(count);
        //Console.WriteLine(totalPrice);
        //Console.WriteLine(firstName);
        //Console.WriteLine(isWorking);



        #region Calculator

        var calculator = new Calculator();
        Console.WriteLine("Addition result: " + calculator.Add(12,8));
        Console.WriteLine("Subtract result: " + calculator.Subtract(12,8));
        Console.WriteLine("Multiply result: " + calculator.Multiply(5, 7));
        Console.WriteLine("Division result: " + calculator.Divide(20,4));

        #endregion
        
        #region

        Person person = new Person("John", 22);
        
        person.Introduce();

        person.Adult();

        #endregion

        #region IsReady

        var ready = new IsReady();
        ready.Root();

        #endregion

    }
}


