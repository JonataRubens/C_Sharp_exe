using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");
        int numRandom = Gerador();
        List<int> tentativas = new List<int>();

        bool acertou = false;

        while(!acertou)
        {
            Console.Write("Digite o num para tentar a sorte");
            if(int.TryParse(Console.ReadLine(), out int tentativa))
            {
                tentativas.Add(tentativa);

                if(tentativa == numRandom)
                {
                    acertou=true;
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas.Count} tentativas.");
                }

                else
                {
                    string dica = tentativa < numRandom ? "maior" : "menor";
                    Console.WriteLine($"Tente novamente! O número é {dica}.");
                    Console.Write($"resposta é; {numRandom}");
                }
            }

            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

        }
    }

    static int Gerador()
    {
        Random random = new Random();

        return random.Next(1, 101);
    }
}