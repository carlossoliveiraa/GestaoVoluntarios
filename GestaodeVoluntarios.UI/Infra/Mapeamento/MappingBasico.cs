using GestaodeVoluntarios.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento
{
    public class MappingBasico<T> : IEntityTypeConfiguration<T> where T : EntidadeBasica
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.DataInc).IsRequired().HasColumnName("DataInc");
            builder.Property(c => c.DataAlt).HasColumnName("DataAlt");
            builder.Property(c => c.Ativo).HasColumnName("Ativo");
        }
    }
}
