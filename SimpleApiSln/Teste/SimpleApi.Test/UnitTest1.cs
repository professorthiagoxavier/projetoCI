using Xunit;
using SimpleApi.Controllers;
using System.Linq;

namespace SimpleApi.Test
{
    public class UnitTest1
    {

        ValuesController _controller = new ValuesController();

        [Fact]
        public void RetornarValores()
        {
            var returnValue = _controller.Get().Value.ToList();
            Assert.True(returnValue.Count > 0);
            
        }

        [Fact]
        public void RetornarValorPeloId()
        {
            var retorno = _controller.Get(1);
            Assert.Equal(retorno.Value, "thiago");
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
