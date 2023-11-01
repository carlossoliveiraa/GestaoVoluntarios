using GestaodeVoluntarios.UI.Infra.Contexto;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeVoluntarios.UI.Infra.Repositorio
{
    public sealed class EstudoRepositorio : RepositorioBasico<Estudo>, IEstudoRepositorio
    {
        public EstudoRepositorio(ContextoVoluntarios contexto) : base(contexto)
        {

        }
    }
}
