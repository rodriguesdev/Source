using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimeiroMvc.Models;
using PrimeiroMvc.Repositories;

namespace PrimeiroMvc.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutoRepository repository = new ProdutoRepository();
            return View(repository.ObterProdutos());
        }

        public ActionResult Detalhes(int id)
        {
            ProdutoRepository repository = new ProdutoRepository();
            return View(repository.ObterProduto(id));
        }

    }
}