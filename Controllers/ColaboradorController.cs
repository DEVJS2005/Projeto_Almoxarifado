using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almoxarifado.Controllers
{
    public class ColaboradorController : Controller
    {
        // GET: Colaborador
        BDAlmoxarifadoEntities2 db = new BDAlmoxarifadoEntities2();
        public ActionResult colaboradorIndex()
        {
            return View(db.Colaborador.ToList()) ;
        }
        public ActionResult colaboradorCadastro()
        {
            return View(db.Area.ToList());
        }

        [HttpPost]
        public ActionResult colaboradorCadastro(string nomeColaborador,string cargoColaborador,string areaColaborador,int idArea)
        {
            Area area = db.Area.ToList().Find(x => x.idArea == idArea);
            Colaborador colaborador = new Colaborador();
            colaborador.nomeColaborador = nomeColaborador;
            colaborador.cargoColaborador = cargoColaborador;
            colaborador.idArea = area.idArea;
            colaborador.Area = area;

            db.Colaborador.Add(colaborador);
            db.SaveChanges();
            return View("colaboradorIndex", db.Colaborador.ToList());
        }
        public ActionResult colaboradorExcluir(int id)
        {
            Colaborador col = db.Colaborador.ToList().Find(x => Equals(x.idColaborador,id));
            db.Colaborador.Remove(col);
            db.SaveChanges();   
            return View("colaboradorIndex", db.Colaborador.ToList());
        }
    }
}