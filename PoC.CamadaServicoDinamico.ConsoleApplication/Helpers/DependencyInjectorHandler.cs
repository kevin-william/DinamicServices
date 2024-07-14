using CamadaServicoDinamicoDomain.Implementations;
using CamadaServicoDinamicoDomain.Interfaces;
using CamadaServicoDinamicoInfraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace CamadaServicoDinamicoConsoleApplication.Helpers
{
    public static class DependencyInjectorHandler
    {
        public static ServiceProvider GetServiceProvider()
        {
            return GetServiceDescriptors().BuildServiceProvider();
        }

        public static ServiceCollection GetServiceDescriptors()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IExemploUmRepository, ExemploUmRepository>();
            serviceCollection.AddTransient<ServicoExemploUm>();

            return serviceCollection;
        }
    }
}
