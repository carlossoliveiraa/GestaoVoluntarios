using System;
using System.ComponentModel.DataAnnotations;

namespace GestaodeVoluntarios.UI.Models
{
    public abstract class EntidadeBasica
    {
 
        public EntidadeBasica()
        {
            DataInc = DateTime.Now;
            Ativo = true;
        }
 
        [Key] 
        public int Id { get; set; }     
        public DateTime DataInc { get; set; }
        public DateTime? DataAlt { get; set; }
        public bool  Ativo { get; set; }
        public string LoginUsuario { get; set; }
    }
}
