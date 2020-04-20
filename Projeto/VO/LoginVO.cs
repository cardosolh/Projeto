using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.VO
{
    public class LoginVO : BaseVO
    {
        public int id_perfil { get; set; }
        public int id_pessoa { get; set; }
        public string user { get; set; }
        public string password { set; get; }
    }
}
