using Domian.Common;

namespace Domian.Entities
{
    public class PanelistSkills : IEntityBaseAuditable<Guid, Guid>
    {
        public Guid Id { get; set; }
        public string Skill { get; set; }
        public string LevelKnowledge { get; set; }

        public Guid PanelistProfileId { get; set; }
        
        public DateTime ModifyDate { get; set; }
        public Guid ModifiedBy { get; set; }

        public bool State { get; set; }
        public Guid UserCreatorId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
