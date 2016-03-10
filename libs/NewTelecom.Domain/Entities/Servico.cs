using System;
using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class Servico : BaseEntity
    {
        public int ServicoId { get; set; }
        public string Descricao { get; set; }
        public string Detalhe { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFimVigencia { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }

        internal bool IsVigente()
        {
            return DataInicioVigencia <= DateTime.Now && DataFimVigencia >= DateTime.Now;   
        }
    }
}
