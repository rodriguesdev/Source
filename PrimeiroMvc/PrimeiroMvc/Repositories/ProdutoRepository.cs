using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrimeiroMvc.Models;

namespace PrimeiroMvc.Repositories
{
    public class ProdutoRepository
    {
       public List<Produto> ObterProdutos()
        {
            using (MyCompanyContext db = new MyCompanyContext())
            {
                return db.Produtos.ToList();
            }
        }

        public Produto ObterProduto(int id)
        {
            using (MyCompanyContext db = new MyCompanyContext())
            {
                Produto model = db.Produtos.Find(id);

                return model;
            }
        }

        public List<Produto> BuscarProdutos(string nome)
        {
            using (MyCompanyContext db = new MyCompanyContext())
            {
                var produtos = db.Produtos.Where(p => p.Nome.Contains(nome));
                return produtos.ToList();
            }
        }

        public Produto AtualizarProduto(Produto produto)
        {
            using (MyCompanyContext db = new MyCompanyContext())
            {
                db.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return produto;
            }
        }
    }
}