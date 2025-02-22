﻿using CamadaServicoDinamicoDomain.Entities.Request;
using CamadaServicoDinamicoDomain.Entities.Response;
using CamadaServicoDinamicoDomain.Implementations;
using System;


namespace CamadaServicoDinamicoConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var requestExemploUm = new RequestExemploUm
            {
                Descricao="desc",
                Guid = Guid.NewGuid(),
                Id = 1
            };
            var result = ExectadorGenericoDeServicos.ExecuteService<ServicoExemploUm, RequestExemploUm, ResponseExemploUm>(requestExemploUm);

            Console.WriteLine($"{result.DescricaoConteudo} {result.Conteudo}");
        }
    }
}
