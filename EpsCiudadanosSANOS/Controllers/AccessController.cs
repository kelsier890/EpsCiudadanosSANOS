using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpsCiudadanosSANOS.Models;

namespace EpsCiudadanosSANOS.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                using (EpsEntities db = new EpsEntities())
                {
                    var lst= from d in db.user
                             where d.nombre == user && d.password==password && d.idState==1
                             select d;

                    if(lst.Count() > 0 )
                    {
                        user oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario incorrecto, inicie sesion nuevamente.");
                    }
                }
            }
            catch(Exception ex)
            {
                return Content("Ocurrió un Error"+ ex.Message);
            }
        }

       
    }
}