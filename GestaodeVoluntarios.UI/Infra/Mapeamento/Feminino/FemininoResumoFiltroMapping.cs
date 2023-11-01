using GestaodeVoluntarios.UI.Models.Feminino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento.Feminino
{ 
    public class FemininoResumoFiltroMapping : MappingBasico<FemininoResumoFiltro>
    {
        public override void Configure(EntityTypeBuilder<FemininoResumoFiltro> builder)
        {
            base.Configure(builder);
            builder.ToTable("FemininoResumoFiltros");

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Alergia).HasColumnName("Alergia");          
            builder.Property(c => c.FiltrosAlergiaQual).HasColumnName("FiltrosAlergiaQual");
            builder.Property(c => c.FiltrosAmamenta).HasColumnName("bFiltrosAmamentait");
            builder.Property(c => c.FiltrosCapacidadeSentirCheiroNormal).HasColumnName("FiltrosCapacidadeSentirCheiroNormal");
            builder.Property(c => c.FiltrosDiabetico).HasColumnName("FiltrosDiabetico");
            builder.Property(c => c.FiltrosFumante).HasColumnName("FiltrosFumante");
            builder.Property(c => c.FiltrosGravida).HasColumnName("FiltrosGravida");
            builder.Property(c => c.ResumoPerfilAptaCabelo).HasColumnName("ResumoPerfilAptaCabelo");
            builder.Property(c => c.ResumoPerfilAptaCabeloMotivo).HasColumnName("ResumoPerfilAptaCabeloMotivo");
            builder.Property(c => c.ResumoPerfilAptaUnha).HasColumnName("ResumoPerfilAptaUnha");
            builder.Property(c => c.ResumoPerfilAptaUnhaMotivo).HasColumnName("nResumoPerfilAptaUnhaMotivo");
        }
    }
}
