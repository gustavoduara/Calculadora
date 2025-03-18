namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {

        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;

        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero + segundoNumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

        public static string[] GerarTabuada(int numeroTabuada)
        {
            string[] LinhasTabuada = new string[10];

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                LinhasTabuada[contador - 1] = ($"{numeroTabuada} x {contador} = {resultadoTabuada}");
            }

            return LinhasTabuada;
        }


        public static string[] ObterHistoricoOperacoes()
        {
            return historicoOperacoes;
        }
    }
}
