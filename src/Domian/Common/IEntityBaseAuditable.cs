using Atos.Core.Abstractions;

namespace Domian.Common
{
    public interface IEntityBaseAuditable<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        public DateTime ModifyDate { get; set; }
        public TUserKey ModifiedBy { get; set; }
    }
}
