using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaodeVoluntarios.UI.Models
{
    public class VoluntarioEstudos : EntidadeBasica
    {
        public int VoluntarioId { get; set; }
        public string NomeVoluntario { get; set; }
        public int EstudoId { get; set; }
        public string NomeEstudo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataEstudo { get; set; }
        public string TipoVoluntario { get; set; }
      
    }
}
