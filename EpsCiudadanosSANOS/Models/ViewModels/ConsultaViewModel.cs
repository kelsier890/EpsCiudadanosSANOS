using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EpsCiudadanosSANOS.Models.ViewModels
{
    public class ConsultaViewModel
    {
        [Required]
        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }
        [Required]
        [Display(Name = "Motivo Consulta")]
        public string Motivo { get; set; }
        [Required]
        [Display(Name = "Id Medico")]
        public int NombreMedico { get; set; }
        [Required]
        [Display(Name = "Id Paciente")]
        public int NombrePaciente { get; set; }
    }
}