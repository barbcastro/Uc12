using Projeto_Teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteMSteste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange- Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        //Arrange
        [DataTestMethod]
        [DataRow(1,2,3)]
        [DataRow(2,2,4)]
        [DataRow(2,1,2)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}