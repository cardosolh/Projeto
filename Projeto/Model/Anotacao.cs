
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto.Model
{
    [Table("anotacao")]
    public class Anotacao : BaseEntity
    {

        [Column(name: "data")]
        public DateTime Data { set; get; }

        [Column(name: "id_grupo")]
        public int IdGrupo { set; get; }

        [Column(name: "id_pessoa")]
        public int IdPessoa{ set; get; }

        [Column(name: "obs")]
        public string Obs { set; get; }
    }

 }

