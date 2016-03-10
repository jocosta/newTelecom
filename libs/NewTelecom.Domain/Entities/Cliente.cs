using System;
using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {
            ClienteId = new Guid().ToString();

        }

        public virtual string ClienteId { get; set; }
        public virtual string UsuarioId { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<Chamado> Chamados { get; set; } 

        public virtual Usuario Usuario { get; set; }
    }
}
