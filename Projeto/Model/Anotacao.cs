
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Model
{
    [Table("anotacao")]
    public class Anotacao : BaseEntity
    {
        [Column(name: "obs")]
        public string Obs { set; get; }

        [Column(name: "data")]
        public System.DateTime Data { set; get; }

        [Column(name: "id_grupo")]
        public int Id_grupo { set; get; }

        [Column(name: "id_pessoa")]
        public int Id_pessoa { set; get; }
    }
}
