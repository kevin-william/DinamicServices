using CamadaServicoDinamicoDomain.Entities.Request;
using CamadaServicoDinamicoDomain.Entities.Response;
using CamadaServicoDinamicoDomain.Interfaces;

namespace CamadaServicoDinamicoDomain.Implementations
{
    public class ServicoExemploUm : IService<RequestExemploUm, ResponseExemploUm>
    {

        public IExemploUmRepository _exemploUmRepository { get; set; }

        public ServicoExemploUm(IExemploUmRepository exemploUmRepository)
        {
            _exemploUmRepository = exemploUmRepository
                ?? throw new ArgumentNullException(nameof(exemploUmRepository));
        }

        public ResponseExemploUm Execute(RequestExemploUm input)
        {
            //Do your business here.

            //retornando qualquer coisa só para exemplo/teste
            return _exemploUmRepository.ObterExemploUm(1);
        }
    }
}
