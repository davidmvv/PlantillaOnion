using ATOS.Resource.Common.Entities;

namespace Domian.Entities
{
    public class Colaborador : PersonaAuditable<Guid, Guid>
    {
        public string emailAtos { get; set; } = string.Empty;
        public string? emailClient { get; set; } = string.Empty;
        public string DASid { get; set; } = string.Empty;
        public string TimeSheet { get; set; } = string.Empty;   //(employee | graduate program)
        public string GCMDetails { get; set; } = string.Empty;
        public string ShippingAddress { get; set; } = string.Empty;
        public string? Device { get; set; } = string.Empty;
        public string? DeviceSerialNumber { get; set; } = string.Empty;
        public string? ProfilePhoto { get; set; } = string.Empty;
        public string PID { get; set; } = string.Empty;     //???
        public DateTime JoiningDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ReasonOut { get; set; } = string.Empty;
        public string? CurrentPosition { get; set; } = string.Empty; public Guid CandidateId { get; set; }
        //public virtual Person Person { get; set; }     }
    }
}
