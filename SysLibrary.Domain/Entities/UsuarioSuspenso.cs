using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class UsuarioSuspenso
    {
        public int usuarioSuspensoId { get; set; }
        public Usuario usuario { get; set; }
        public bool ativoSuspenso { get; set; }
        public DateTime dataSuspensao { get; set; }
        public int quantDiaSuspenso { get; set; }
    }
}
