using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string nome_adm { get; set; }
        public string email_adm { get; set; }
        public string senha { get; set; }
        public string Login { get; set; }
    }
}
