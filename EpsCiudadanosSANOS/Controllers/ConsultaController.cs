using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpsCiudadanosSANOS.Models;
using EpsCiudadanosSANOS.Models.TableViewModels;
using EpsCiudadanosSANOS.Models.ViewModels;

namespace EpsCiudadanosSANOS.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta
        public ActionResult Index()
        {
            List<ConsultaTableViewModel> lst = null;
            using(EpsEntities db = new EpsEntities())
            {
                lst = (from c in db.consulta
                      join m in db.medico on c.idmedico equals m.id
                      join p in db.paciente on c.idpaciente equals p.id
                      orderby c.motivo
                      select new ConsultaTableViewModel
                      {
                          id = c.id,
                          Fecha= c.fecha,
                          Motivo= c.motivo,
                          IdMedico= c.idmedico,
                          NombreMedico= m.nombre,
                          IdPaciente= c.idpaciente,
                          NombrePaciente=p.Nombre
                          
                      }).ToList();
            }

            return View(lst);
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ConsultaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new EpsEntities())
            {
                consulta oConsulta = new consulta();
                oConsulta.fecha = model.Fecha;
                oConsulta.motivo = model.Motivo;

                // Buscar el ID del médico por nombre
                var medico = db.medico.FirstOrDefault(m => m.id == model.NombreMedico);
                if (medico != null)
                {
                    oConsulta.idmedico = medico.id;
                }

                // Buscar el ID del paciente por nombre
                var paciente = db.paciente.FirstOrDefault(m => m.id == model.NombrePaciente);
                if (paciente != null)
                {
                    oConsulta.idpaciente = paciente.id;
                }

                db.consulta.Add(oConsulta);
                db.SaveChanges();
            }

            return Redirect(Url.Content("~/Consulta/"));
        }

    }
}