namespace GestaodeVoluntarios.UI.Models.Feminino
{
    public class FemininoResumoFiltro : EntidadeBasica
    {    
        public bool? ResumoPerfilAptaCabelo { get; set; }
        public string ResumoPerfilAptaCabeloMotivo { get; set; }
        public bool? ResumoPerfilAptaUnha { get; set; }
        public string ResumoPerfilAptaUnhaMotivo { get; set; }
        public bool? FiltrosGravida { get; set; }
        public bool? FiltrosAmamenta { get; set; }
        public bool? FiltrosCapacidadeSentirCheiroNormal { get; set; }
        public bool? FiltrosDiabetico { get; set; }
        public bool? FiltrosFumante { get; set; }
        public bool? Alergia { get; set; }
        public string FiltrosAlergiaQual { get; set; }
    }
}
