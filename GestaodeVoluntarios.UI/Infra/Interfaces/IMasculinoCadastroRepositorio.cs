using GestaodeVoluntarios.UI.Models.Masculino;
using System.Collections.Generic;

namespace GestaodeVoluntarios.UI.Infra.Interfaces
{
    public interface IMasculinoCadastroRepositorio : IRepositorioBasico<MasculinoCadastro>
    {
        MasculinoCadastro ObterCadastroMasculinosPorId(int id);
        IEnumerable<MasculinoCadastro> ObterCadastroMasculinosTodos();

        IEnumerable<MasculinoCadastro> ObterCadastroMasculinoPorParametros(string parametros);

        List<MasculinoCadastro> ObterCadastroMasculinosTodosSql(bool ativo, int pagina, int tamPagina);

        List<MasculinoCadastro> FiltrarnoBackEnd(bool ativo, int masculinoId, string classesocial, int idadeDe, int idadeAte, string nome);
    }
}
