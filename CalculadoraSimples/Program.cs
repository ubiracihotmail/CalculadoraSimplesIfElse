using CalculadoraSimplesIfElse;

Console.Write("Digite um número ");
var calc1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write("Digite o outro número ");
var calc2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write("Digite o operador matemático ");
var operate = Console.ReadLine()!;
Console.WriteLine();

Calculator calculator = new Calculator();
Console.WriteLine($"Resultado: {calculator.Calculate (operate, calc1, calc2)}"); 

namespace CalculadoraSimplesIfElse
{
    internal class Calculator
    {
        public int Calculate(string operation, int value1, int value2)
        {
            if (operation == "+")
            {
                return value1 + value2;
            }
            else if (operation == "-")
            {
                return value1 - value2;
            }
            else if (operation == "*")
            {
                return value1 * value2;
            }
            else if (operation == "/")
            {
                return value1 / value2;
            }
            return 0;
        }

    }
}