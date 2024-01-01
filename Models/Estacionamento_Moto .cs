using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public class Estacionamento_Moto : IEstacionamento
    {

         private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> veiculoMoto= new List<string>(); 



        public Estacionamento_Moto(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine($"Digite a placa da sua Moto para estacionar:"); 
            string placaMoto = Console.ReadLine().ToUpper();
            veiculoMoto.Add(placaMoto);
        }


        public void ListarVeiculos()
        {
            if(veiculoMoto.Any())
            {
                Console.WriteLine($"As Motos estacionadas são:");

                foreach (string item in veiculoMoto)
                {
                    Console.WriteLine($"Moto = {item}");
                }
            }
            else
            {
                 Console.WriteLine("Não há veículos estacionados.");
            }
        }


                public void VerificarQuantosVeiculosTem()
        {
            int totalMotos = veiculoMoto.Count;

            if(totalMotos > 1)
            {
                Console.WriteLine($"Total de motos estacionadas:");
                Console.WriteLine($"{totalMotos} Motos estão no estacionamento.");
            }
            else if(totalMotos == 1)
            {
                Console.WriteLine($"Total de motos estacionadas:");
                Console.WriteLine($"{totalMotos} Moto está no estacionamento.");
            }
            else
            {
                Console.WriteLine("Não há motos estacionadas.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string removePlacaMoto = Console.ReadLine().ToUpper();
            string placaMoto = removePlacaMoto;
            

            if (veiculoMoto.Any(x => x.ToUpper() == placaMoto.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int horas = Convert.ToInt32(Console.ReadLine());    
                decimal valorTotal = precoPorHora * horas + precoInicial ;  

                veiculoMoto.Remove(placaMoto);
                Console.WriteLine($"O veículo {placaMoto} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        
    }
}