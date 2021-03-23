namespace RicardoMarino.Negocio.Models
{
    public class Receituario : Entidade
    {
        public string Posologia { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}
