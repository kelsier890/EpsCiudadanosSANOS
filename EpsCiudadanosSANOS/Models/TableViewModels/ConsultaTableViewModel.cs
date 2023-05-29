using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpsCiudadanosSANOS.Models.TableViewModels
{
    public class ConsultaTableViewModel
    {
        public int id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Motivo { get; set; }
        public int IdMedico { get; set; }
        public string NombreMedico { get; set; }
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
    }
}