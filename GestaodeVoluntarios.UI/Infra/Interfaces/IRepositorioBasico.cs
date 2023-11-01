using GestaodeVoluntarios.UI.Models;
using GestaodeVoluntarios.UI.Models.Masculino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeVoluntarios.UI.Infra.Interfaces
{
    public interface IRepositorioBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        int Incluir(TEntidade entidade);
        bool AtivarDesativar(int id,bool ativo);
        bool Deletar(int id);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();

    }
}
