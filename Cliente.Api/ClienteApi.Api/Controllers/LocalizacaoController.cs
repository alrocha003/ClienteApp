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
    public class LocalizacaoController : ControllerBase
    {
        public LocalizacaoBusiness business { get; set; } = new LocalizacaoBusiness();
        [Route("/")]
        [HttpGet]
        public ActionResult<IEnumerable<Localizacao>> GetAll() => business.GetLocalizacoes();
    }
}