using GestaodeVoluntarios.UI.Dados.Mapeamento;
using GestaodeVoluntarios.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento
{
    public class EstudoMapping : MappingBasico<Estudo>
    {
        public override void Configure(EntityTypeBuilder<Estudo> builder)
        {
            base.Configure(builder);
            builder.ToTable("Estudos");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Nome).HasMaxLength(100).HasColumnName("Nome");
        }
    }
}
