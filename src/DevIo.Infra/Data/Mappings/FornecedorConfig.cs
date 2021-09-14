using DevIo.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Infra.Mappings
{
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            HasKey(f => f.Id); // definindo id como chave primária da tabela forncedor
            Property(f => f.Nome).IsRequired().HasMaxLength(200);
            Property(f => f.Documento).IsRequired().HasMaxLength(14).HasColumnAnnotation("IX_Documento",
                new IndexAnnotation( new IndexAttribute { IsUnique = true}));

            HasRequired(f => f.Endereco).WithRequiredPrincipal(e=>e.Fornecedor);// fornecedor tem q ter endereco

            ToTable("Fornecedores");// mapeando para a tabela
        }
    }
}
