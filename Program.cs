using projeto_estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                          "Digite o Preço Inicial:");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o Preço por Hora:");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());


        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1- Cadastrar Carro");
            Console.WriteLine("2 - Cadastrar Moto");
            Console.WriteLine("3 - Remover Carro");
            Console.WriteLine("4 - Remover Moto");
            Console.WriteLine("5 - Listar Carro");
            Console.WriteLine("6 - Listar Moto");
            Console.WriteLine("7 - Listar Carros e Motos");
            Console.WriteLine("8 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    es.AdicionarVeiculoCarro();
                    break;

                case "2":
                    es.AdicionarVeiculoMoto();
                    break;

                case "3":
                    es.RemoverVeiculoCarro();
                    break;

                case "4":
                    es.RemoverVeiculoMoto();
                    break;

                case "5":
                    es.ListarVeiculosCarro();
                    break;

                case "6":
                    es.ListarVeiculosMoto();
                    break;

                case "7":
                    es.ListarTodos();
                    break;

                case "8":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("O programa se encerrou");
    }
}