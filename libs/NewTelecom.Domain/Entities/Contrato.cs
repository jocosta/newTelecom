using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class Contrato
    {
        public string ContatoId { get; set; }
        public string NumeroContrato { get; set; }

        public int ClienteId { get; set; }
        public int SituacaoContratoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual SituacaoContrato SituacaoContrato { get; set; }

        public virtual ICollection<Chamado> Chamados { get; set; }

        public virtual ICollection<Servico> Servicos { get; set; }

    }
}
