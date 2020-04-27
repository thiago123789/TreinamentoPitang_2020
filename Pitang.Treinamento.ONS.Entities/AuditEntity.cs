using System;
namespace Pitang.Treinamento.ONS.Entities
{
    public abstract class AuditEntity : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
