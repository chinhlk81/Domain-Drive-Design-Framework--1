using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
 

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
