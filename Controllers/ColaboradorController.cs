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
        private static int idColaborador;
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
        public ActionResult colaboradorDetalhe(int id)
        {
            Colaborador col = db.Colaborador.ToList().Find(x => Equals(x.idColaborador, id));
            return View(col);
        }
        public ActionResult colaboradorExcluir(int id)
        {
            Colaborador col = db.Colaborador.ToList().Find(x => Equals(x.idColaborador,id));
            db.Colaborador.Remove(col);
            db.SaveChanges();   
            return View("colaboradorIndex", db.Colaborador.ToList());
        }
        public ActionResult colaboradorEditar(int id)
        {
            Colaborador col = db.Colaborador.ToList().Find(x => Equals(x.idColaborador,id));
            return View(col);
        }

        [HttpPost]
        public ActionResult colaboradorEditar(int id,string nomeColaborador,string cargoColaborador,int idArea)
        {
            Colaborador col = db.Colaborador.ToList().Find(x => Equals(x.idColaborador, id));
            Area ar = db.Area.ToList().Find(x => x.idArea == idArea);
            col.idColaborador = id;
            col.nomeColaborador = nomeColaborador;
            col.cargoColaborador = cargoColaborador;
            col.Area.areaDescricao = ar.areaDescricao;
            col.idArea = idArea;
            db.SaveChanges();
            return View("colaboradorIndex",db.Colaborador.ToList());
        }

        public ActionResult colAlterarArea(int idCol)
        {
            idColaborador = idCol;
            return View(db.Area.ToList());
        }

        [HttpPost]
        public ActionResult alterarArea(int idArea)
        {
            Colaborador col = db.Colaborador.ToList().Find(x => x.idColaborador == idColaborador);
            col.idArea = idArea;
            db.SaveChanges();

            return RedirectToAction("colaboradorIndex", "Colaborador");
        }
    }
}