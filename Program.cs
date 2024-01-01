using projeto_estacionamento.Models;

public class Program
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

        Estacionamento_Carro carro = new Estacionamento_Carro(precoInicial, precoPorHora);

        Estacionamento_Moto moto = new Estacionamento_Moto(precoInicial, precoPorHora);


            bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1-  Carro");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Encerrar");


            switch (Console.ReadLine())
            {
                    case "1":
                    GerenciarVeiculosCarro(carro);   
                    break;

                    case "2" :
                    GerenciarVeiculosMoto(moto);
                    break;

                    case "3":
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

    static void GerenciarVeiculosCarro(Estacionamento_Carro carro)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar Veículo");
            Console.WriteLine("2. Listar Veículos");
            Console.WriteLine("3. Quantidade de Veículos");
            Console.WriteLine("4. Remover Veículo");
            Console.WriteLine("5. Voltar ao Menu Principal");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    carro.AdicionarVeiculo();
                    break;
                case "2":
                    carro.ListarVeiculos();
                    break;
                case "3":
                    carro.VerificarQuantosVeiculosTem();
                    break;
                case "4":
                    carro.RemoverVeiculo();
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }



        static void GerenciarVeiculosMoto(Estacionamento_Moto moto)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar Veículo");
            Console.WriteLine("2. Listar Veículos");
            Console.WriteLine("3. Quantidade de Veículos");
            Console.WriteLine("4. Remover Veículo");
            Console.WriteLine("5. Voltar ao Menu Principal");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    moto.AdicionarVeiculo();
                    break;
                case "2":
                    moto.ListarVeiculos();
                    break;
                case "3":
                    moto.VerificarQuantosVeiculosTem();
                    break;
                case "4":
                    moto.RemoverVeiculo();
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    
    }   
}