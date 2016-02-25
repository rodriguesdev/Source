using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimeiroMvc.Models;

namespace PrimeiroMvc.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            using (MyCompanyContext db = new MyCompanyContext())
            {
                return View(db.Produtos.ToList());
            } 
        }

        public ActionResult Detalhes(int id)
        {
            using (MyCompanyContext db = new MyCompanyContext())
            {
                Produto model = db.Produtos.Find(id);
                return View(model);
            }
            
        }

    }
}