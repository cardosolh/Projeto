
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Model
{
    [Table("grupo")]
    public class Grupo : BaseEntity
    {
        [Column(name: "nome")]
        public string Nome { set; get; }
    }
}
