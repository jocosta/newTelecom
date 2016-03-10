using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class CriticidadeChamado
    {
        public int CriticidadeId { get; set; }
        public string Descricao { get; set; }
        public string CorHexadecimal { get; set; }
                                                                   
        public virtual ICollection<Chamado> Chamados { get; set; } 
    }
}
