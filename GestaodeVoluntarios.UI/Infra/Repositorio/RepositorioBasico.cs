using GestaodeVoluntarios.UI.Infra.Contexto;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaodeVoluntarios.UI.Infra.Repositorio
{
    public class RepositorioBasico<TEntidade> : IRepositorioBasico<TEntidade>  where TEntidade : EntidadeBasica
    {
        protected readonly ContextoVoluntarios contexto;
       
        public RepositorioBasico(ContextoVoluntarios contexto) : base()
        {
            this.contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {
            try
            {
                this.contexto.InitTransacao();
                this.contexto.Set<TEntidade>().Attach(entidade);
                this.contexto.Entry(entidade).State = EntityState.Modified;
                this.contexto.SendChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AtivarDesativar(int id, bool ativo)
        {
            try
            {
                TEntidade entidade = this.contexto.Set<TEntidade>().Where(x=> x.Id == id).FirstOrDefault();

                if (entidade != null)
                {
                    this.contexto.InitTransacao();
                    bool retorno = ativo;
                    entidade.Ativo = retorno;                  
                    this.contexto.SendChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Deletar(int id)
        {
            try
            {
                var entidade = this.SelecionarPorId(id);
                if (entidade != null)
                {
                    this.contexto.InitTransacao();
                    this.contexto.Set<TEntidade>().Remove(entidade);
                    this.contexto.SendChanges();                    
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(TEntidade entidade)
        {
            try
            {
                this.contexto.InitTransacao();
                this.contexto.Set<TEntidade>().Remove(entidade);
                this.contexto.SendChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Incluir(TEntidade entidade)
        {
            try
            {
                contexto.InitTransacao();
                contexto.Set<TEntidade>().Add(entidade);
                contexto.SendChanges();
                return entidade.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }         
        }

        public TEntidade SelecionarPorId(int id)
        {
            try
            {
                return this.contexto.Set<TEntidade>().Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            try
            {
                return this.contexto.Set<TEntidade>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     }
}
