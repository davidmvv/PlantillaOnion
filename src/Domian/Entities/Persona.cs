
using ATOS.Resource.Common;
using Domian.Common;

namespace Domain.Entities
{
    public class Persona : IEntityBaseAuditable<Guid,Guid>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Guid Id { get ; set ; }
        public bool State { get; set; }
        public Guid IdUserCreator { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifyDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public Guid UserCreatorId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

