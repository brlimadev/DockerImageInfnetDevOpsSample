using DockerImageInfnetDevOpsSample.Controllers;
using System.Linq;

namespace Teste
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();
            var result = controller.Get();
            Assert.True(result.Any());

        }

       
    }
}