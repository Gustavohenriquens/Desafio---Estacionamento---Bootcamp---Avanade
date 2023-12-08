using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private List<string> veiculosMoto = new List<string>();
        
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AdicionarVeiculoCarro()
        {       
            Console.WriteLine($"Digite a placa do seu Carro para estacionar:");
            string placaCarro = Console.ReadLine().ToUpper();
            veiculos.Add(placaCarro);
        }

        public void AdicionarVeiculoMoto()
        {       
            Console.WriteLine($"Digite a placa da sua Moto para estacionar:");
            string placaMoto = Console.ReadLine().ToUpper();
            veiculosMoto.Add(placaMoto);
        }



        public void RemoverVeiculoCarro()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string removePlacaCarro = Console.ReadLine().ToUpper();
            string placaCarro = removePlacaCarro;
            

            if (veiculos.Any(x => x.ToUpper() == placaCarro.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int horas = Convert.ToInt32(Console.ReadLine());    
                decimal valorTotal = precoPorHora * horas + precoInicial ;  

                veiculos.Remove(placaCarro);
                Console.WriteLine($"O veículo {placaCarro} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }



        public void RemoverVeiculoMoto()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string removePlacaMoto = Console.ReadLine().ToUpper();
            string placaMoto = removePlacaMoto;
            

            if (veiculosMoto.Any(x => x.ToUpper() == placaMoto.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int horas = Convert.ToInt32(Console.ReadLine());    
                decimal valorTotal = precoPorHora * horas + precoInicial ;  

                veiculosMoto.Remove(placaMoto);
                Console.WriteLine($"O veículo {placaMoto} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }










        public void ListarVeiculosCarro()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados = OK 
                // *IMPLEMENTE AQUI* = OK

                foreach (string item in veiculos)
                {
                    Console.WriteLine($"Carro = {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


        public void ListarVeiculosMoto()
        {
            // Verifica se há veículos no estacionamento
            if (veiculosMoto.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados = OK 
                // *IMPLEMENTE AQUI* = OK

                foreach (string item in veiculosMoto)
                {
                    Console.WriteLine($"Moto = {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }



        public void ListarTodos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculosMoto.Any() || veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados = OK 
                // *IMPLEMENTE AQUI* = OK

                foreach (string itemMoto in veiculosMoto)
                {
                    Console.WriteLine($"Moto = {itemMoto}");
                }

                foreach (string itemCarro in veiculos)
                {
                    Console.WriteLine($"Carro = {itemCarro}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        
    }
}