using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevIo.Business.Models.Fornecedores.Services;
using DevIo.Infra.Data.Repository;
using DevIo.Business.Models.Fornecedores;
using System.Threading.Tasks;

namespace DevIo.AppMvc.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController()
        {
            _fornecedorService = new FornecedorService(new FornecedorRepository(), new EnderecoRepository());
        }
       

        public async  Task<ActionResult> Index()
        {

            var fornecedor = new Fornecedor()
            {
                Nome = "",
                Documento = "1111",
                Endereco = new Endereco(),
                TipoFornecedor = TipoFornecedor.PessoaFisica,
                Ativo = true

            };

            await _fornecedorService.Adicionar(fornecedor);

            return new EmptyResult();
        }
    }
}