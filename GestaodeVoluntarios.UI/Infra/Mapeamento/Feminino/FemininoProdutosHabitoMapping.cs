using GestaodeVoluntarios.UI.Models.Feminino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento.Feminino
{
    public class FemininoProdutosHabitoMapping : MappingBasico<FemininoProdutosHabito>
    {
        public override void Configure(EntityTypeBuilder<FemininoProdutosHabito> builder)
        {
            base.Configure(builder);
            builder.ToTable("FemininoProdutosHabitos");

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
            builder.Property(c => c.Bronzeador).HasColumnName("Bronzeador");
            builder.Property(c => c.CabeloAtualCurvatura).HasColumnName("CabeloAtualCurvatura");
            builder.Property(c => c.CabeloColoracaoAutoAplicacao).HasColumnName("CabeloColoracaoAutoAplicacao");
            builder.Property(c => c.CabeloColoracaoSalao).HasColumnName("CabeloColoracaoSalao");
            builder.Property(c => c.CabeloColoracaoTonalizante).HasColumnName("CabeloColoracaoTonalizante");
            builder.Property(c => c.CabeloColoracaoUtiliza).HasColumnName("CabeloColoracaoUtiliza");
            builder.Property(c => c.CabeloComprimento).HasColumnName("CabeloComprimento");
            builder.Property(c => c.CabeloCondicao).HasColumnName("CabeloCondicao");
            builder.Property(c=> c.CabeloCorIntermedio).HasColumnName("CabeloCorIntermedio");
            builder.Property(c => c.CabeloCorNatural).HasColumnName("CabeloCorNatural");
            builder.Property(c => c.CabeloCorPontas).HasColumnName("iCabeloCorPontasnt");
            builder.Property(c => c.CabeloDescoloracaoReflexoLuzesMechas).HasColumnName("CabeloDescoloracaoReflexoLuzesMechas");
            builder.Property(c => c.CabeloEscovaProgressiva).HasColumnName("CabeloEscovaProgressiva");
            builder.Property(c => c.CabeloEspessura).HasColumnName("CabeloEspessura");
            builder.Property(c => c.CabeloFiosBrancosPercentual).HasColumnName("CabeloFiosBrancosPercentual");
            builder.Property(c => c.CabeloLavagemSemana).HasColumnName("CabeloLavagemSemana");
            builder.Property(c => c.CabeloMegaHairOuAplique).HasColumnName("CabeloMegaHairOuAplique");
            builder.Property(c => c.CabeloMegaHairOuApliqueSalaoAutoAplique).HasColumnName("CabeloMegaHairOuApliqueSalaoAutoAplique");
            builder.Property(c => c.CabeloNuance).HasColumnName("CabeloNuance");
            builder.Property(c => c.CabeloObservacoes).HasColumnName("CabeloObservacoes");
            builder.Property(c => c.CabeloOndeColore).HasColumnName("CabeloOndeColore");
            builder.Property(c => c.CabeloPermanente).HasColumnName("CabeloPermanente");
            builder.Property(c => c.CabeloRelaxamentoAlisamento).HasColumnName("CabeloRelaxamentoAlisamento");
            builder.Property(c => c.CabeloVirgemNatural).HasColumnName("CabeloVirgemNatural");                 
            builder.Property(c => c.DesodoranteCorporalAerosol).HasColumnName("DesodoranteCorporalAerosol");
            builder.Property(c => c.DesodoranteCreme).HasColumnName("DesodoranteCreme");
            builder.Property(c => c.DesodoranteRollon).HasColumnName("DesodoranteRollon");
            builder.Property(c => c.DesodoranteSpray).HasColumnName("DesodoranteSpray");
            builder.Property(c => c.HidratanteCorporal).HasColumnName("HidratanteCorporal");
            builder.Property(c => c.HidratanteFacial).HasColumnName("HidratanteFacial");
            builder.Property(c => c.HidratanteMaos).HasColumnName("HidratanteMaos");
            builder.Property(c => c.HidratanteOleoCorporal).HasColumnName("HidratanteOleoCorporal");
            builder.Property(c => c.HidratanteParaBanho).HasColumnName("HidratanteParaBanho");
            builder.Property(c => c.HidratantePes).HasColumnName("HidratantePes");
            builder.Property(c => c.HigieneBucalCremeDental).HasColumnName("HigieneBucalCremeDental");
            builder.Property(c => c.HigieneBucalEnxaguanteBucal).HasColumnName("HigieneBucalEnxaguanteBucal");
            builder.Property(c => c.HigieneBucalEscovaDental).HasColumnName("HigieneBucalEscovaDental");
            builder.Property(c => c.HigieneBucalFioDental).HasColumnName("bHigieneBucalFioDentalit");
            builder.Property(c => c.LencoUmidecidoInfantil).HasColumnName("LencoUmidecidoInfantil");
            builder.Property(c => c.LencoUmidecidoIntimo).HasColumnName("LencoUmidecidoIntimo");
            builder.Property(c => c.LencoUmidecidoMaquiagem).HasColumnName("LencoUmidecidoMaquiagem");
            builder.Property(c => c.PeleFotoTipo).HasColumnName("PeleFotoTipo");
            builder.Property(c => c.ProdutosParaCabeloCondicionador).HasColumnName("ProdutosParaCabeloCondicionador");
            builder.Property(c => c.ProdutosParaCabeloCondicionadorAntiCaspa).HasColumnName("ProdutosParaCabeloCondicionadorAntiCaspa");
            builder.Property(c => c.ProdutosParaCabeloCremePentear).HasColumnName("ProdutosParaCabeloCremePentear");
            builder.Property(c => c.ProdutosParaCabeloFinalizadores).HasColumnName("ProdutosParaCabeloFinalizadores");
            builder.Property(c => c.ProdutosParaCabeloGel).HasColumnName("ProdutosParaCabeloGel");
            builder.Property(c => c.ProdutosParaCabeloMascaraTratamento).HasColumnName("ProdutosParaCabeloMascaraTratamento");
            builder.Property(c => c.ProdutosParaCabeloShampoo).HasColumnName("ProdutosParaCabeloShampoo");
            builder.Property(c => c.ProdutosParaCabeloShampooAntiCaspa).HasColumnName("ProdutosParaCabeloShampooAntiCaspa");
            builder.Property(c => c.ProtetorSolarCorporal).HasColumnName("ProtetorSolarCorporal");
            builder.Property(c => c.ProtetorSolarFacial).HasColumnName("ProtetorSolarFacial");
            builder.Property(c => c.ProtetorSolarLabial).HasColumnName("ProtetorSolarLabial");
            builder.Property(c => c.SaboneteCorporalBarra).HasColumnName("SaboneteCorporalBarra");
            builder.Property(c => c.SaboneteCorporalIntimo).HasColumnName("SaboneteCorporalIntimo");
            builder.Property(c => c.SaboneteCorporalLiquido).HasColumnName("SaboneteCorporalLiquido");
            builder.Property(c => c.SaboneteFacialBarra).HasColumnName("SaboneteFacialBarra");
            builder.Property(c => c.SaboneteFacialEsfoliante).HasColumnName("SaboneteFacialEsfoliante");
            builder.Property(c => c.SaboneteFacialEspuma).HasColumnName("SaboneteFacialEspuma");
            builder.Property(c => c.SaboneteFacialGel).HasColumnName("SaboneteFacialGel");
            builder.Property(c => c.SaboneteFacialLiquido).HasColumnName("SaboneteFacialLiquido");
            builder.Property(c => c.TipoDePeleBracosPernas).HasColumnName("TipoDePeleBracosPernas");
            builder.Property(c => c.TipoDePeleCostasPeitoral).HasColumnName("TipoDePeleCostasPeitoral");
            builder.Property(c => c.TipoDePeleMaosPe).HasColumnName("TipoDePeleMaosPe");
            builder.Property(c => c.TipoDePeleObservacoes).HasColumnName("TipoDePeleObservacoes");
            builder.Property(c => c.TipodePeleRosto).HasColumnName("TipodePeleRosto");
            builder.Property(c => c.UnhaComprimento).HasColumnName("UnhaComprimento");
            builder.Property(c => c.UnhaCuticulaAlteracao).HasColumnName("UnhaCuticulaAlteracao");
            builder.Property(c => c.UnhaCuticulaQualAlteracao).HasColumnName("UnhaCuticulaQualAlteracao");
            builder.Property(c => c.UnhaCuticulasIntegrasRemovidas).HasColumnName("UnhaCuticulasIntegrasRemovidas");
            builder.Property(c => c.UnhaEspessura).HasColumnName("UnhaEspessura");
            builder.Property(c => c.UnhaOndeFazAutoAplicacao).HasColumnName("UnhaOndeFazAutoAplicacao");
            builder.Property(c => c.UnhaOndeFazSalao).HasColumnName("UnhaOndeFazSalao");
            builder.Property(c => c.UnhaSudorese).HasColumnName("UnhaSudorese");
            builder.Property(c => c.UnhaUsoFrequenteEsmalte).HasColumnName("UnhaUsoFrequenteEsmalte");
            builder.Property(c => c.UnhasObservacao).HasColumnName("UnhasObservacao");
        }
    }
}
