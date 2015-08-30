 

using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
   public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClientService _clientService;
        public ClienteAppService(IClientService clientService)
            : base(clientService)
        {
            _clientService = clientService;
        }
        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return _clientService.ObterClientesEspeciais(_clientService.GetAll());
        }
    }
}
