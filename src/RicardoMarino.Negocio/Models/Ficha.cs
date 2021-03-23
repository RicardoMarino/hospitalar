using System;
using System.Collections.Generic;
using System.Text;

namespace RicardoMarino.Negocio.Models
{
    public class Ficha : Entidade
    {
        public Cliente Cliente { get; set; }
        public IEnumerable<Atendimento> Atendimentos { get; set; }

    }
}
