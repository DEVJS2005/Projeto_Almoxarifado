using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almoxarifado.Controllers
{
    public class AreaController : Controller
    {
        BDAlmoxarifadoEntities db = new BDAlmoxarifadoEntities();
        // GET: Area
        public ActionResult areaIndex()
        {
            return View();
        }
        [HttpGet]
        public ActionResult areaCadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult areaCadastro(string areaDescricao)
        {
            Area area = new Area();
            area.areaDescricao = areaDescricao;
            db.Area.Add(area);
            db.SaveChanges();
            return View(db.Area.ToList());
        }
    }
}