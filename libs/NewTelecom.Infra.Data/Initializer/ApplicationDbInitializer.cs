using System;
using System.Collections.Generic;
using System.Data.Entity;
using NewTelecom.Domain.Entities;

namespace NewTelecom.Infra.Data.Initializer
{
    public class ApplicationDbInitializer : DropCreateDatabaseAlways<Context.AppContext>
    {
        protected override void Seed(Context.AppContext context)
        {
            IList<StatusChamado> defaultStatusChamado = new List<StatusChamado>();

            defaultStatusChamado.Add(new StatusChamado() { Descricao = "Aguardando Atendimento" });
            defaultStatusChamado.Add(new StatusChamado() { Descricao = "Em Andamento" });
            defaultStatusChamado.Add(new StatusChamado() { Descricao = "Cancelado" });
            defaultStatusChamado.Add(new StatusChamado() { Descricao = "Encerrado" });
            defaultStatusChamado.Add(new StatusChamado() { Descricao = "Suspenso" });

            foreach (var std in defaultStatusChamado)
                context.StatusChamados.Add(std);

            IList<SituacaoContrato> defaultSituacaoContrato = new List<SituacaoContrato>();

            defaultSituacaoContrato.Add(new SituacaoContrato() { Descricao = "Ativo" });
            defaultSituacaoContrato.Add(new SituacaoContrato() { Descricao = "Encerrado" });
            defaultSituacaoContrato.Add(new SituacaoContrato() { Descricao = "Suspenso" });

            foreach (var std in defaultSituacaoContrato)
                context.SituacoesContratos.Add(std);

            base.Seed(context);
        }
    }
}
