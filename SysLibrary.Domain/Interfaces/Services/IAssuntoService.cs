﻿using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Interfaces.Services
{
    public interface IAssuntoService : IServiceBase<Assunto>
    {
        IEnumerable<Assunto> buscarAssunto(string assunto);
    }
}
