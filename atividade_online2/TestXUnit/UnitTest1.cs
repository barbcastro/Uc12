using Projeto_Teste;
using Microsoft.VisualStudio


namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }

        //Arrange
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(2,3,4)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - verificação
            Assert.Equal(rNum, resultado);
        }
    }
}