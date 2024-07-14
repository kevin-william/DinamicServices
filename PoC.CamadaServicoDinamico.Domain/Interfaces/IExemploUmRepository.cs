using CamadaServicoDinamicoDomain.Entities.Response;

namespace CamadaServicoDinamicoDomain.Interfaces
{
    public interface IExemploUmRepository
    {
        ResponseExemploUm ObterExemploUm(int id);
    }
}
