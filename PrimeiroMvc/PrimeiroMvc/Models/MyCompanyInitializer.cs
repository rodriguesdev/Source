using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiroMvc.Models
{
    public class MyCompanyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MyCompanyContext>
    {
        protected override void Seed(MyCompanyContext context)
        {
            var produtos = new List<Produto>
            {
                new Produto
                {
                    ID = 1,
                    Nome = "Mouse",
                    Preco = 50.9,
                    Datacriacao = DateTime.Now,
                    Descricao = "Mouse Microsoft"
                },

                new Produto
                {
                    ID = 2,
                    Nome = "Monitor",
                    Preco = 760.9,
                    Datacriacao = DateTime.Now,
                    Descricao = "Monitor LG"
                },

                new Produto
                {
                    ID = 3,
                    Nome = "teclado",
                    Preco = 100,
                    Datacriacao = DateTime.Now,
                    Descricao = "Teclado Razer"
                },

                new Produto
                {
                    ID = 4,
                    Nome = "Impressora",
                    Preco = 468.8,
                    Datacriacao = DateTime.Now,
                    Descricao = "Impressora HP"
                },
            };

            produtos.ForEach(s => context.Produtos.Add(s));

            context.SaveChanges();
        }

    }
}