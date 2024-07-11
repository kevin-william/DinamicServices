using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaServicoDinamicoDomain.Interfaces
{
    public interface IService<TInput, TResult>
    {
        TResult Execute(TInput input);
    }
}
