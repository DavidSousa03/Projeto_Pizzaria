using MeuProjeto.models;

// variaveis 
var pizza = new Pizza();
var opçao = 0;
while (opçao != 3 )
{
    opçao = Menu.ExibirMenu();

    switch (opçao){
        case 1:
            Console.WriteLine("Adicionar uma Pizza!");
            Console.WriteLine("Digite o nome da Pizza: ");
            pizza.nome = Console.ReadLine();

            Console.WriteLine("Digite os sabores das pizzas separados por virgula ");
            pizza.sabores = Console.ReadLine();

            Console.WriteLine("Digite o preço da Pizza (formato 00,00): ");
            pizza.preco = double.Parse(Console.ReadLine());

            Console.WriteLine("PIZZA CRIADA COM SUCESSO ");
            break;
        case 2:
            Console.WriteLine("Listar as Pizzas! ");
            Console.WriteLine("NOME:" + pizza.nome);
            Console.WriteLine("SABOR:" + pizza.sabores);
            Console.WriteLine("PREÇO:" + pizza.preco);
            break;
        case 3:
            Console.WriteLine("Obrigado por usar nossos serviços!");    
            break;
    }
};



   




