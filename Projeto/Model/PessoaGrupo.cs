
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Model
{
    [Table("perfil_recurso")]
    public class PerssoaRecurso : BaseEntity
    {
        [Column(name: "ano")]
        public int Ano { set; get; }

        [Column(name: "id_pessoa")]
        public int IdPessoa { set; get; }

        [Column(name: "id_grupo")]
        public int IdGrupo { set; get; }

        [Column(name: "papel")]
        public string Papel { set; get; }

        [Column(name: "semestre")]
        public int Semestre { set; get; }
    }
}
