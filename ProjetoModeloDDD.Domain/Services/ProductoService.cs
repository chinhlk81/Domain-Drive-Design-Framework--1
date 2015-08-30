
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProductoService : ServiceBase<Produto>, IProdutoService
    {
        
        private readonly IProdutoRepository _produtoRepository;
        public ProductoService(IProdutoRepository
            produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
         

        public IEnumerable<Produto> BuscaPoName(string name)
        {
            return _produtoRepository.BuscarPorNome(name);
        }
    }
}
