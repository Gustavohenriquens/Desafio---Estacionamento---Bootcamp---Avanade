using projeto_estacionamento.Models;

public class Program
{
    private static void Main(string[] args)
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("SEJA BEM VINDO AO NOSSO SISTEMA DE ESTACIONAMENTO!\n\n" +
                          "DIGITE O PREÇO INICIAL :");
        precoInicial = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("DIGITE O PREÇO POR HORA :");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());


        //// ESTACIANDO CARRO ////
        Estacionamento_Carro carro = new Estacionamento_Carro(precoInicial, precoPorHora);

        //// ESTACIANDO MOTO ////  
        Estacionamento_Moto moto = new Estacionamento_Moto(precoInicial, precoPorHora);



        //// EXIBINDO O MENU INTERATIVO ////

        bool exibirMenu = true;
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("DIGITE A SUA OPÇÃO: \n");
            Console.WriteLine("1 - CARRO");
            Console.WriteLine("2 - MOTO");
            Console.WriteLine("3 - ENCERRAR");


            switch (Console.ReadLine())      
            {
                    case "1":
                    Console.WriteLine("----- VOCÊ ESTÁ NO ESTACIONAMENTO DE CARROS -----");
                    GerenciarVeiculosCarro(carro);
                    break;

                    case "2" :
                    Console.WriteLine("----- VOCÊ ESTÁ NO ESTACIONAMENTO DE MOTOS -----");
                    GerenciarVeiculosMoto(moto);
                    break;

                    case "3":
                    exibirMenu = false;
                    break;

                default:
                Console.WriteLine();
                    Console.WriteLine("OPÇÃO INVALIDA! TENTE NOVAMENTE!");
                    break;
            }           
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("O PROGRAMA SE ENCERROU!");
    
    }


    //// ESTACIONAMENTO DO CARRO ////

    static void GerenciarVeiculosCarro(Estacionamento_Carro carro)
    {
        while (true)
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO:");
            Console.WriteLine();
            Console.WriteLine("1 - ADICIONAR CARRO");
            Console.WriteLine("2 - LISTAR TODOS OS CARROS");
            Console.WriteLine("3 - QUANTIDADE DE CARROS");
            Console.WriteLine("4 - REMOVER CARRO");
            Console.WriteLine("5 - VERIFICAR QUANTAS VAGAS");
            Console.WriteLine("6 - VOLTAR AO MENU PRINCIPAL");

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
                    carro.VerificarSeExisteVaga();
                    break;
                case "6":
                    return; 
                default:
                    Console.WriteLine("OPÇÃO INVALIDA! TENTE NOVAMENTE!");
                    break;
            }
        }
    }


        //// ESTACIONAMENTO DA MOTO ////
        static void GerenciarVeiculosMoto(Estacionamento_Moto moto)
    {
        while (true)
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO:");
            Console.WriteLine();
            Console.WriteLine("1 - ADICIONAR MOTO");
            Console.WriteLine("2 - LISTAR TODAS AS MOTOS");
            Console.WriteLine("3 - QUANTIDADE DE MOTOS");
            Console.WriteLine("4 - REMOVER MOTO");
            Console.WriteLine("5 - VERIFICAR QUANTAS VAGAS");
            Console.WriteLine("6 - VOLTAR AO MENU PRINCIPAL");


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
                    moto.VerificarSeExisteVaga();
                    break;
                case "6":
                    return; 
                default:
                    Console.WriteLine("OPÇÃO INVALIDA! TENTE NOVAMENTE!.");
                    break;
            }
        }
    
    }   
}