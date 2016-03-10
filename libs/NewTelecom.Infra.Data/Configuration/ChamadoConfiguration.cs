using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTelecom.Domain.Entities;

namespace NewTelecom.Infra.Data.Configuration
{
    public class ChamadoConfiguration : EntityTypeConfiguration<Chamado>
    {
        public ChamadoConfiguration()
        {
            HasKey(c => c.ChamadoId);

            Property(c => c.DataAbertura)
                .HasColumnType("Datetime2");

            Property(c => c.DataEncerramento)
                .HasColumnType("Datetime2");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(500);
                

            Property(c => c.Titulo)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(s => s.Status)
                .WithMany(s => s.Chamados)
                .HasForeignKey(s => s.StatusChamadoId);

            HasRequired(s => s.Cliente)
                .WithMany(s => s.Chamados)
                .HasForeignKey(s => s.ClienteId);

            HasRequired(s => s.Contrato)
                .WithMany(s => s.Chamados)
                .HasForeignKey(s => s.ContratoId);

            HasRequired(s => s.CriticidadeChamado)
                .WithMany(s => s.Chamados)
                .HasForeignKey(s => s.CriticidadeChamado);
            
            ToTable("Chamado");
        }
    }
}
