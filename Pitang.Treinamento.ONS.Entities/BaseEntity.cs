using System;
using System.ComponentModel.DataAnnotations;

namespace Pitang.Treinamento.ONS.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
