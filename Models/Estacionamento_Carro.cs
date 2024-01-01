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

        private List<string> veiculoCarro = new List<string>(); 



        public Estacionamento_Carro (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;    
            this.precoPorHora = precoPorHora;              
        }   
        public void AdicionarVeiculo()
        {
            Console.WriteLine($"Digite a placa do seu Carro para estacionar:"); 
            string placaCarro = Console.ReadLine().ToUpper();
            veiculoCarro.Add(placaCarro);
            
        }

        public void ListarVeiculos()
        {
            if(veiculoCarro.Any())
            {
                Console.WriteLine($"Os Carros estacionados são:");

                foreach(string item in veiculoCarro)
                {
                    Console.WriteLine($"Carro = {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            
        }


        public void VerificarQuantosVeiculosTem()
        {
            int totalCarros = veiculoCarro.Count;

            if(totalCarros >= 1)
            {
                Console.WriteLine($"Total de carros estacionados:");
                Console.WriteLine($"{totalCarros} Carros estão no estacionamento.");
            }
            else if(totalCarros == 1)
            {
                Console.WriteLine($"Total de carros estacionados:");
                Console.WriteLine($"{totalCarros} Carro está no estacionamento.");
            }
            else
            {
                Console.WriteLine("Não há carros estacionados.");
            }
            
        }



        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string removePlacaCarro = Console.ReadLine().ToUpper(); 
            string placaCarro = removePlacaCarro;

            if(veiculoCarro.Any(x => x.ToUpper() == placaCarro.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());   
                decimal valorTotal = precoPorHora * horas + precoInicial;

                veiculoCarro.Remove(placaCarro);
                Console.WriteLine($"O veículo {placaCarro} foi removido e o preço total foi de: R$ {valorTotal}");  
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }
        
    }
}