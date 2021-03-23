using System.Collections.Generic;

namespace RicardoMarino.Negocio.Models
{
    public class Funcionario : Entidade
    {
        public string Nome { get; set; }
        public IEnumerable<Contato> Contatos { get; set; }
        public IEnumerable<Cargo> Cargos { get; set; }
    }
}
