namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine("Veiculo adicionado!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                string horas = Console.ReadLine();
                int horas_=Convert.ToInt32(horas);
      
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                decimal valorTotal = 0;
                valorTotal = precoInicial + (precoPorHora * horas_);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int contador = 1;
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"Veículo {contador}: {item}");
                }                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
