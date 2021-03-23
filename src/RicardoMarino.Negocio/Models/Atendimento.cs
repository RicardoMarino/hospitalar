using System;
using System.Collections.Generic;
using System.Text;

namespace RicardoMarino.Negocio.Models
{
    public class Atendimento : Entidade
    {
        public Funcionario Funcionario { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Receituario> Receituarios { get; set; }
    }
}
