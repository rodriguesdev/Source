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
    }
}