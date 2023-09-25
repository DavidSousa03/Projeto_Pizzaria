static void ListarPizzas()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Lista de pizzas");
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < pizzas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pizzas[i].Nome} - Valor: {pizzas[i].Valor:C}");
        }
        Console.WriteLine("---------------------------------------------");
    }