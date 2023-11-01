using System;
class V_Palindromos 
{
    static void Main()
    {
        Console.Write("digite uma frase ou palavra");
        String frase = Console.ReadLine();

        string fraseLimpa = limpaFrase(frase);

        bool veredito = verificador(fraseLimpa);

        if (veredito)
        {
            Console.WriteLine($"\"{frase}\" é um polindromo");
        }
        else
        {
            Console.WriteLine($"\"{frase}\" nao é um polindromo");
        }
    }

    static string limpaFrase(string frase)
    {
        frase = frase.Replace(" ", "");

        string[] pontuacao = { ".", ",", "!", "?", "'", "\"", "(", ")", ":", ";" };

        foreach(var p in pontuacao)
        {
            frase = frase.Replace(p, "");
        }

        frase = frase.ToLower();

        return frase;
    }

    static bool verificador(string frase)
    {
        int cont = frase.Length;

        for(int i = 0; i < cont / 2 ; i++)
        {
            if (frase[i] != frase[cont - i - 1])
            {
                return false;
            }
        }
        return true;

    }
}