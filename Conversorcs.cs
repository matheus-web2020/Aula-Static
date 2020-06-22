namespace StaticPOO
{
    public static class Conversorcs
    {

        public static float CotacaoDolar = 5.23f;

        public static float CotacaoEuro = 5.90f;

        public static float ConverterDolarParaReal(float valor){
             return valor * CotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valor){
            return valor / CotacaoDolar;
        }

        public static float ConverterEuroParaReal(float valor){
            return valor * CotacaoEuro;
        }
        public static float ConverterRealParaEuro(float valor){
            return valor / CotacaoEuro;
        }
        

    }
}