using System.Collections.Generic;

namespace RicardoMarino.Negocio.Models
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public IEnumerable<Contato> Contatos { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }

        public IEnumerable<Cliente> Responsaveis { get; set; }
    }
}
