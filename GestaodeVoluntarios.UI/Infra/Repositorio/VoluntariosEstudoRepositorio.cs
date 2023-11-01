using GestaodeVoluntarios.UI.Infra.Contexto;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models;

namespace GestaodeVoluntarios.UI.Infra.Repositorio
{
    public sealed class VoluntariosEstudoRepositorio : RepositorioBasico<VoluntarioEstudos>, IVoluntarioEstudoRepositorio
    {
        public VoluntariosEstudoRepositorio(ContextoVoluntarios contexto) : base(contexto)
        {
            //porrada de regra de negocio
        }
    }

}
