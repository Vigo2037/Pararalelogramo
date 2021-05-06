using Paralelogramo;
using System;
using Xunit;

namespace xUnitTest
{
    public class UnitTest1
    {
        
        
        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(2, 6, 12)]
        [InlineData(3, 5, 15)]


        public void Test1(int b, int a, int resultadoteste)
        {
            int resultado;

            Operacao operacaoTeste = new Operacao();

            resultado = operacaoTeste.Multiplicacao(b, a);

            Assert.Equal(resultado, resultadoteste);

        }
    }
}
