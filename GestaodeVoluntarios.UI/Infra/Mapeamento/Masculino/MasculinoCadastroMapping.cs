using GestaodeVoluntarios.UI.Models.Masculino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaodeVoluntarios.UI.Dados.Mapeamento.Masculino
{
    public class MasculinoCadastroMapping : MappingBasico<MasculinoCadastro>
    {
        public override void Configure(EntityTypeBuilder<MasculinoCadastro> builder)
        {
            base.Configure(builder);

            builder.ToTable("MasculinoCadastros");

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
                   
            builder.Property(c => c.Bairro).HasColumnName("Bairro");
            builder.Property(c => c.CEP).HasColumnName("CEP");
            builder.Property(c => c.CPF).HasColumnName("CPF");
            builder.Property(c => c.CadastroClasseSocial).HasColumnName("CadastroClasseSocial").HasColumnType("varchar(200)");
            builder.Property(c => c.CadastroDataInclusao).HasColumnName("CadastroDataInclusao");
            builder.Property(c => c.CadastroDataNascimento).HasColumnName("CadastroDataNascimento");
            builder.Property(c => c.CadastroIdade).HasColumnName("CadastroIdade");
            builder.Property(c => c.DataCadastro).HasColumnName("DataCadastro");
            builder.Property(c => c.CadastroNome).HasColumnName("CadastroNome");
            builder.Property(c => c.CadastroObs1).HasColumnName("CadastroObs1");
            builder.Property(c => c.CadastroObs2).HasColumnName("CadastroObs2");
            builder.Property(c => c.CadastroObs3).HasColumnName("CadastroObs3");
            builder.Property(c => c.CadastroObsGerais).HasColumnName("CadastroObsGerais");
            builder.Property(c => c.CadastroRG).HasColumnName("CadastroRG");
            builder.Property(c => c.Cidade).HasColumnName("Cidade");
            builder.Property(c => c.Complemento).HasColumnName("Complemento");
            builder.Property(c => c.EnsinoFundamentalCompleto).HasColumnName("EnsinoFundamentalCompleto");
            builder.Property(c => c.EnsinoMedioCompleto).HasColumnName("EnsinoMedioCompleto");
            builder.Property(c => c.EnsinoSuperiorCompleto).HasColumnName("EnsinoSuperiorCompleto");
            builder.Property(c => c.EnsinoPosGraduacaoCompleta).HasColumnName("EnsinoPosGraduacaoCompleta");

            builder.Property(c => c.LoginUsuario).HasColumnName("LoginUsuario");
            builder.Property(c => c.Logradouro).HasColumnName("Logradouro");
            builder.Property(c => c.NomeDaEmpresa).HasColumnName("NomeDaEmpresa");
            builder.Property(c => c.Numero).HasColumnName("Numero");
            builder.Property(c => c.Profissao).HasColumnName("Profissao");
            //builder.Property(c => c.TrabalhaFora).HasColumnName("TrabalhaFora");
            builder.Property(c => c.UF).HasColumnName("UF");

            builder.Property(c => c.TelefoneCelular).HasColumnType("TelefoneCelular");
            builder.Property(c => c.TelefoneComercialRecado).HasColumnType("TelefoneComercialRecado");
            //builder.Property(c => c.TelefoneDiversos).HasColumnType("TelefoneDiversos");
            builder.Property(c => c.TelefoneResidencial).HasColumnType("TelefoneResidencial");
            builder.Property(c => c.Whatsapp).HasColumnType("Whatsapp");

            builder.Property(c => c.Alergia).HasColumnName("Alergia");
            builder.Property(c => c.CapacidadeSentirCheiroNormal).HasColumnName("CapacidadeSentirCheiroNormal");
            builder.Property(c => c.Diabetico).HasColumnName("Diabetico");
            builder.Property(c => c.Fumante).HasColumnName("Fumante");
            builder.Property(c => c.AlergiaQual).HasColumnName("AlergiaQual");

            builder.Property(c => c.FilhosDataNascimento1).HasColumnName("FilhosDataNascimento1");
            builder.Property(c => c.FilhosDataNascimento2).HasColumnName("FilhosDataNascimento2");
            builder.Property(c => c.FilhosDataNascimento3).HasColumnName("FilhosDataNascimento3");
            builder.Property(c => c.FilhosDataNascimento4).HasColumnName("FilhosDataNascimento4");
            builder.Property(c => c.FilhosDataNascimento5).HasColumnName("FilhosDataNascimento5");
            builder.Property(c => c.FilhosDataNascimento6).HasColumnName("FilhosDataNascimento6");
            builder.Property(c => c.FilhosSexo1).HasColumnName("FilhosSexo1");
            builder.Property(c => c.FilhosSexo2).HasColumnName("FilhosSexo2");
            builder.Property(c => c.FilhosSexo3).HasColumnName("FilhosSexo3");
            builder.Property(c => c.FilhosSexo4).HasColumnName("FilhosSexo4");
            builder.Property(c => c.FilhosSexo5).HasColumnName("FilhosSexo5");
            builder.Property(c => c.FilhosSexo6).HasColumnName("FilhosSexo6");

            builder.Property(c => c.Bronzeador).HasColumnName("Bronzeador");
            builder.Property(c => c.CondicoesDasUnhasComprimento).HasColumnName("CondicoesDasUnhasComprimento");
            builder.Property(c => c.CondicoesDasUnhasCuticulasIntegrasRemovidas).HasColumnName("CondicoesDasUnhasCuticulasIntegrasRemovidas");
            builder.Property(c => c.CondicoesDasUnhasEspessura).HasColumnName("CondicoesDasUnhasEspessura");
            builder.Property(c => c.CondicoesDasUnhasObservacao).HasColumnName("CondicoesDasUnhasObservacao");
            builder.Property(c => c.CondicoesDasUnhasSudorese).HasColumnName("CondicoesDasUnhasSudorese");
            builder.Property(c => c.CondicoesDasUnhasUsoFrequenteEsmalte).HasColumnName("CondicoesDasUnhasUsoFrequenteEsmalte");
            builder.Property(c => c.DesodoranteCorporalAerosol).HasColumnName("DesodoranteCorporalAerosol");
            builder.Property(c => c.DesodoranteCreme).HasColumnName("DesodoranteCreme");
            builder.Property(c => c.DesodoranteRollon).HasColumnName("DesodoranteRollon");
            builder.Property(c => c.DesodoranteSpray).HasColumnName("DesodoranteSpray");
            builder.Property(c => c.DetalhesCabeloAtualCurvatura).HasColumnName("DetalhesCabeloAtualCurvatura");
            builder.Property(c => c.DetalhesCabeloComprimento).HasColumnName("DetalhesCabeloComprimento");
            builder.Property(c => c.DetalhesCabeloCondicao).HasColumnName("DetalhesCabeloCondicao");
            builder.Property(c => c.DetalhesCabeloCorIntermedio).HasColumnName("DetalhesCabeloCorIntermedio");
            builder.Property(c => c.DetalhesCabeloCorNatural).HasColumnName("DetalhesCabeloCorNatural");
            builder.Property(c => c.DetalhesCabeloCorPontas).HasColumnName("DetalhesCabeloCorPontas");
            builder.Property(c => c.DetalhesCabeloEspessura).HasColumnName("DetalhesCabeloEspessura");
            builder.Property(c => c.DetalhesCabeloFiosBrancosPercentual).HasColumnName("DetalhesCabeloFiosBrancosPercentual");
            builder.Property(c => c.DetalhesCabeloFrequenciaLavagemCabelo).HasColumnName("DetalhesCabeloFrequenciaLavagemCabelo");
            //builder.Property(c => c.DetalhesCabeloLuzesOuAlisamento).HasColumnName("DetalhesCabeloLuzesOuAlisamento");
            builder.Property(c => c.DetalhesCabeloMegaHairOuAplique).HasColumnName("DetalhesCabeloMegaHairOuAplique");
            //builder.Property(c => c.DetalhesCabeloObservacoes).HasColumnName("DetalhesCabeloObservacoes");
            builder.Property(c => c.DetalhesCabeloNuance).HasColumnName("DetalhesCabeloNuance");
            //builder.Property(c => c.DetalhesCabeloTransformacaoQuimica).HasColumnName("DetalhesCabeloTransformacaoQuimica");

            builder.Property(c => c.CabeloTransfQuimicaNaoVirgemNatural).HasColumnName("CabeloTransfQuimicaNaoVirgemNatural");
            builder.Property(c => c.CabeloTransfColoracaoTonalizante).HasColumnName("CabeloTransfColoracaoTonalizante");
            builder.Property(c => c.CabeloTransfPermanente).HasColumnName("CabeloTransfPermanente");
            builder.Property(c => c.CabeloTransfDescoloracaoReflexoLuzesMechas).HasColumnName("CabeloTransfDescoloracaoReflexoLuzesMechas");
            builder.Property(c => c.CabeloTransfEscovaProgressiva).HasColumnName("CabeloTransfEscovaProgressiva");
            builder.Property(c => c.CabeloTransfLuzesOuAlisamento).HasColumnName("CabeloTransfLuzesOuAlisamento");

            builder.Property(c => c.HidratanteCorporal).HasColumnName("HidratanteCorporal");
            builder.Property(c => c.HidratanteFacial).HasColumnName("HidratanteFacial");
            builder.Property(c => c.HidratanteMaos).HasColumnName("HidratanteMaos");
            builder.Property(c => c.HidratanteOleoCorporal).HasColumnName("HidratanteOleoCorporal");
            builder.Property(c => c.HidratanteParaBanho).HasColumnName("HidratanteParaBanho");
            builder.Property(c => c.HidratantePes).HasColumnName("HidratantePes");
            builder.Property(c => c.HigieneBucalCremeDental).HasColumnName("HigieneBucalCremeDental");
            builder.Property(c => c.HigieneBucalEnxaguanteBucal).HasColumnName("HigieneBucalEnxaguanteBucal");
            builder.Property(c => c.HigieneBucalEscovaDental).HasColumnName("HigieneBucalEscovaDental");
            builder.Property(c => c.HigieneBucalFioDental).HasColumnName("HigieneBucalFioDental");
            builder.Property(c => c.ProdutosParaCabeloCondicionador).HasColumnName("ProdutosParaCabeloCondicionador");
            builder.Property(c => c.ProdutosParaCabeloCondicionadorAntiCaspa).HasColumnName("ProdutosParaCabeloCondicionadorAntiCaspa");
            builder.Property(c => c.ProdutosParaCabeloCremePentear).HasColumnName("ProdutosParaCabeloCremePentear");
            builder.Property(c => c.ProdutosParaCabeloFinalizadores).HasColumnName("ProdutosParaCabeloFinalizadores");
            builder.Property(c => c.ProdutosParaCabeloGel).HasColumnName("ProdutosParaCabeloGel");
            builder.Property(c => c.ProdutosParaCabeloMascaraTratamento).HasColumnName("ProdutosParaCabeloMascaraTratamento");
            builder.Property(c => c.ProdutosParaCabeloShampoo).HasColumnName("ProdutosParaCabeloShampoo");
            builder.Property(c => c.ProdutosParaCabeloShampooAntiCaspa).HasColumnName("ProdutosParaCabeloShampooAntiCaspa");
            builder.Property(c => c.ProdutosPosBarbaGel).HasColumnName("ProdutosPosBarbaGel");
            builder.Property(c => c.ProdutosPosBarbaLocao).HasColumnName("ProdutosPosBarbaLocao");
            builder.Property(c => c.ProdutosPosbarbaBalsamo).HasColumnName("ProdutosPosbarbaBalsamo");
            builder.Property(c => c.ProdutosPreBarbaCremeBarbear).HasColumnName("ProdutosPreBarbaCremeBarbear");
            builder.Property(c => c.ProdutosPreBarbaEspumaBarbear).HasColumnName("ProdutosPreBarbaEspumaBarbear");
            builder.Property(c => c.ProdutosPreBarbaGelBarbear).HasColumnName("ProdutosPreBarbaGelBarbear");
            builder.Property(c => c.ProdutosPreBarbaOutros).HasColumnName("ProdutosPreBarbaOutros");
            builder.Property(c => c.ProdutosPreBarbaSabonete).HasColumnName("ProdutosPreBarbaSabonete");
            builder.Property(c => c.ProtetorSolarCorporal).HasColumnName("ProtetorSolarCorporal");
            builder.Property(c => c.ProtetorSolarFacial).HasColumnName("ProtetorSolarFacial");
            builder.Property(c => c.ProtetorSolarLabial).HasColumnName("ProtetorSolarLabial");
            builder.Property(c => c.SaboneteCorporalBarra).HasColumnName("SaboneteCorporalBarra");
            builder.Property(c => c.SaboneteCorporalLiquido).HasColumnName("SaboneteCorporalLiquido");
            builder.Property(c => c.SaboneteFacialBarra).HasColumnName("SaboneteFacialBarra");
            builder.Property(c => c.SaboneteFacialEsfoliante).HasColumnName("SaboneteFacialEsfoliante");
            builder.Property(c => c.SaboneteFacialEspuma).HasColumnName("SaboneteFacialEspuma");
            builder.Property(c => c.SaboneteFacialGel).HasColumnName("SaboneteFacialGel");
            builder.Property(c => c.SaboneteFacialLiquido).HasColumnName("SaboneteFacialLiquido");
            builder.Property(c => c.TipoDePeleBracosPernas).HasColumnName("TipoDePeleBracosPernas");
            builder.Property(c => c.TipoDePeleFototipo).HasColumnName("TipoDePeleFototipo");
            builder.Property(c => c.TipoDePeleMaosPe).HasColumnName("TipoDePeleMaosPe");
            builder.Property(c => c.TipoDePeloCostasPeitoral).HasColumnName("TipoDePeloCostasPeitoral");
            builder.Property(c => c.TipoDePeloObservacoes).HasColumnName("TipoDePeloObservacoes");
            builder.Property(c => c.TipodePeleRosto).HasColumnName("TipodePeleRosto");

        }
    }
}
