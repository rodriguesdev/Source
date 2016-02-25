using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiroMvc.Models
{
    public class Produto
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Double Preco { get; set; }

        public DateTime Datacriacao { get; set; }
    }

    public class ProdutoBusiness
    {
        public Produto ObterProduto(int id)
        {
            Produto prod = new Produto();
            prod.ID = id;
            prod.Nome = "Produto " + id.ToString();
            prod.Descricao = "Descrição do Produto " + id.ToString();

            return prod;
        }
    }
}