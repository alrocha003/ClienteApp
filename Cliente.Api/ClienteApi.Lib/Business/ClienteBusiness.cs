using System;
using System.Collections.Generic;
using ClienteApi.Lib.Repository;
using ClienteApi.Lib.Models;

namespace ClienteApi.Lib.Business
{
    public class ClienteBusiness
    {
        private ClienteRepository _repository { get; set; } = new ClienteRepository();
        public List<Cliente> GetClientes() => _repository.GetClientes();
        public void AddCliente(Cliente cliente) => _repository.Add(cliente);
        public void Update(Cliente cliente) => _repository.Update(cliente);
        public Cliente GetCliente(int Id) => _repository.GetCliente(Id);

    }
}