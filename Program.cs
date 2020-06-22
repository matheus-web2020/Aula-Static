using System;

namespace StaticPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

           Conversorcs.CotacaoDolar = 5.23f;
           Console.WriteLine("Valor de 200 Dólares convertido para Real é igual a");
           Console.WriteLine(Conversorcs.ConverterDolarParaReal(200) + "Reais");
           Console.ResetColor();
           Console.WriteLine("Valor de 200 reais convertido para Dólar é igual a:");
           Console.WriteLine(Conversorcs.ConverterRealParaDolar(200) + "Dólares");
           Conversorcs.CotacaoEuro = 5.90f;
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.WriteLine("Valor de 150 Euros convertidos para Real é igual a:");
           Console.WriteLine(Conversorcs.ConverterEuroParaReal(150) + "Reais");
           Console.ResetColor();
           Console.WriteLine("Valor de 150 Reais convertidos para Euro é igual a:");
           Console.WriteLine(Conversorcs.ConverterRealParaEuro(150) + "Euros");
        }
    }
}
