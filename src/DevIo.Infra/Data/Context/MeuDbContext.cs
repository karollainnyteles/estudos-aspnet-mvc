using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIo.Business.Models.Fornecedores;
using DevIo.Business.Models.Produtos;

namespace DevIo.Infra.Data.Context
{
    class MeuDbContext : DbContext
    {
        public MeuDbContext() : base("DefaultConnection")
        {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
