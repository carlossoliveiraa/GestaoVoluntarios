using GestaodeVoluntarios.UI.Models.Feminino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento.Feminino
{ 
    public class FemininoTelefoneMapping : MappingBasico<FemininoTelefone>
    {
        public override void Configure(EntityTypeBuilder<FemininoTelefone> builder)
        {
            base.Configure(builder);
            builder.ToTable("FemininoTelefones");

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");           
            builder.Property(c=> c.CadastroTelefoneCelular).HasColumnName("CadastroTelefoneCelular");
            builder.Property(c=> c.CadastroTelefoneComercialRecado).HasColumnName("CadastroTelefoneComercialRecado");
            builder.Property(c=> c.CadastroTelefoneDiversos).HasColumnName("CadastroTelefoneDiversos");
            builder.Property(c=> c.CadastroTelefoneResidencial).HasColumnName("CadastroTelefoneResidencial");
            builder.Property(c=> c.CadastroWhatsapp).HasColumnName("CadastroWhatsapp");

            //builder.Property(c => c.CadastroId).HasColumnName("CadastroId");
            //builder.Property(c => c.DataCadastro).HasColumnName("DataCadastro");
            //builder.Property(c => c.DataAlteracao).HasColumnName("DataAlteracao");
            //builder.Property(c => c.Ativo).HasColumnName("Ativo");
        }                    
    }
}
