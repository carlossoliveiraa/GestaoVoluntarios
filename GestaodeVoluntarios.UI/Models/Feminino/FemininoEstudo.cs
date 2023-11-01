using System;

namespace GestaodeVoluntarios.UI.Models.Feminino
{
    public class FemininoEstudo : EntidadeBasica
    {
        public string LoginUsuario { get; set; }
        public int? FemininoId { get; set; }
        public int? EstudoId { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataEstudo { get; set; }
        public bool? Agendado { get; set; }
    }
}
