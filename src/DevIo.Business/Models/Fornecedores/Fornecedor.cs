using DevIo.Business.Core.Models;
using DevIo.Business.Models.Fornecedores.Validations;
using DevIo.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* Relação com EF*/

        public ICollection<Produto> Produtos { get; set; }

        public bool Validacao()
        {
            var validacao = new FornecedorValidation();
            var resultado = validacao.Validate(this);

            return resultado.IsValid;
        }

    }
}
