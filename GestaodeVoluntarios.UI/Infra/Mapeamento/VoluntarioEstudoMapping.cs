using GestaodeVoluntarios.UI.Models;
using GestaodeVoluntarios.UI.Models.Masculino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento
{
    public class VoluntarioEstudoMapping : MappingBasico<VoluntarioEstudos>
    {
        public override void Configure(EntityTypeBuilder<VoluntarioEstudos> builder)
        {
            base.Configure(builder);
            builder.ToTable("VoluntarioEstudos");

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.VoluntarioId).HasColumnName("VoluntarioId");
            builder.Property(c => c.NomeVoluntario).HasColumnName("NomeVoluntario");            
            builder.Property(c => c.EstudoId).HasColumnName("EstudoId");            
            builder.Property(c => c.Descricao).HasColumnName("Descricao");
            builder.Property(c => c.DataEstudo).HasColumnName("DataEstudo");
            builder.Property(c => c.TipoVoluntario).HasColumnName("TipoVoluntario");          
        }
    }
}
