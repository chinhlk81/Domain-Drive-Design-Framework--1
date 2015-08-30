

using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
   public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _ProdutoService;
        public ProdutoAppService(IProdutoService ProdutoService)
            : base(ProdutoService)
        {
            _ProdutoService = ProdutoService;
        } 
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _ProdutoService.BuscaPoName(nome);
        }
    }
}
