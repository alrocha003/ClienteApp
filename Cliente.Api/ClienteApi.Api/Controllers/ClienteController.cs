using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClienteApi.Lib.Business;
using ClienteApi.Lib.Models;

namespace ClienteApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteBusiness businesss { get; set; } = new ClienteBusiness();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get() => Json(businesss.GetClientes());

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id) => Json(businesss.GetCliente(id));

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente cliente) => businesss.AddCliente(cliente);

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] ClienteBusiness cliente) => businesss.Update(cliente);
    }
}
