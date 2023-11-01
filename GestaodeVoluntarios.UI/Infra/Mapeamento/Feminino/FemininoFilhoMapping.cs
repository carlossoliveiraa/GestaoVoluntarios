using GestaodeVoluntarios.UI.Models.Feminino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento.Feminino
{   
    public class FemininoFilhoMapping : MappingBasico<FemininoFilho>
    {
        public override void Configure(EntityTypeBuilder<FemininoFilho> builder)
        {
            base.Configure(builder);
            builder.ToTable("FemininoFilhos");

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");          
            builder.Property(c=> c.FilhosDataNascimento1).HasColumnName("FilhosDataNascimento1");
            builder.Property(c=> c.FilhosDataNascimento2).HasColumnName("FilhosDataNascimento2");
            builder.Property(c=> c.FilhosDataNascimento3).HasColumnName("FilhosDataNascimento3");
            builder.Property(c=> c.FilhosDataNascimento4).HasColumnName("FilhosDataNascimento4");
            builder.Property(c=> c.FilhosDataNascimento5).HasColumnName("FilhosDataNascimento5");
            builder.Property(c=> c.FilhosSexo1).HasColumnName("FilhosSexo1");
            builder.Property(c=> c.FilhosSexo2).HasColumnName("FilhosSexo2");
            builder.Property(c=> c.FilhosSexo3).HasColumnName("FilhosSexo3");
            builder.Property(c=> c.FilhosSexo4).HasColumnName("FilhosSexo4");
            builder.Property(c=> c.FilhosSexo5).HasColumnName("FilhosSexo5");
        }
    }
}
