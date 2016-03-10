using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class SituacaoContrato
    {
        public int SituacaoContratoId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
