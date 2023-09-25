static void PagarPedido()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Pagamento do pedido");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Lista de Pedidos:");
        for (int i = 0; i < pedidos.Count; i++)
        {
            var pedido = pedidos[i];
            Console.WriteLine($"{i + 1}. Cliente: {pedido.NomeCliente} - Falta: {pedido.ValorTotal - pedido.ValorPago:C}");
        }

        Console.Write("Qual o número do pedido: ");
        if (int.TryParse(Console.ReadLine(), out int pedidoIndex) && pedidoIndex >= 1 && pedidoIndex <= pedidos.Count)
        {
            var pedidoEscolhido = pedidos[pedidoIndex - 1];

            Console.WriteLine(" ");
            Console.WriteLine("ESCOLHA UMA FORMA DE PAGAMENTO");
            MostrarFormasDePagamento();

            if (int.TryParse(Console.ReadLine(), out int formaPagamento) && FormasDePagamento.ContainsKey(formaPagamento))
            {
                pedidoEscolhido.FormaPagamento