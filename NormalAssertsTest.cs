using CaixaEletronico.Domain;
using System;
using Xunit;

namespace Training_Tests.UnitTests
{
    public class NormalAssertsTest
    {
        private readonly Caixa caixa = new Caixa();
        
        [Fact]
        public void Saque_Valido()
        {
            int valorDoSaque = 510;
            bool saqueEhValido = caixa.ValidaCedulasDisponiveis(valorDoSaque);            
            Assert.True(saqueEhValido);//verifica se resultado esperado é verdadeiro
        }

        [Fact]
        public void Deve_Gerar_Excecao()
        {
            int valorDoSaque = 5;
            Assert.Throws<Exception>(() => caixa.Saque(valorDoSaque));//verifica se método lança exceção
        }    
    }
}