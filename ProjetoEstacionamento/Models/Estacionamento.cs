namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private decimal valorTotal;
        private decimal valorArrecadado = 0;


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {


            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;


        }

        public void AdicionarVeiculo()
        {


            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);


        }

        public void RemoverVeiculo()
        {


            Console.WriteLine("Digite a placa do veículo para remover:");


            string placa = Console.ReadLine();




            // Verifica se o veículo existe


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;


                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                valorArrecadado += valorTotal;
            }


            else


            {


                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            
            
            }


        }




        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {


                Console.WriteLine("Os veículos estacionados são:");


                int contadorForeach = 1;


                foreach (string placa in veiculos)


                {


                    Console.WriteLine($"Veículos estacionados {contadorForeach} - {placa}");
                    contadorForeach++;


                }
            }
            else
            {


                Console.WriteLine("Não há veículos estacionados.");


            }
        }


        //Valor total arrecadado por dia
        public void ValorDia()


        {


            Console.WriteLine($"O valor total do dia é R$ {valorArrecadado:F2}");


        }


    }
}