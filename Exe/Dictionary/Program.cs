class Dicts
{
    static void Main(string[] args)
    {
        Dictionary<int, string> info = new Dictionary<int, string>();

        var dict2 = new Dictionary<int, int>()
        {
            {1,100},
            {2,200},
            {4,400},
        };

        info.Add(1, "Info cba1");
        info.Add(2, "info abc 2");

        var res = dict2.TryAdd(5, 333);
        Console.WriteLine("elemento foi incluido? " + res);
        int n = 2;
        if (!dict2.ContainsKey(n))
        {
            dict2.Add(7, 700);
        }
        else
        {
            Console.WriteLine("key" + n + "ja foi incluida");
        }

        if(dict2.TryGetValue(n, out int key)) 
        {
            Console.WriteLine("Valor para chave " + n + "=" + key);
        }

        foreach(var item in dict2)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
        foreach (var item in info)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
    }
}