using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroMvc.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Nome é requirido")]
        public string Nome { get; set; }

        [StringLength(3000, ErrorMessage = "A descrição deve possuir menos de 3000 caracteres")]
        [DisplayName("Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required]
        [Range(typeof(double), "0,0","999999999,0", ErrorMessage = "O preço deve ser entre {1} e {2}")]
        [DisplayName("Preço")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public Double Preco { get; set; }

        [Required(ErrorMessage = "Campo data de cadastro é requerido")]
        [DisplayName("Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
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