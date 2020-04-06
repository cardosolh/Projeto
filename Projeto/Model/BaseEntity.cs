using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Model
{
    public class BaseEntity
    {
        [Key]
        [Required]
        [Column(name: "ID")]
        public virtual long Id { get; set; }
    }
}
