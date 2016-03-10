using System;

namespace NewTelecom.Domain.Entities
{
    public class AtendimentoChamado
    {
        public int AtendimentoChamadoId { get; set; }
        public string Observacao { get; set; }
        public DateTime DataAtendimento { get; set; } 

        public string ChamadoId { get; set; }
        public string UsuarioId { get; set; }


        public virtual Chamado Chamado { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
