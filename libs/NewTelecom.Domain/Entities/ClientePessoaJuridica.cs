namespace NewTelecom.Domain.Entities
{
    public class ClientePessoaJuridica : Cliente
    {
        public virtual string Cnpj { get; set; }
        public virtual string InscricaoEstadual { get; set; }
        public virtual string InscricaoMunicipal { get; set; }
    }
}
