
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Model
{
    [Table("login")]
    public class Login : BaseEntity
    {
        [Column(name: "id_perfil")]
        public int IdPerfil {set; get; }

        [Column(name: "id_pessoa")]
        public int IdPessoa { set; get; }

        [Column(name: "password")]
        public string Password { set; get; }

        [Column(name: "user")]
        public string User { set; get; }
    }
}