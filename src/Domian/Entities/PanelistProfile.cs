using Domian.Common;

namespace Domian.Entities
{
    public class PanelistProfile : IEntityBaseAuditable<Guid, Guid>
    {
        public Guid Id { get; set; }
        public Guid IdUser { get; set; }
        public Guid IdRol { get; set; }
        public ICollection<PanelistSkills> Skills { get; set; }
        public DateTime LastUpdateScheduled { get; set; }
        public string? ScheduleWeekly { get; set; }
        public DateTime ModifyDate { get; set; }
        public Guid ModifiedBy { get; set; }
        
        public bool State { get; set; }
        public Guid UserCreatorId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
