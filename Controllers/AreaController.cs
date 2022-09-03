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
        BDAlmoxarifadoEntities2 db = new BDAlmoxarifadoEntities2();
        // GET: Area
        public ActionResult areaIndex()
        {
            return View(db.Area.ToList());
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
            return View("areaIndex",db.Area.ToList());
        }


        public ActionResult areaDetalhe(int id)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == id );
            return View(area);
        }

        [HttpGet]
        public ActionResult areaEditar(int id)
        {
            Area area = db.Area.ToList().Find(x => Equals(x.idArea, id));
            return View(area);
        }

        [HttpPost]
        public ActionResult areaEditar(int idArea,string areaDescricao)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == idArea);
            area.idArea = idArea;
            area.areaDescricao = areaDescricao;
            db.SaveChanges();

            return View("areaIndex", db.Area.ToList());
        }

        [HttpGet]
        public ActionResult areaExcluir(int id)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == id);
            db.Area.Remove(area);
            db.SaveChanges();
            return View("areaIndex", db.Area.ToList());
        }


        public ActionResult areaDetalhe(int id)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == id );
            return View(area);
        }

        [HttpGet]
        public ActionResult areaEditar(int id)
        {
            Area area = db.Area.ToList().Find(x => Equals(x.idArea, id));
            return View(area);
        }

        [HttpPost]
        public ActionResult areaEditar(int idArea,string areaDescricao)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == idArea);
            area.idArea = idArea;
            area.areaDescricao = areaDescricao;
            db.SaveChanges();

            return View("areaIndex", db.Area.ToList());
        }

        [HttpGet]
        public ActionResult areaExcluir(int id)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == id);
            db.Area.Remove(area);
            db.SaveChanges();
            return View("areaIndex", db.Area.ToList());
        }
    }
}