using System;

namespace NewTelecom.Domain.Entities
{
    public abstract class BaseEntity
    {
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
