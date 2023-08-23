using CaixaEletronico.Domain;
using Moq;
using NSubstitute;
using Xunit;

namespace Training_Tests.UnitTests
{
    public class MoqTests
    {
        [Fact(DisplayName ="Mock saque com sucesso NSubstitute")]
        public void Saque_Com_Sucesso_NSUb()
        {
            var caixa = Substitute.For<ICaixa>();//cria objeto mock
            int valorDoSaque = 50;
            caixa.Saque(valorDoSaque).Returns(new int[] { });//efetua simulação de saque e assegura que retorno é int de array
            caixa.Received(1);//confirma que método foi executado uma unica vez
        }

        [Fact(DisplayName = "Mock saque com sucesso Moq")]
        public void Saque_Com_Sucesso_Moq()
        {
            var caixa = new Mock<ICaixa>();//cria objeto mock
            int valorDoSaque = 50;
            caixa.Object.Saque(valorDoSaque);//efetua simulação de saque
            caixa.Verify(r => r.Saque(valorDoSaque),Times.Once);//confirma que método foi executado uma unica vez
        }
    }
}