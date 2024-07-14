using CamadaServicoDinamicoDomain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CamadaServicoDinamicoDomain.Implementations
{
    public class ExectadorGenericoDeServicos
    {
        private readonly IServiceProvider _serviceProvider;

        public ExectadorGenericoDeServicos(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider
                    ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public TResult ExecuteService<TService, TInput, TResult>(TInput parametros)
            where TService : IService<TInput, TResult>
        {
            var servico = _serviceProvider.GetRequiredService<TService>();
            return servico.Execute(parametros);
        }
    }
}
