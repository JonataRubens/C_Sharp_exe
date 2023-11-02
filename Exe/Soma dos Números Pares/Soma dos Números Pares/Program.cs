class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo N: ");
        int N = int.Parse(Console.ReadLine());

        if(N == 0)
        {
            Console.WriteLine("numero invalido");
            return;
        }

        int soma = 0;

        for (int i = 1; i<= N; i++)
        {
            if (i%2 == 0)
            {
                soma +=i;
            }
        }
        Console.WriteLine($"A soma dos números pares de 1 a \"{N}\" é: \"{soma}");
    }
}