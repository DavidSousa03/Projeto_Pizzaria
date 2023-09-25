using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Pizza> pizzas = new List<Pizza>();
    static List<Pedido> pedidos = new List<Pedido>();

    static void Main()
    {
        while (true)
        {
            MostrarMenu();

            if (!int.TryParse(Console.ReadLine(), out int escolha))
            {
                MostrarMensagemErro("Opção inválida. Tente novamente.");
                continue;
            }

            switch (escolha)
            {
                case 1:
                    AdicionarPizza();
                    break;
                case 2:
                    ListarPizzas();
                    break;
                case 3:
                    CriarNovoPedido();
                    break;
                case 4:
                    ListarPedidos();
                    break;
                case 5:
                    PagarPedido();
                    break;
                case 6:
                    Console.WriteLine("Saindo do programa.");
                    return;
                default:
                    MostrarMensagemErro("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}    
