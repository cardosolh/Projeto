
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Model
{
    [Table("perfil_recurso")]
    public class PerfilRecurso 
    {
        [Column(name: "id_perfil")]
        public int IdPerfil { set; get; }

        [Column(name: "id_recurso")]
        public int IdRecurso { set; get; }
    }
}
