using GestaodeVoluntarios.UI.Models;
using GestaodeVoluntarios.UI.Models.Feminino;
using GestaodeVoluntarios.UI.Models.Masculino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;
           
namespace GestaodeVoluntarios.UI.Infra.Contexto
{
    public class ContextoVoluntarios : DbContext
    {
        public ContextoVoluntarios(DbContextOptions<ContextoVoluntarios> options) : base(options)
        {
            if (this.Database.GetPendingMigrations().Count() > 0)
            {
                this.Database.Migrate();
            }
        }
        public IDbContextTransaction Transaction { get; private set; }
        //Femininos
        public virtual DbSet<FemininoCadastro> FemininoCadastros { get; set; }
        public virtual DbSet<FemininoEstudo> FemininoEstudos { get; set; }
        public virtual DbSet<FemininoFilho> FemininoFilhos { get; set; }
        public virtual DbSet<FemininoProdutosHabito> FemininoProdutosHabitos { get; set; }
        public virtual DbSet<FemininoResumoFiltro> FemininoResumoFiltros { get; set; }
        public virtual DbSet<FemininoTelefone> FemininoTelefones { get; set; }        
        //Masculinos
        public virtual DbSet<MasculinoCadastro> MasculinoCadastros { get; set; }       

        public virtual DbSet<Estudo> Estudos { get; set; }
        public virtual DbSet<VoluntarioEstudos> VoluntarioEstudos { get; set; }
        
        public IDbContextTransaction InitTransacao()
        {
            if (this.Transaction == null)
            {
                this.Transaction = this.Database.BeginTransaction();
            }

            return this.Transaction;
        }
        public void SendChanges()
        {
            this.Salvar();
            this.Commit();
        }        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //forma antiga tinhamos que mapear um por um das nossas classes.
            //modelBuilder.ApplyConfiguration(new NomedaClasseMapping());            
            //forma nova de mapear de uma vez todas as classes
            //faz via reflation
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextoVoluntarios).Assembly);
                      

            //desabilito o cascated delete. pra evitar apagar o pai e deletar os filhos
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);

            
        }         
        private void RollBack()
        {
            if (this.Transaction != null)
            {
                this.Transaction.Rollback();
            }
        }
        private void Salvar()
        {
            try
            {
                this.ChangeTracker.DetectChanges();
                this.SaveChanges();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw new Exception(ex.Message);
            }
        }
        private void Commit()
        {
            if (this.Transaction != null)
            {
                this.Transaction.Commit();
                this.Transaction.Dispose();
                this.Transaction = null;
            }
        }
    }
}
