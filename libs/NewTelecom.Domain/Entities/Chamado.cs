using System;
using System.Collections.Generic;

namespace NewTelecom.Domain.Entities
{
    public class Chamado
    {
        public Chamado()
        {
            ChamadoId = new Guid().ToString();
        }

        public string ChamadoId { get; set; }
        public string Protocolo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public int StatusChamadoId { get; set; }
        public string ClienteId { get; set; }
        public string ContratoId { get; set; }
        public int CriticidadeChamadoId { get; set; }
        

        public virtual StatusChamado Status { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Contrato Contrato { get; set; }
        public virtual CriticidadeChamado CriticidadeChamado{get; set; }

        public virtual ICollection<AtendimentoChamado> AtendimentosChamado { get; set; } 
    }
}
