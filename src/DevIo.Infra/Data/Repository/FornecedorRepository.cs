using DevIo.Business.Models.Fornecedores;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);// faz um join de fornecedores e endereco
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .Include(f => f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);// faz um join de fornecedores, produtos e endereco
        }
}
