﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaServicoDinamicoDomain.Entities.Request
{
    public class RequestExemploUm
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Guid Guid { get; set; }
    }
}
