namespace CamadaServicoDinamicoDomain.Interfaces
{
    public interface IService<TInput, TResult>
    {
        TResult Execute(TInput input);
    }
}
