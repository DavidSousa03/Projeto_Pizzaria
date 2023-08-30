public class Menu{
    public static int ExibirMenu(){
        Console.WriteLine("Escolha a opção desejada:");
        Console.WriteLine("1 - Adicionar uma Pizza");
        Console.WriteLine("2 - Listar Pizza");
        Console.WriteLine("3 - Sair");
        Console.WriteLine(" ");
        Console.WriteLine("Digite sua opção: ");
        var opçao = Console.ReadLine();
        return Convert.ToInt32(opçao);
    }
}
