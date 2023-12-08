using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string input = Console.ReadLine();

        Dictionary<string, int> frequenciaPalavras = ContarFrequenciaPalavras(input);

        Console.WriteLine("\nFrequência de Palavras:");
        foreach (var par in frequenciaPalavras)
        {
            Console.WriteLine($"{par.Key}: {par.Value} vezes");
        }
    }

    static Dictionary<string, int> ContarFrequenciaPalavras(string input)
    {
        string[] palavras = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> frequencia = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (var palavra in palavras)
        {
            if (frequencia.ContainsKey(palavra))
            {
                frequencia[palavra]++;
            }
            else
            {
                frequencia[palavra] = 1;
            }
        }

        return frequencia;
    }
}
