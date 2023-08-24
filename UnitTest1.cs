using System.Collections.Generic;
using Xunit;

namespace CaixaEletronico.Domain.Tests
{
    public class CaixaTests
    {
        [Fact]
        public void TesteSaqueValorValido()
        {
            // Arrange
            var caixa = new Caixa();
            var valorSaque = 150;

            // Act
            var cedulasSacadas = caixa.Saque(valorSaque);

            // Assert
            Assert.NotNull(cedulasSacadas);
            Assert.NotEmpty(cedulasSacadas);
            Assert.Equal(2, cedulasSacadas.Count); // Deve ser 3 cédulas de R$50
        }

        // [Fact]
        // public void TesteSaqueValorInvalido()
        // {
        //     // Arrange
        //     var caixa = new Caixa();
        //     var valorSaque = 37;

        //     // Act & Assert
        //     Assert.Throws<System.Exception>(() => caixa.Saque(valorSaque));
        // }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void TesteValidaCedulasDisponiveis(int valor)
        {
            // Arrange
            var caixa = new Caixa();

            // Act
            var resultado = caixa.ValidaCedulasDisponiveis(valor);

            // Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(25)]
        [InlineData(35)]
        public void TesteInvalidaCedulasDisponiveis(int valor)
        {
            // Arrange
            var caixa = new Caixa();

            // Act
            var resultado = caixa.ValidaCedulasDisponiveis(valor);

            // Assert
            Assert.False(resultado);
        }
    }
}
