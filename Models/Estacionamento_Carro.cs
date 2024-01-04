using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public class Estacionamento_Carro : IEstacionamento
    {

        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private string Placa {get; set;} 
       
        private List<string> veiculoCarro = new List<string>(); 
        
        public Estacionamento_Carro (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;    
            this.precoPorHora = precoPorHora;              
        }   


        public void AdicionarVeiculo()
        {
            if(veiculoCarro.Count < 10)
            {

            Console.WriteLine();
            Console.WriteLine($"DIGITE A PLACA DO SEU CARRO PARA ESTACIONAR :"); 
            string placaCarro = Console.ReadLine().ToUpper();
            veiculoCarro.Add(placaCarro + "|" + " Horário de Entrada = " + DateTime.Now.ToString("HH:mm dd/MM/yyyy"));
            Console.WriteLine();   

            }
            else
            {
                Console.WriteLine("NÃO POSSUI MAIS VAGAS! VAGAS PREENCHIDAS!" +
                $" APERTE (5) PARA VERIFICAR AS VAGAS");
            }
            
        }

        public void ListarVeiculos()
        {
            if(veiculoCarro.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"OS CARROS ESTACIONADOS SÃO :");

                int cont = 1;
                foreach(string item in veiculoCarro)
                {
                    Console.WriteLine($"{cont}° CARRO = {item} ");
                    cont++;
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
            int totalCarros = veiculoCarro.Count;

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

            string removePlacaCarro = Console.ReadLine().ToUpper(); 
            string placaCarro = removePlacaCarro;

            if(veiculoCarro.Any(x => x.ToUpper() == placaCarro.ToUpper()))
            {
                Console.WriteLine();
                Console.WriteLine("DIGITE A QUANTIDADE DE HORAS QUE O VEÍCULO PERMANECEU ESTACIONADO :");

                int horas = Convert.ToInt32(Console.ReadLine());   
                decimal valorTotal = precoPorHora * horas + precoInicial;

                veiculoCarro.Remove(placaCarro);
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

            if(veiculoCarro.Any())
            {
                Console.WriteLine();
                Console.WriteLine("CARROS ESTACIONADOS :");
                foreach(string item in veiculoCarro)
                {
                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine();
                int totalCarros = 10 - veiculoCarro.Count ;
                Console.WriteLine("TOTAL DE VAGAS = " + totalCarros);
            }

        }

        public void BuscarVeiculoPorPlaca()
        {
            Console.WriteLine();
            Console.WriteLine("PROCURE SEU VEÍCULO CADASTRADO COM A PLACA : ");
            string placaDigitada = Console.ReadLine().ToUpper();
            string veiculoEncontrado = veiculoCarro.Find(v => v.Contains(placaDigitada));

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