using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTelecom.Domain.Entities;

namespace NewTelecom.Infra.Data.Configuration
{
    public class AtendimentoChamadoConfiguration : EntityTypeConfiguration<AtendimentoChamado>
    {
        public AtendimentoChamadoConfiguration()
        {
            HasKey(c => c.AtendimentoChamadoId);

            HasOptional(c => c.Chamado)
                .WithMany(c => c.AtendimentosChamado)
                .HasForeignKey(c => c.ChamadoId);

            ToTable("AtendimentoChamado");
        }
    }
}
