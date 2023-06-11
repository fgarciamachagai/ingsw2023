using ingsw2023.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingsw2023.test
{
    public class SumadorShould
    {

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(1, 1, 2)]
        [InlineData(4, 6, 10)]

        public void SumarNumerosShould(int primerSumando, int segundoSumando, int resulEsperado)
        {
            //Arrange
            Sumador sumador = new Sumador();

            //Act
            int resulSuma = sumador.SumarNumeros(primerSumando, segundoSumando);

            //Assert
            Assert.Equal(resulEsperado, resulSuma);
        }
    }
}
