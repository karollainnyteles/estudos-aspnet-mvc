﻿using DevIo.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Infra.Mappings
{
    class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.Nome).IsRequired().HasMaxLength(200);
            Property(p => p.Descricao).IsRequired().HasMaxLength(1000);
            Property(p => p.Imagem).IsRequired().HasMaxLength(100);

            //Relacionamentos
            HasRequired(p => p.Fornecedor).WithMany(f => f.Produtos).HasForeignKey(p => p.FornecedorId);

            ToTable("Produtos");
        }
    }
}
