using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public class Estacionamento_Carro : IEstacionamento
    {

        private decimal precoInicialDoEstacionamento = 0; //Preço onde será cobrado so por estacionar no estacionamento.
        private decimal precoPorHoraNoEstacionamento = 0; //Preço das horas que permaneceu no estaionamento.
        private List<string> armazamentoDeCarrosEmLista = new List<string>(); 

        
        public Estacionamento_Carro (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicialDoEstacionamento = precoInicial;    
            this.precoPorHoraNoEstacionamento = precoPorHora;              
        }   


        public void AdicionarVeiculo()
        {
            if(armazamentoDeCarrosEmLista.Count < 10) //Limite do Estacionamento = 10.
            {

            Console.WriteLine();
            Console.WriteLine($"DIGITE A PLACA DO SEU CARRO PARA ESTACIONAR :"); 
            string? placaCarro = Console.ReadLine().ToUpper(); 

                if(!string.IsNullOrWhiteSpace(placaCarro))  
                {
                    //IMPORTANTE = Desenvolver funcionalidade para mostrar data e hora e não da problema quando for excluir veículo.
                    //armazamentoDeCarrosEmLista.Add(placaCarro + "|" + " Horário de Entrada = " + DateTime.Now.ToString("HH:mm dd/MM/yyyy"));

                    armazamentoDeCarrosEmLista.Add(placaCarro);
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
            if(armazamentoDeCarrosEmLista.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"OS CARROS ESTACIONADOS SÃO :");

                int posicaoDosCarros = 1;
                foreach(string nomeDaPlaca in armazamentoDeCarrosEmLista)
                {
                    Console.WriteLine($"{posicaoDosCarros}° CARRO = {nomeDaPlaca}");
                    posicaoDosCarros++;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NÃO HÁ VEÍCULOS ESTACIONADOS!");
                Console.WriteLine();
            }
            
        }


        public void VerificarQuantosVeiculosTem()
        {
            int totalCarros = armazamentoDeCarrosEmLista.Count;

            if(totalCarros > 1)
            {
                Console.WriteLine();
                Console.WriteLine($"TOTAL DE CARROS ESTACIONADOS :");
                Console.WriteLine($"{totalCarros} Carros estão no estacionamento.");
                Console.WriteLine();
            }
            else if(totalCarros == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"TOTAL DE CARROS ESTACIONADOS :");
                Console.WriteLine($"{totalCarros} Carro está no estacionamento.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NÃO HÁ VEÍCULOS ESTACIONADOS!");
                Console.WriteLine();
            }
            
        }



        public void RemoverVeiculo()
        {
            Console.WriteLine();
            Console.WriteLine("DIGITE A PLACA DO VEÍCULO PARA REMOVER :");

            string? removePlacaCarro = Console.ReadLine().ToUpper(); 
            string placaCarro = removePlacaCarro;

            if(armazamentoDeCarrosEmLista.Any(x => x.ToUpper() == placaCarro.ToUpper()))
            {
                Console.WriteLine();
                Console.WriteLine("DIGITE A QUANTIDADE DE HORAS QUE O VEÍCULO PERMANECEU ESTACIONADO :");

                int horas = Convert.ToInt32(Console.ReadLine());   
                decimal valorTotal = precoPorHoraNoEstacionamento * horas + precoInicialDoEstacionamento;

                armazamentoDeCarrosEmLista.Remove(placaCarro);
                Console.WriteLine();
                Console.WriteLine($"O VEÍCULO ({placaCarro}) FOI REMOVIDO E O PREÇO TOTAL FOI DE : R$ {valorTotal}");  
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

            if(armazamentoDeCarrosEmLista.Any())
            {
                Console.WriteLine();
                Console.WriteLine("CARROS ESTACIONADOS :");
                foreach(string listaDeCarros in armazamentoDeCarrosEmLista)
                {
                    Console.WriteLine($"- {listaDeCarros}");
                }

                Console.WriteLine();
                int totalCarros = 10 - armazamentoDeCarrosEmLista.Count;
                Console.WriteLine("TOTAL DE VAGAS = " + totalCarros);
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
            string? veiculoEncontrado = armazamentoDeCarrosEmLista.Find(v => v.Contains(placaDigitada)); 

            Console.WriteLine();
            if (veiculoEncontrado != null)
            {
                Console.WriteLine($"VEÍCULO ENCONTRADO : {veiculoEncontrado}");
            }
            else
            {
                Console.WriteLine($"CARRO COM PLACA {placaDigitada} NÃO ENCONTRADO.");
            }
            Console.WriteLine();
        }
    }
}