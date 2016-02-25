using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimeiroMvc.Models
{
    public class MyCompanyContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}