
  
namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sessao = -1;
            string[] operacoes = new string[100];
            while (true)
            {
                sessao++;
                Console.Clear();


                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Calculadora Tabajara Academia do Programador 2025");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico das operações");
                Console.WriteLine("S - Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "S")
                {
                    break;
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("--------------------------------------");

                    Console.Write("Digite o número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;

                        Console.WriteLine($"{numeroTabuada} x {contador}  = {resultadoTabuada}");
                        operacoes[sessao] = $"Tabuada do: {numeroTabuada}";
                    }

                    Console.ReadLine();
                    continue;
                }
                else if (opcao == "6")

                    Console.WriteLine("______________________________");
                Console.WriteLine("Histórico das operações");
                Console.WriteLine("______________________________");

                {
                    for (int contador = 0; contador < 101; contador++)
                    {
                        if (operacoes.Length < contador)

                            if (contador == null)

                                Console.WriteLine(operacoes[contador]);
                    }
                    {

                    }
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                string primerioNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primerioNumeroString);

                Console.Write("Digite o segundo número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                decimal resultado = default;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                }
                else if (opcao == "4")
                {
                    //if (segundoNumero != 0)
                    //{
                    //    resultado = primeiroNumero / segundoNumero;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Não é possível dividir um número por zero.");
                    //    Console.ReadKey();
                    //    continue;
                    //}
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir um número por zero.");
                        Console.ReadKey();
                        continue;
                    }
                    resultado = primeiroNumero / segundoNumero;
                    operacoes[sessao] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Deseja continuar (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}