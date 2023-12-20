class Name
{
    static void Main()
    {
        Console.WriteLine("escreva uma frase");
        string input = Console.ReadLine();

        string resultado = InverterPalavras(input);

        Console.WriteLine("\nPalavra invertida");
        Console.WriteLine(resultado);
    }
    static string InverterPalavras(string input)
    {
        string[] palavra = input.Split(' ');

        for(int i = 0; i < palavra.Length; i++)
        {
            char[] letras = palavra[i].ToCharArray();
            Array.Reverse(letras);
            palavra[i] = new string(letras);
        }

        return string.Join(" ", palavra);
    }
}
    