static void AdicionarPizza()
    {
        if (pizzas.Count >= 10)
        {
            MostrarMensagemErro("Limite máximo de pizzas atingido.");
            return;
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Adicionar pizza");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Digite o nome da pizza: ");
        string nome = Console.ReadLine();
        Console.Write("Digite os ingredientes da pizza (separados por vírgula): ");
        string[] ingredientes = Console.ReadLine().Split(',');

        Console.Write("Digite o valor da pizza: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            MostrarMensagemErro("Valor inválido. Tente novamente.");
            return;
        }

        Pizza novaPizza = new Pizza(nome, ingredientes, valor);
        pizzas.Add(novaPizza);

        Console.WriteLine("Pizza criada com sucesso!");
        Console.WriteLine("---------------------------------------------");
    }