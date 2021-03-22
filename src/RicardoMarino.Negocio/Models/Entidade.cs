using System;

namespace RicardoMarino.Negocio.Models
{
    /// <summary>
    /// Base para as entidades de negócio
    /// </summary>
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
