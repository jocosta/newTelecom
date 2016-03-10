using System.Data.Entity.ModelConfiguration;
using NewTelecom.Domain.Entities;

namespace NewTelecom.Infra.Data.Configuration
{
    public class ContratoConfiguration : EntityTypeConfiguration<Contrato>
    {
        public ContratoConfiguration()
        {

            HasKey(c => c.ContatoId);

            HasRequired(s => s.Cliente)
                   .WithMany(s => s.Contratos)
                   .HasForeignKey(s => s.ClienteId);

            HasRequired(c => c.SituacaoContrato)
                .WithMany(c => c.Contratos)
                .HasForeignKey(c => c.SituacaoContratoId);

            HasMany(s => s.Servicos)
                .WithMany(c => c.Contratos)
                .Map(cs =>
                {
                    cs.MapLeftKey("ContratoRefId");
                    cs.MapRightKey("ServicoRefId");
                    cs.ToTable("ContratoServico");
                });
        }
    }
}
