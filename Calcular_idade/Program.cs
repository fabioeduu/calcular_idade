using System;

namespace CalculaIdadeCNH
{
    // Struct para armazenar os dados da pessoa
    struct Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;

        // Aqui para calcular a idade com base na data atual
        public int CalcularIdade()
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - DataNascimento.Year;

            //Aqui para verifica se a pessoa ainda não fez aniversário neste ano
            if (DataNascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            return idade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            // Entrada de dados
            Console.WriteLine("Digite seu nome completo:");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa):");
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

            // Processamento

            int idade = pessoa.CalcularIdade();

            // Saída
            Console.WriteLine($"\nOlá {pessoa.Nome}!");
            Console.WriteLine($"Você tem {idade} anos.");

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade e pode tirar a carteira de habilitação.");
            }
            else
            {
                Console.WriteLine("Você ainda é menor de idade e não pode tirar a carteira de habilitação.");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
