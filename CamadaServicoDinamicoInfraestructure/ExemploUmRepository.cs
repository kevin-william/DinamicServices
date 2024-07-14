using CamadaServicoDinamicoDomain.Entities.Response;
using CamadaServicoDinamicoDomain.Interfaces;

namespace CamadaServicoDinamicoInfraestructure
{
    public class ExemploUmRepository: IExemploUmRepository
    {
        ResponseExemploUm IExemploUmRepository.ObterExemploUm(int id)
        {
            return new ResponseExemploUm
                {
                    Conteudo = $"conteudo Teste com id:{id}",
                    DescricaoConteudo="descricao teste"
                };
        }
    }
}
