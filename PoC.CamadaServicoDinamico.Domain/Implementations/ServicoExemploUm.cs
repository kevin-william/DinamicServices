using CamadaServicoDinamicoDomain.Entities.Request;
using CamadaServicoDinamicoDomain.Entities.Response;
using CamadaServicoDinamicoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaServicoDinamicoDomain.Implementations
{
    public class ServicoExemploUm : IService<RequestExemploUm, ResponseExemploUm>
    {
        public ResponseExemploUm Execute(RequestExemploUm input)
        {
            //Do your business here.

            //retornando qualquer coisa só para exemplo/teste
            return new ResponseExemploUm
            {
                Conteudo = input.Guid.ToString(),
                DescricaoConteudo = input.Descricao
            };
        }
    }
}
