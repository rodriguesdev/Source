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

        public ActionResult Pesquisa(string nome)
        {
            ProdutoRepository repository = new ProdutoRepository();
            return View("Index",repository.BuscarProdutos(nome));
        }

        public ActionResult Editar(int id)
        {
            ProdutoRepository repository = new ProdutoRepository();
            Produto produto = repository.ObterProduto(id);
            return View(produto);
        }

        [HttpPost]
        public ActionResult editar(int hdfID, string txtNome, double txtPreco, DateTime txtDataCriacao, string txtDescricao)
        {
            Produto produto = new Produto();
            produto.ID = hdfID;
            produto.Nome = txtNome;
            produto.Preco = txtPreco;
            produto.Datacriacao = txtDataCriacao;
            produto.Descricao = txtDescricao;

            ProdutoRepository repository = new ProdutoRepository();
            repository.AtualizarProduto(produto);

            return RedirectToAction("index");
        }

    }
}