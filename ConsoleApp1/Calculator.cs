namespace ConsoleApp1;
public class Calculator
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Subtract(int number1, int number2)
    {
        return number1 - number2;
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public double Divide(int number1, int number2)
    {
        if (number2 == 0) //Hande division by zero
        {
            Console.WriteLine("Error: Division by zero");
        }

        return (double)number1 / number2;
    }
    
}