using System;
using Xunit;

namespace Paralelogramo_Text.xUnit
{
    [Test]



    public class TesteMultiplicaco1(int b, int a, int resultadoteste)
    {

        [Fact]
        public void Test1()
        {
            int resultado;

            Operecao OperecaoTeste = new Operacao();

            resultado = OperacaoTeste.Multiplicacao(b, a);

            Assert.AreEqual(resultado, resultadoteste);
        }

    }
}
