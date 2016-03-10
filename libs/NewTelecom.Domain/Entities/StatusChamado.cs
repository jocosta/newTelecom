using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class StatusChamado
    {
        public int StatusChamadoId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Chamado> Chamados { get; set; } 
    }
}
