using CaixaEletronico.Domain;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Training_Tests.UnitTests
{
    public class FixturesTest : IClassFixture<IntegrationTestFixture>
    {
        private ICaixa _caixa;
        public FixturesTest(IntegrationTestFixture fixture)
        {
            _caixa = fixture.ServiceProvider.GetRequiredService<ICaixa>();
        }

        [Fact]
        public void SaqueContemMenorNumeroDeCedulas()
        {
            int quantidadeDeCedulas = 3;
            int valorDoSaque = 80;

            var resultadoCedulas = _caixa.Saque(valorDoSaque);

            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count);
        }
    }
}