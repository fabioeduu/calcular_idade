using System;

namespace CalcularIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE IDADE ===");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Por favor, digite uma data válida.");
                        Console.WriteLine();
                        continue;
                    }

                    if (input.ToLower() == "sair")
                    {
                        break;
                    }

                    DateTime dataNascimento = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                    DateTime hoje = DateTime.Today;

                    if (dataNascimento > hoje)
                    {
                        Console.WriteLine("A data de nascimento não pode ser no futuro!");
                        Console.WriteLine();
                        continue;
                    }

                    int idade = CalcularIdade(dataNascimento, hoje);
                    int diasParaProximoAniversario = CalcularDiasParaProximoAniversario(dataNascimento, hoje);

                    Console.WriteLine();
                    Console.WriteLine($"📅 Data de nascimento: {dataNascimento:dd/MM/yyyy}");
                    Console.WriteLine($"🎂 Sua idade atual: {idade} anos");
                    Console.WriteLine($"🎉 Dias para o próximo aniversário: {diasParaProximoAniversario} dias");
                    Console.WriteLine();

                    Console.WriteLine("Digite 'sair' para encerrar ou pressione Enter para calcular outra idade...");
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de data inválido! Use o formato dd/MM/yyyy (ex: 15/03/1990)");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Obrigado por usar a Calculadora de Idade! 👋");
        }

        static int CalcularIdade(DateTime dataNascimento, DateTime dataAtual)
        {
            int idade = dataAtual.Year - dataNascimento.Year;

            // Verifica se ainda não fez aniversário este ano
            if (dataAtual.Month < dataNascimento.Month || 
                (dataAtual.Month == dataNascimento.Month && dataAtual.Day < dataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }

        static int CalcularDiasParaProximoAniversario(DateTime dataNascimento, DateTime dataAtual)
        {
            DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

            // Se o aniversário já passou este ano, considera o próximo ano
            if (proximoAniversario < dataAtual)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            return (proximoAniversario - dataAtual).Days;
        }
    }
}
