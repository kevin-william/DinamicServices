using CamadaServicoDinamicoDomain.Interfaces;

namespace CamadaServicoDinamicoDomain.Implementations
{
    public static class ExectadorGenericoDeServicos
    {
        public static TResult ExecuteService<TService, TInput, TResult>(TInput parametros)
            where TService : IService<TInput, TResult>, new()
        {
            var servico = new TService();
            return servico.Execute(parametros);
        }
    }
}
