using GestaodeVoluntarios.UI.Models.Feminino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeVoluntarios.UI.Infra.Interfaces
{
    public interface IFemininoCadastroRepositorio : IRepositorioBasico<FemininoCadastro>
    {
        FemininoCadastro ObterCadastroFemininosPorId(int id);
        IEnumerable<FemininoCadastro> ObterCadastroFemininosTodos();
        List<FemininoCadastro> FiltrarnoBackEnd(bool ativo, int masculinoId, string classesocial, int idadeDe, int idadeAte, string nome);
        public List<FemininoCadastro> ObterCadastroFemininoTodosSql(bool ativo, int pagina, int tamPagina);
        IEnumerable<FemininoCadastro> ObterCadastroFemininoPorParametros(string parametros);
    }
}
