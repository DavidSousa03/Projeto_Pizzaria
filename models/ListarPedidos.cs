static void ListarPedidos()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Lista de pedidos");
        Console.WriteLine("---------------------------------------------");

        for (int i = 0; i < pedidos.Count; i++)
        {
            var pedido = pedidos[i];
            Console.WriteLine($"Cliente: {pedido.NomeCliente} - Telefone: {pedido.Telefone}");
            Console.WriteLine("Pizzas do Pedido:");
            foreach (var pizzaPedido in pedido.PizzasSelecionadas)
            {
                Console.WriteLine($"{pizzaPedido.Nome} - Valor: {pizzaPedido.Valor:C}");
            }
            Console.WriteLine($"Total: {pedido.ValorTotal:C}");

            if (pedido.FoiPago)
            {
                Console.WriteLine("Quanto falta para pagar: R$ 00,00");
                Console.WriteLine("Pago: SIM");
            }
            else
            {
                Console.WriteLine($"Quanto falta para pagar: {pedido.ValorTotal - pedido.ValorPago:C}");
                Console.WriteLine("Pago: NÃO");
            }
        }
        Console.WriteLine("---------------------------------------------");
    }