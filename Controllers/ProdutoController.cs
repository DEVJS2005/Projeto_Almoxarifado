using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Services.Description;

namespace Almoxarifado.Controllers
{
    public class ProdutoController : Controller
    {
        BDAlmoxarifadoEntities2 db  = new BDAlmoxarifadoEntities2();
        // GET: Produto
        public ActionResult produtoIndex()
        {
            return View(db.Produto.ToList());
        }

        public ActionResult produtoCadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult produtoCadastro(string descricaoProduto,int produtoMax, int produtoMin)
        {
            Produto prod = new Produto();
            prod.descricaoProduto = descricaoProduto;
            prod.produtoMin = produtoMin;   
            prod.produtoMax = produtoMax;

            db.Produto.Add(prod);
            db.SaveChanges();
            return View("produtoIndex",db.Produto.ToList());
        }

        public ActionResult produtoDetalhe(int id)
        {
            Produto prod = db.Produto.ToList().Find(x => x.idProduto == id);
            return View(prod);
        }

        public ActionResult produtoEditar(int id)
        {
            Produto prod = db.Produto.ToList().Find(x => x.idProduto == id);
            return View(prod);
        }

        [HttpPost]
        public ActionResult produtoEditar(int id,string descricaoProduto,int produtoMin, int produtoMax)
        {
            Produto prod = db.Produto.ToList().Find(x => x.idProduto == id);
            prod.idProduto = id;
            prod.descricaoProduto = descricaoProduto;
            prod.produtoMin = produtoMin;
            prod.produtoMax = produtoMax;

            db.SaveChanges();
            return View("produtoIndex", db.Produto.ToList());
        }

        public ActionResult produtoExcluir(int id)
        {
            Estoque prod = db.Estoque.ToList().Find(x => Equals(x.idEstoque, id));

            db.Estoque.Remove(prod);
            db.SaveChanges();

            return RedirectToAction("produtoIndex",db.Produto.ToList());
        }
    }
}