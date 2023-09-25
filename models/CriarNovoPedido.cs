static void CriarNovoPedido()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Novo pedido");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Quem é o cliente? ");
        string nomeCliente = Console.ReadLine();
        Console.Write("Qual o telefone do cliente? ");
        string telefone = Console.ReadLine();

        List<Pizza> pizzasPedido = new List<Pizza>();
        decimal totalPedido = 0;

        do
        {
            Console.WriteLine("Escolha uma pizza para adicionar (digite o número):");
            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzas[i].Nome} - Valor: {pizzas[i].Valor:C}");
            }

            if (int.TryParse(Console.ReadLine(), out int pizzaIndex) && pizzaIndex >= 1 && pizzaIndex <= pizzas.Count)
            {
                Pizza pizzaSelecionada = pizzas[pizzaIndex - 1];
                pizzasPedido.Add(pizzaSelecionada);
                totalPedido += pizzaSelecionada.Valor;

                Console.Write("Deseja acrescentar mais uma pizza? (1 - SIM | 2 - NÃO): ");
            }
            else
            {
                MostrarMensagemErro("Pizza inválida. Tente novamente.");
            }
        } while (Console.ReadLine() == "1");

        Pedido novoPedido = new Pedido(nomeCliente, telefone, pizzasPedido, totalPedido);
        pedidos.Add(novoPedido);

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"PEDIDO CRIADO - Total: {novoPedido.ValorTotal:C}");
        Console.WriteLine("---------------------------------------------");
    }