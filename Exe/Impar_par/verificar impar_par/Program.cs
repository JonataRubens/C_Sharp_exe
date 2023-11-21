using System;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("num inteiro");
        if(int.TryParse(Console.ReadLine(), out int userInput))
        {
            int result = CalculateSquare(userInput);
            Console.WriteLine($"O quadrado do número {userInput} é {result}.");

            if (result % 2 == 0)
            {
                Console.WriteLine("O resultado é um número par.");
            }
            else
            {
                Console.WriteLine("O resultado é um número ímpar.");
            }

        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }   
    static int CalculateSquare(int number)
    {
        return number * number;
    }
}