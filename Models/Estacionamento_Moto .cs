using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public class Estacionamento_Moto : IEstacionamento
    {

        private decimal precoInicialDoEstacionamento = 0;
        private decimal precoPorHoraNoEstacionamento = 0;

        private List<string> armazamentoDeMotosEmLista = new List<string>(); 


        public Estacionamento_Moto(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicialDoEstacionamento = precoInicial;
            this.precoPorHoraNoEstacionamento = precoPorHora;
        }

        
        public void AdicionarVeiculo()
        {
            if(armazamentoDeMotosEmLista.Count < 10) //Limite do Estacionamento = 10.
            {

            Console.WriteLine();
            Console.WriteLine($"DIGITE A PLACA DA SUA MOTO PARA ESTACIONAR :"); 
            string? placaMoto = Console.ReadLine().ToUpper();


                if(!string.IsNullOrWhiteSpace(placaMoto))
                {
                    //IMPORTANTE = Desenvolver funcionalidade para mostrar data e hora e não da problema quando for excluir veículo.
                    //armazamentoDeMotosEmLista.Add(placaMoto + "|" + " Horário de Entrada = " + DateTime.Now.ToString("HH:mm dd/MM/yyyy"));

                    armazamentoDeMotosEmLista.Add(placaMoto);
                    Console.WriteLine(); 
                }
                else
                {
                    Console.WriteLine("PLACA INVÁLIDA! A PLACA NÃO PODE ESTÁ VAZIA. ADCIONE UMA PLACA VÁLIDA.");
                }
            }
            else
            {
                Console.WriteLine("NÃO POSSUI MAIS VAGAS! VAGAS PREENCHIDAS!" +
                $" APERTE (5) PARA VERIFICAR AS VAGAS");
            }
        }


        public void ListarVeiculos()
        {
            if(armazamentoDeMotosEmLista.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"AS MOTOS ESTACIONADAS SÃO :");


                int posicaoDasMotos = 1;
                foreach (string nomeDaPlaca in armazamentoDeMotosEmLista)
                {
                    Console.WriteLine($"{posicaoDasMotos}° MOTO = {nomeDaPlaca}");
                    posicaoDasMotos++;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NÃO HÁ MOTOS ESTACIONADAS!");
                Console.WriteLine();
            }
        }


        public void VerificarQuantosVeiculosTem()
        {
            int totalMotos = armazamentoDeMotosEmLista.Count;

            if(totalMotos > 1)
            {
                Console.WriteLine();
                Console.WriteLine($"TOTAL DE MOTOS ESTACIONADAS :");
                Console.WriteLine($"{totalMotos} Motos estão no estacionamento.");
                Console.WriteLine();
            }
            else if(totalMotos == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"TOTAL DE MOTOS ESTACIONADAS :");
                Console.WriteLine($"{totalMotos} Moto está no estacionamento.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NÃO HÁ MOTOS ESTACIONADAS!");
                Console.WriteLine();
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine();
            Console.WriteLine("DIGITE A PLACA DO VEÍCULO PARA REMOVER :");

            string removePlacaMoto = Console.ReadLine().ToUpper();
            string placaMoto = removePlacaMoto;
            

            if (armazamentoDeMotosEmLista.Any(x => x.ToUpper() == placaMoto.ToUpper()))
            {
                Console.WriteLine();
                Console.WriteLine("DIGITE A QUANTIDADE DE HORAS QUE O VEÍCULO PERMANECEU ESTACIONADO :");


                int horas = Convert.ToInt32(Console.ReadLine());    
                decimal valorTotal = precoPorHoraNoEstacionamento * horas + precoInicialDoEstacionamento;  

                armazamentoDeMotosEmLista.Remove(placaMoto);
                Console.WriteLine();
                Console.WriteLine($"O VEÍCULO {placaMoto} FOI REMOVIDO E O PREÇO TOTAL FOI DE : R$ {valorTotal}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("DESCULPE, ESSE VEÍCULO NÃO ESTÁ ESTACIONADO AQUI! CONFIRA SE DIGITOU A PLACA CORRETAMENTE.");
                Console.WriteLine();
            }
        }

        public void VerificarSeExisteVaga()
        {
            if(armazamentoDeMotosEmLista.Any())
            {
                Console.WriteLine();
                Console.WriteLine("CARROS ESTACIONADOS :");
                foreach(string listaDeMotos in armazamentoDeMotosEmLista)
                {
                    Console.WriteLine($"- {listaDeMotos}");
                }

                Console.WriteLine();
                int totalMotos = 10 - armazamentoDeMotosEmLista.Count;   
                Console.WriteLine("TOTAL DE VAGAS = " + totalMotos);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("TOTAL DE VAGAS = 10 VAGAS ");
            }
        }

        public void BuscarVeiculoPorPlaca()
        {  
             Console.WriteLine();
            Console.WriteLine("PROCURE SEU VEÍCULO CADASTRADO COM A PLACA : ");
            string? placaDigitada = Console.ReadLine().ToUpper();
            string? veiculoEncontrado = armazamentoDeMotosEmLista.Find(v => v.Contains(placaDigitada));

            Console.WriteLine();
            if (veiculoEncontrado != null)
            {
                Console.WriteLine($"VEÍCULO ENCONTRADO : {veiculoEncontrado}");
            }
            else
            {
                Console.WriteLine($"MOTO COM PLACA {placaDigitada} NÃO ENCONTRADO.");
            }
            Console.WriteLine();
            
        }
    }
}