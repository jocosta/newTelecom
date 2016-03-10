using System.ComponentModel;

namespace NewTelecom.Infra.CrossCutting.Identity.Model
{
    public class PacienteViewModel
    {
        public string Id { get; set; }
        [DisplayName("E-mail")]
        public virtual string Email { get; set; }
        [DisplayName("Telefone")]
        public virtual string PhoneNumber { get; set; }
        [DisplayName("Nome")]
        public virtual string Name { get; set; }

    }
}
