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
            if(veiculoMoto.Count < 10)
            {

            Console.WriteLine();
            Console.WriteLine($"DIGITE A PLACA DA SUA MOTO PARA ESTACIONAR :"); 
            string placaMoto = Console.ReadLine().ToUpper();
            veiculoMoto.Add(placaMoto + "|" + " Horário de Entrada = " + DateTime.Now.ToString("HH:mm dd/MM/yyyy"));
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
            if(veiculoMoto.Any())
            {
                Console.WriteLine();
                Console.WriteLine($"AS MOTOS ESTACIONADAS SÃO :");


                int cont = 1;
                foreach (string item in veiculoMoto)
                {
                    Console.WriteLine($"MOTO = {item}");
                    cont++;
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
            int totalMotos = veiculoMoto.Count;

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
            

            if (veiculoMoto.Any(x => x.ToUpper() == placaMoto.ToUpper()))
            {
                Console.WriteLine();
                Console.WriteLine("DIGITE A QUANTIDADE DE HORAS QUE O VEÍCULO PERMANECEU ESTACIONADO :");


                int horas = Convert.ToInt32(Console.ReadLine());    
                decimal valorTotal = precoPorHora * horas + precoInicial ;  

                veiculoMoto.Remove(placaMoto);
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
            if(veiculoMoto.Any())
            {
                Console.WriteLine();
                Console.WriteLine("CARROS ESTACIONADOS :");
                foreach(string item in veiculoMoto)
                {
                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine();
                int totalMotos = 10 - veiculoMoto.Count ;
                Console.WriteLine("TOTAL DE VAGAS = " + totalMotos);
            }
        }

        public void BuscarVeiculoPorPlaca()
        {  
             Console.WriteLine();
            Console.WriteLine("PROCURE SEU VEÍCULO CADASTRADO COM A PLACA : ");
            string placaDigitada = Console.ReadLine().ToUpper();
            string veiculoEncontrado = veiculoMoto.Find(v => v.Contains(placaDigitada));

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