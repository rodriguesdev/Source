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
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Detalhes(int id)
        {
            ProdutoBusiness business = new ProdutoBusiness();
            Produto model = business.ObterProduto(id);

            return View(model);
        }

    }
}