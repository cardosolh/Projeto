using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.VO
{
    public class PessoaGrupoVO : BaseVO
    {
        public int ano { get; set; }
        public int id_grupo { get; set; }
        public int id_pessoa { get; set; }
        public int semestre { get; set; }
        public string papel { set; get; }
    }
}
